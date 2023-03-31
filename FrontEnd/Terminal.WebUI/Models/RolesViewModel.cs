using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Terminal.WebUI.Models
{
    public class RolesViewModel
    {

        [Display(Name = "ID")]
        public int role_ID { get; set; }

        [Display(Name = "Descripcion")]

        public string role_Descripcion { get; set; }

        [Display(Name = "Estado")]

        public int? role_Estado { get; set; }

        [Display(Name = "Usuario Creador ")]

        public int? role_UsuarioCreador { get; set; }


        [Display(Name = "Fecha creación")]
        public DateTime? role_FechaCreacion { get; set; }


        [Display(Name = "Usuario Modificador")]
        public int? role_UsuarioModificador { get; set; }

        [Display(Name = "Fecha Modificación")]
        public DateTime? role_FechaModificacion { get; set; }

    }
}
