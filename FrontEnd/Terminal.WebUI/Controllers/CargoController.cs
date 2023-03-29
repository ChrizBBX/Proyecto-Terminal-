using Microsoft.AspNetCore.Mvc;
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
    public class CargoController : Controller
    {
        private static string _baseurl;

        public CargoController()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            _baseurl = builder.GetSection("ApiSettings:BaseUrl").Value;

        }

        public async Task<IActionResult> Index()
        {
            List<CargosViewModel> listado = new List<CargosViewModel>();
            if (TempData["script"] is string script)
            {
                TempData.Remove("script");
                ViewBag.Script = script;
            }
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + "api/Cargos");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    listado = JsonConvert.DeserializeObject<List<CargosViewModel>>(jsonResponse);
                }
                return View(listado);
            }
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Create(CargosViewModel cargos)
        {
            if (ModelState.IsValid)
            {
                using (var httpClient = new HttpClient())
                {
                    var json = JsonConvert.SerializeObject(cargos);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await httpClient.PostAsync(_baseurl + "api/Cargos/Insertar", content);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        JObject jsonObj = JObject.Parse(jsonResponse);
                        ViewBag.message = jsonObj["message"];

                        if (jsonObj["code"].ToString() == "200")
                        {
                            string script = "MostrarMensajeSuccess('" + ViewBag.message + "');";
                            TempData["script"] = script;
                        }
                        else if (jsonObj["code"].ToString() == "409")
                        {
                            string script = "MostrarMensajeWarning('" + ViewBag.message + "'); $('#New').click();";
                            TempData["script"] = script;
                        }
                        else
                        {
                            string script = "MostrarMensajeDanger('" + ViewBag.message + "');";
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
                return View();
            }
        }


        public async Task<IActionResult> Edit(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + $"api/Cargos/Cargo/Find/{id}");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var cliente = JsonConvert.DeserializeObject<CargosViewModel>(content);
                    return View(cliente);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }


        public async Task<IActionResult> Update(CargosViewModel cargos)
        {
            if (ModelState.IsValid)
            {
                using (var httpClient = new HttpClient())
                {
                    var content = new StringContent(JsonConvert.SerializeObject(cargos), Encoding.UTF8, "application/json");
                    var response = await httpClient.PutAsync(_baseurl + $"api/Cargos/Cargo/Update/{cargos.carg_ID}", content);

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
    }
}
