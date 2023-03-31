using AutoMapper;
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
    public class RoleController : Controller
    {


        private readonly TerminalService _terminalService;
        private readonly IMapper _mapper;

        public RoleController(TerminalService terminalService, IMapper mapper)
        {
            _terminalService = terminalService;
            _mapper = mapper;
        }

        [HttpGet("Roles/Index")]
        public IActionResult List()
        {
            var listado = _terminalService.ListadoRoles();
            return Ok(listado);
        }


        [HttpGet("Roles/Insertar")]
        public IActionResult Create(string item)
        {
            var listado = _terminalService.InsertarRoles(item);
            return Ok(listado);
        }


        [HttpGet("Roles/Find/{id}")]
        public IActionResult Edit(int id)
        {
            var listado = _terminalService.BuscarRoles(id);
            return Ok(listado);
        }

        [HttpPut("Roles/Update/{id}")]
        public IActionResult Edit(RolesViewModel rolesViewModel)
        {
            var listado = _mapper.Map<tbRoles>(rolesViewModel);
            var Result = _terminalService.ActualizarRoles(listado);
            return Ok(Result);
        }

        [HttpPost("Roles/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var listado = _terminalService.DeleterRoles(id);
            return Ok();
        }

        /////////////////////////////////////////////////////////////


        [HttpGet("RolesXPantalla/Index")]
        public IActionResult ListX()
        {
            var listado = _terminalService.ListadoRolesX();
            return Ok(listado);
        }

        [HttpPost("RolesXPantalla/Insertar")]
        public IActionResult CreateX(RolXPantallaViewModel item)
        {
            var listadoMapeado = _mapper.Map<tbRolesXPantallas>(item);
            var listado = _terminalService.InsertarRolesX(listadoMapeado);
            return Ok(listado);
        }


        [HttpGet("RolesXPantalla/Find/{id}")]
        public IActionResult EditX(int id)
        {
            var listado = _terminalService.BuscarRolesX(id);
            return Ok(listado);
        }

        [HttpPut("RolesXPantalla/Update/{id}")]
        public IActionResult EditX(RolXPantallaViewModel rolesViewModel)
        {
            var listado = _mapper.Map<tbRolesXPantallas>(rolesViewModel);
            var Result = _terminalService.ActualizarRolesX(listado);
            return Ok(Result);
        }
    }
}
