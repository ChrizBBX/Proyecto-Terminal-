﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Terminal.WebUI.Models
{
    public class ClientesModel
    {
        public int clie_ID { get; set; }
        public string clie_Nombres { get; set; }
        public string clie_Apellidos { get; set; }
        public string clie_DNI { get; set; }
        public string clie_Sexo { get; set; }
        public string clie_Telefono { get; set; }
        public string clie_Email { get; set; }
        public int? clie_Estado { get; set; }
        public int? clie_UsuarioCreador { get; set; }
        public DateTime? clie_FechaCreacion { get; set; }
        public int? clie_UsuarioModificador { get; set; }
        public DateTime? clie_FechaModificacion { get; set; }
    }
}
