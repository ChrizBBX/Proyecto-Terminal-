﻿using Microsoft.AspNetCore.Mvc;
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
    public class ClienteController : Controller
    {
        private static string _baseurl;

        public ClienteController()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            _baseurl = builder.GetSection("ApiSettings:BaseUrl").Value;

        }

        public async Task<IActionResult> Index()
        {

            List<ClientesModel> listado = new List<ClientesModel>();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + "api/Cliente");

                if (response.IsSuccessStatusCode)
                {
                    if (TempData["Script"] is string script)
                    {
                        TempData.Remove("Script");
                        ViewBag.Script = script;
                    }
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    listado = JsonConvert.DeserializeObject<List<ClientesModel>>(jsonResponse);
                }
                return View(listado);
            }

        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        public async Task<IActionResult> Create(ClientesModel cliente)
        {
            if (ModelState.IsValid)
            {
                using (var httpClient = new HttpClient())
                {
                    var json = JsonConvert.SerializeObject(cliente);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await httpClient.PostAsync(_baseurl + "api/Cliente/Insertar", content);

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

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + $"api/Cliente/Cliente/Find/{id}");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var cliente = JsonConvert.DeserializeObject<ClientesModel>(content);
                    return View(cliente);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ClientesModel cliente)
        {
            if (ModelState.IsValid)
            {
                using (var httpClient = new HttpClient())
                {
                    var json = JsonConvert.SerializeObject(cliente);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await httpClient.PutAsync(_baseurl + $"api/Cliente/Cliente/Update/{cliente.clie_ID}", content);

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
                return View(cliente);
            }
        }


        public async Task<IActionResult> Delete(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.PostAsync(_baseurl + $"api/Cliente/Cliente/Delete/{id}", null);

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
                    return RedirectToAction("Index");
                }
            }
        }

    }
}
