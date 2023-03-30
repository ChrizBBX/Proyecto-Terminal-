using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Terminal.WebUI.Models
{
    public class PantallaViewModel
    {
        public int pant_ID { get; set; }
        public string pant_Descripcion { get; set; }
        public string pant_URL { get; set; }
        public string pant_Menu { get; set; }
        public string pant_HtmlID { get; set; }
        public int? pant_Estado { get; set; }
        public int? pant_UsuarioCreador { get; set; }
        public DateTime? pant_FechaCreacion { get; set; }
        public int? pant_UsuarioModificador { get; set; }
        public DateTime? pant_FechaModificacion { get; set; }

        [NotMapped]
        public int role_ID { get; set; }
        [NotMapped]
        public bool usua_esAdmin { get; set; }
    }
}
