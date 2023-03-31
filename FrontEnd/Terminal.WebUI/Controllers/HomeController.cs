using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Terminal.WebUI.Models;

namespace Terminal.WebUI.Controllers
{
    public class HomeController : Controller
    {

        private static string _baseurl;

        public HomeController()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            _baseurl = builder.GetSection("ApiSettings:BaseUrl").Value;

        }

        public IActionResult Index()
        {
            string usua_ID = HttpContext.Session.GetString("usua_ID");
            if(usua_ID == "" || usua_ID == null)
            {
                HttpContext.Session.SetInt32("usua_ID", 0);
            }
            ViewBag.usua_empl_NombreCompleto = HttpContext.Session.GetString("usua_empl_NombreCompleto");
            return View();
        }

        public IActionResult Logout()
        {

            HttpContext.Session.SetInt32("usua_ID", 0);
            HttpContext.Session.SetString("usua_Usuario", "");
            HttpContext.Session.SetString("usua_EsAdmin", "");
            HttpContext.Session.SetInt32("empl_ID", 0);
            HttpContext.Session.SetString("usua_empl_NombreCompleto", "");
            HttpContext.Session.SetInt32("carg_ID", 0);
            HttpContext.Session.SetInt32("role_ID", 0);
            HttpContext.Response.Headers.Add("Cache-Control", "no-cache, no-store, must-revalidate");
            HttpContext.Response.Headers.Add("Pragma", "no-cache");
            HttpContext.Response.Headers.Add("Expires", "0");

            return RedirectToAction("Index", "Login");
        }

        public async Task<IActionResult> PantallasMenu(PantallaViewModel item)
        {
            item.role_ID = (int)HttpContext.Session.GetInt32("role_ID");
            string EsAdmin = HttpContext.Session.GetString("usua_EsAdmin");
            item.usua_esAdmin = Convert.ToBoolean(HttpContext.Session.GetString("usua_EsAdmin"));

            using (var httpClient = new HttpClient())
            {

                var json = JsonConvert.SerializeObject(item);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await httpClient.PutAsync(_baseurl + $"api/Usuario/Roles?role_ID={item.role_ID}&esAdmin={EsAdmin}", content);
                //var response = await client.PutAsync(_baseurl + $"api/Usuario/Roles?role_ID={item.role_ID}&esAdmin={1}'", content);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                //JObject jsonObj = JObject.Parse(jsonResponse);

                var pantalla = JsonConvert.DeserializeObject<List<PantallaViewModel>>(jsonResponse.ToString());

                return Json(pantalla);
            }
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
