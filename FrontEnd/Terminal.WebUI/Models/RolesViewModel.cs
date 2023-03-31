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
        public int? role_Estado { get; set; }
        public int? role_UsuarioCreador { get; set; }
        public DateTime? role_FechaCreacion { get; set; }
        public int? role_UsuarioModificador { get; set; }
        public DateTime? role_FechaModificacion { get; set; }

    }
}
