using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Terminal.API.Models;
using Terminal.BusinessLogic.Services;
using Terminal.Entities.Entities;

namespace Terminal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly AccesoService _accesoService;
        private readonly IMapper _mapper;

        public UsuarioController(AccesoService accesoService, IMapper mapper)
        {
            _accesoService = accesoService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult List()
        {
            var listado = _accesoService.ListadoUsuarios();
            return Ok(listado);
        }

        [HttpGet("Login")]
        public IActionResult Login(string user, string contrasena)
        {
            var listado = _accesoService.Login(user,contrasena);
            return Ok(listado);
        }

        [HttpPut("Roles")]
        public IActionResult Roles(int role_ID, bool esAdmin)
        {
            var listado = _accesoService.Roles(role_ID, esAdmin);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Create(UsuariosViewModel item)
        {
            var listadoMapeado = _mapper.Map<tbUsuarios>(item);
            var listado = _accesoService.InsertarUsuarios(listadoMapeado);
            return Ok(listado);
        }

        [HttpGet("Usuario/Find/{id}")]
        public IActionResult Edit(int id)
        {
            var listado = _accesoService.BuscarUsuarios(id);
            return Ok(listado);
        }

        [HttpPut("Usuario/Update/{id}")]
        public IActionResult Edit(UsuariosViewModel usuariosViewModel)
        {
            var listado = _mapper.Map<tbUsuarios>(usuariosViewModel);
            var Result = _accesoService.UpdateUsuarios(listado);
            return Ok(Result);
        }

        [HttpPut("Recover")]
        public IActionResult Recover(string usuario,string contrasena)
        {
            var Result = _accesoService.Recover(usuario, contrasena);
            return Ok(Result);
        }

        [HttpPost("Usuario/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var listado = _accesoService.BorrarUsuarios(id);
            return Ok(listado);
        }
    }
}
