﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Terminal.Entities.Entities
{
    public partial class tbTerminales
    {
        public tbTerminales()
        {
            tbBoletos = new HashSet<tbBoletos>();
        }

        public int term_ID { get; set; }
        public string muni_ID { get; set; }
        public string term_Nombre { get; set; }
        public string term_DireccionExacta { get; set; }
        public int? term_CantidadTransportes { get; set; }
        public int? term_Estado { get; set; }
        public int? term_UsuarioCreador { get; set; }
        public DateTime? term_FechaCreacion { get; set; }
        public int? term_UsuarioModificador { get; set; }
        public DateTime? term_FechaModificacion { get; set; }

        public virtual tbMunicipios muni { get; set; }
        public virtual tbUsuarios term_UsuarioCreadorNavigation { get; set; }
        public virtual tbUsuarios term_UsuarioModificadorNavigation { get; set; }
        public virtual ICollection<tbBoletos> tbBoletos { get; set; }
    }
}