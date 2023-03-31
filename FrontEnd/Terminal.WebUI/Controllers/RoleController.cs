using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
    public class RoleController : Controller
    {

        private static string _baseurl;

        public RoleController()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            _baseurl = builder.GetSection("ApiSettings:BaseUrl").Value;

        }
        public async Task<IActionResult> Index()
        {
            List<RolesViewModel> listado = new List<RolesViewModel>();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + "Roles/Index");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    listado = JsonConvert.DeserializeObject<List<RolesViewModel>>(jsonResponse);
                }
                return View(listado);
            }
        }


        public async Task<IActionResult> Details(int id)
        {
            List<RolesViewModel> listado = new List<RolesViewModel>();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + "Roles/Index");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    listado = JsonConvert.DeserializeObject<List<RolesViewModel>>(jsonResponse);
                }
                return View(listado.Where(x => x.role_ID == id));
            }
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Create(RolesViewModel cargos)
        {
            if (ModelState.IsValid)
            {
                using (var httpClient = new HttpClient())
                {
                    var content = new StringContent(JsonConvert.SerializeObject(cargos), Encoding.UTF8, "application/json");
                    var response = await httpClient.GetAsync(_baseurl + $"Roles/Insertar?item={cargos.role_Descripcion}'");

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

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + $"Roles/Find/{id}");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var cliente = JsonConvert.DeserializeObject<RolesViewModel>(content);
                    return View(cliente);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(RolesViewModel cargos)
        {
            if (ModelState.IsValid)
            {
                using (var httpClient = new HttpClient())
                {
                    var content = new StringContent(JsonConvert.SerializeObject(cargos), Encoding.UTF8, "application/json");
                    var response = await httpClient.PutAsync(_baseurl + $"Roles/Update/{cargos.role_ID}", content);

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
                var response = await httpClient.PostAsync(_baseurl + $"api/Cargos/Cargo/Delete/{id}", null);

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


        ////////////
        ///
        public async Task<IActionResult> CreateX(int valor)
        {
            if (ModelState.IsValid)
            {
                using (var httpClient = new HttpClient())
                {
                    var content = new StringContent(JsonConvert.SerializeObject(valor), Encoding.UTF8, "application/json");
                    var response = await httpClient.PostAsync(_baseurl + "RolesXPantalla/Insertar", content);

                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index", "Role");
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
    }
}
