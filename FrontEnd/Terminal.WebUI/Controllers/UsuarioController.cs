using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public class UsuarioController : Controller
    {
        private static string _baseurl;

        public UsuarioController()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            _baseurl = builder.GetSection("ApiSettings:BaseUrl").Value;

        }

        public async Task<IActionResult> Index()
        {
            List<EmpleadoViewModel> empleado = new List<EmpleadoViewModel>();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + "api/Empleado");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    empleado = JsonConvert.DeserializeObject<List<EmpleadoViewModel>>(jsonResponse);
                    ViewBag.empl_ID = new SelectList(empleado, "empl_ID", "empl_NombreCompleto");
                }
            }


            List<UsuariosViewModel> listado = new List<UsuariosViewModel>();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + "api/Usuario");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    listado = JsonConvert.DeserializeObject<List<UsuariosViewModel>>(jsonResponse);
                }
                return View(listado);
            }

        }


        public async Task<IActionResult> Details(int id)
        {

            List<UsuariosViewModel> listado = new List<UsuariosViewModel>();
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + "api/Usuario");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    listado = JsonConvert.DeserializeObject<List<UsuariosViewModel>>(jsonResponse);
                }
                return View(listado.Where(x => x.usua_ID == id));
            }
        }



        public async Task<IActionResult> Create(UsuariosViewModel usuariosViewModel)
        {
            if (ModelState.IsValid)
            {
                using (var httpClient = new HttpClient())
                {
                    var json = JsonConvert.SerializeObject(usuariosViewModel);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await httpClient.PostAsync(_baseurl + "api/Usuario/Insertar", content);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        JObject jsonObj = JObject.Parse(jsonResponse);
                        ViewBag.message = jsonObj["message"];

                        if (jsonObj["code"].ToString() == "200")
                        {
                            string script = "MostrarMensajeWarning('" + ViewBag.message + "'); Swal.fire( 'Agregado!, 'Registro agregado exitosamente!', 'success' )";
                            TempData["script"] = script;
                        }

                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View();
                    }
                }
            }
            else
            {
                ////Llenar ddl de Empelado
                //List<EmpleadoViewModel> empleado = new List<EmpleadoViewModel>();

                //using (var httpClient = new HttpClient())
                //{
                //    var response = await httpClient.GetAsync(_baseurl + "api/Empleado");

                //    if (response.IsSuccessStatusCode)
                //    {
                //        var jsonResponse = await response.Content.ReadAsStringAsync();
                //        empleado = JsonConvert.DeserializeObject<List<EmpleadoViewModel>>(jsonResponse);
                //        ViewBag.empl_ID = new SelectList(empleado, "empl_ID", "empl_NombreCompleto");
                //    }
                //}
                ////Fin Llenas ddl de empleado


                return View(usuariosViewModel);
            }
        }


        public async Task<IActionResult> Edit(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + $"api/Usuario/Usuario/Find/{id}");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var cliente = JsonConvert.DeserializeObject<UsuariosViewModel>(content);
                    return View(cliente);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }

        public async Task<IActionResult> Update(UsuariosViewModel usuariosViewModel)
        {
            if (ModelState.IsValid)
            {
                using (var httpClient = new HttpClient())
                {
                    var content = new StringContent(JsonConvert.SerializeObject(usuariosViewModel), Encoding.UTF8, "application/json");
                    var response = await httpClient.PutAsync(_baseurl + $"api/Usuario/Usuario/Update/{usuariosViewModel.usua_ID}", content);

                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View();
                    }
                }
            }
            else
            {
                return View();
            }

        }

        public async Task<IActionResult> Delete(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.PostAsync(_baseurl + $"api/Usuario/Usuario/Delete/{id}", null);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }

    }
}
