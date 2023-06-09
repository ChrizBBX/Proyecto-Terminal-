﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Terminal.Entities.Entities
{
    public partial class tbMunicipios
    {
        public tbMunicipios()
        {
            tbEmpleados = new HashSet<tbEmpleados>();
            tbTerminales = new HashSet<tbTerminales>();
        }

        public string dept_ID { get; set; }
        public string muni_ID { get; set; }
        public string muni_Descripcion { get; set; }
        public int? muni_Estado { get; set; }
        public int? muni_UsuarioCreador { get; set; }
        public DateTime? muni_FechaCreacion { get; set; }
        public int? muni_UsuarioModificador { get; set; }
        public DateTime? muni_FechaModificacion { get; set; }

        public virtual tbDepartamentos dept { get; set; }
        public virtual tbUsuarios muni_UsuarioCreadorNavigation { get; set; }
        public virtual tbUsuarios muni_UsuarioModificadorNavigation { get; set; }
        public virtual ICollection<tbEmpleados> tbEmpleados { get; set; }
        public virtual ICollection<tbTerminales> tbTerminales { get; set; }
    }
}