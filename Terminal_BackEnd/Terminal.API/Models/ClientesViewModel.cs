﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Terminal.API.Models
{
    public class ClientesViewModel
    {
        public int clie_ID { get; set; }
        public string clie_Nombres { get; set; }
        public string clie_Apellidos { get; set; }
        public string clie_NombreCompleto { get; set; }
        public string clie_DNI { get; set; }
        public string clie_Sexo { get; set; }
        public string clie_Telefono { get; set; }
        public string clie_Email { get; set; }
        public int? clie_Estado { get; set; }
        public int? clie_UsuarioCreador { get; set; }
        public string clie_UsuarioCreador_Nombre { get; set; }
        public DateTime? clie_FechaCreacion { get; set; }
        public int? clie_UsuarioModificador { get; set; }
        public string clie_UsuarioModificador_Nombre { get; set; }
        public DateTime? clie_FechaModificacion { get; set; }
    }
}
