﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Terminal.Entities.Entities
{
    public partial class tbEmpleados
    {
        public tbEmpleados()
        {
            tbBoletos = new HashSet<tbBoletos>();
            tbUsuarios = new HashSet<tbUsuarios>();
        }

        public int empl_ID { get; set; }
        public string empl_PrimerNombre { get; set; }
        public string empl_SegundoNombre { get; set; }
        public string empl_PrimerApellido { get; set; }
        public string empl_SegundoApellido { get; set; }
        public string empl_DNI { get; set; }
        public DateTime? empl_FechaNacimiento { get; set; }
        public string empl_Sexo { get; set; }
        public string empl_Telefono { get; set; }
        public int? carg_ID { get; set; }
        public int? estciv_ID { get; set; }
        public string muni_ID { get; set; }
        public int? empl_Estado { get; set; }
        public int? empl_UsuarioCreador { get; set; }
        public DateTime? empl_FechaCreacion { get; set; }
        public int? empl_UsuarioModificador { get; set; }
        public DateTime? empl_FechaModificacion { get; set; }

        public virtual tbCargos carg { get; set; }
        public virtual tbUsuarios empl_UsuarioCreadorNavigation { get; set; }
        public virtual tbUsuarios empl_UsuarioModificadorNavigation { get; set; }
        public virtual tbEstadosCiviles estciv { get; set; }
        public virtual tbMunicipios muni { get; set; }
        public virtual ICollection<tbBoletos> tbBoletos { get; set; }
        public virtual ICollection<tbUsuarios> tbUsuarios { get; set; }
    }
}