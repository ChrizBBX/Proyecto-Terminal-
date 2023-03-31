using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Terminal.WebUI.Models;

namespace Terminal.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private static string _baseurl;

        public LoginController()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            _baseurl = builder.GetSection("ApiSettings:BaseUrl").Value;

        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Recover()
        {
            return View();
        }

        public async Task<IActionResult> Login(string user, string contrasena)
        {
            using (var httpClient = new HttpClient())
            {
                List<UsuariosViewModel> listado = new List<UsuariosViewModel>();
                var response = await httpClient.GetAsync(_baseurl + $"api/Usuario/Login?user={user}&contrasena={contrasena}");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    listado = JsonConvert.DeserializeObject<List<UsuariosViewModel>>(jsonResponse);
                    if (listado.Count > 0)
                    {
                        int usua_Id = listado[0].usua_ID;
                        string usua_Usuario = listado[0].usua_Usuario;
                        bool usua_EsAdmin = listado[0].usua_EsAdmin;
                        int empl_ID = listado[0].empl_ID;
                        string usua_empl_NombreCompleto = listado[0].usua_empl_NombreCompleto;
                        int carg_ID = listado[0].carg_ID;
                        int role_ID = listado[0].role_ID;

                        HttpContext.Session.SetInt32("usua_ID", usua_Id);
                        HttpContext.Session.SetString("usua_Usuario", usua_Usuario);
                        HttpContext.Session.SetString("usua_EsAdmin", usua_EsAdmin.ToString());
                        HttpContext.Session.SetInt32("empl_ID", empl_ID);
                        HttpContext.Session.SetString("usua_empl_NombreCompleto", usua_empl_NombreCompleto);
                        HttpContext.Session.SetInt32("carg_ID", carg_ID);
                        HttpContext.Session.SetInt32("role_ID", role_ID);
                        ViewBag.usua_empl_NombreCompleto = HttpContext.Session.GetString("usua_empl_NombreCompleto");

                        return RedirectToAction("Index","Home");
                    }
                    else
                    {
                        ViewBag.user = user;
                        ViewBag.contrasena = contrasena;
                        ModelState.AddModelError("Validacion", "El usuario o contraseña son incorrectos");
                        HttpContext.Session.SetInt32("usua_ID", 0);
                        return View("Index");
                    }
                }
                else
                {
                    return View();
                }
            }
        }

        public async Task<IActionResult> Recover(string user, string contrasena)
        {
            using (var httpClient = new HttpClient())
            {
                var content = new StringContent("", Encoding.UTF8, "application/json");
                var response = await httpClient.PutAsync(_baseurl + $"api/Usuario/Recover?usuario={user}&contrasena={contrasena}",content);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.user1 = user;
                    ViewBag.contrasena1 = contrasena;
                    ModelState.AddModelError("Validacion1", "El usuario es incorrecto");
                    return View();
                }
            }
        }

    }
}
