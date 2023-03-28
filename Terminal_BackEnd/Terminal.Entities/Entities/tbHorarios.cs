﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Terminal.Entities.Entities
{
    public partial class tbHorarios
    {
        public tbHorarios()
        {
            tbBoletos = new HashSet<tbBoletos>();
        }

        public int hora_ID { get; set; }
        public DateTime? hora_FechaSalida { get; set; }
        public DateTime? hora_FechaLlegada { get; set; }
        public string hora_Origen { get; set; }
        public string hora_Destino { get; set; }
        public int? hora_CantidadPasajeros { get; set; }
        public decimal? hora_Precio { get; set; }
        public int? hora_Estado { get; set; }
        public int? hora_UsuarioCreador { get; set; }
        public DateTime? hora_FechaCreacion { get; set; }
        public int? hora_UsuarioModificador { get; set; }
        public DateTime? hora_FechaModificacion { get; set; }

        public virtual tbDepartamentos hora_DestinoNavigation { get; set; }
        public virtual tbDepartamentos hora_OrigenNavigation { get; set; }
        public virtual tbUsuarios hora_UsuarioCreadorNavigation { get; set; }
        public virtual tbUsuarios hora_UsuarioModificadorNavigation { get; set; }
        public virtual ICollection<tbBoletos> tbBoletos { get; set; }
    }
}