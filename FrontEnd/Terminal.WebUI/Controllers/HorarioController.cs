using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class HorarioController : Controller
    {
        private static string _baseurl;

        public HorarioController()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            _baseurl = builder.GetSection("ApiSettings:BaseUrl").Value;

        }

        public async Task<IActionResult> Index()
        {

            List<HorariosViewModel> listado = new List<HorariosViewModel>();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + "api/Horario");

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    listado = JsonConvert.DeserializeObject<List<HorariosViewModel>>(jsonResponse);
                }
                return View(listado);
            }
        }



        [HttpGet]
        public async Task<IActionResult> Create()
        {
            using (var httpClient = new HttpClient())
            {
                var depa = await httpClient.GetAsync(_baseurl + "api/Terminal/LoadDepartamento");

                if (depa.IsSuccessStatusCode)
                {

                    var content = await depa.Content.ReadAsStringAsync();
                    var departamentos = JsonConvert.DeserializeObject<List<DepartamentoViewModel>>(content);
                    ViewBag.departamento = new SelectList(departamentos, "dept_ID", "dept_Descripcion");
                }
            }
            return View();
        }


        public async Task<IActionResult> Create(HorariosViewModel horarios)
        
        {
            if (ModelState.IsValid)
            {
                using (var httpClient = new HttpClient())
                {
                    var content = new StringContent(JsonConvert.SerializeObject(horarios), Encoding.UTF8, "application/json");
                    var response = await httpClient.PostAsync(_baseurl + "api/Horario/Insertar", content);

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
                using (var httpClient = new HttpClient())
                {
                    var depa = await httpClient.GetAsync(_baseurl + "api/Terminal/LoadDepartamento");

                    if (depa.IsSuccessStatusCode)
                    {

                        var content = await depa.Content.ReadAsStringAsync();
                        var departamentos = JsonConvert.DeserializeObject<List<DepartamentoViewModel>>(content);
                        ViewBag.departamento = new SelectList(departamentos, "dept_ID", "dept_Descripcion");
                    }
                }
                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var depa = await httpClient.GetAsync(_baseurl + "api/Terminal/LoadDepartamento");

                if (depa.IsSuccessStatusCode)
                {

                    var content = await depa.Content.ReadAsStringAsync();
                    var departamentos = JsonConvert.DeserializeObject<List<DepartamentoViewModel>>(content);
                    ViewBag.departamento = new SelectList(departamentos, "dept_ID", "dept_Descripcion");
                }
            }

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + $"api/Horario/Horario/Find/{id}");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var cliente = JsonConvert.DeserializeObject<HorariosViewModel>(content);
                    return View(cliente);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(HorariosViewModel horarios)
        {
            if (ModelState.IsValid)
            {
                using (var httpClient = new HttpClient())
                {
                    var content = new StringContent(JsonConvert.SerializeObject(horarios), Encoding.UTF8, "application/json");
                    var response = await httpClient.PutAsync(_baseurl + $"api/Horario/Horario/Update/{horarios.hora_ID}", content);

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
                var response = await httpClient.PostAsync(_baseurl + $"api/Horario/Horario/Delete/{id}", null);

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
