﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PruebaApi.Entities.Entities
{
    public partial class tbEstadosCiviles
    {
        public tbEstadosCiviles()
        {
            tbEmpleados = new HashSet<tbEmpleados>();
        }

        public int estciv_ID { get; set; }
        public string estciv_Descripcion { get; set; }
        public int? estciv_Estado { get; set; }
        public int? estciv_UsuarioCreador { get; set; }
        public DateTime? estciv_FechaCreacion { get; set; }
        public int? estciv_UsuarioModificador { get; set; }
        public DateTime? estciv_FechaModificacion { get; set; }

        public virtual ICollection<tbEmpleados> tbEmpleados { get; set; }
    }
}