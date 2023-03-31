using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Terminal.API.Models
{
    public class RolXPantallaViewModel
    {

        public int roleXpant_ID { get; set; }
        public int? role_ID { get; set; }
        public int? pant_ID { get; set; }
        public int? usua_ID { get; set; }
        public int? roleXpant_Estado { get; set; }
        public int? roleXpant_UsuarioCreador { get; set; }
        public DateTime? roleXpant_FechaCreacion { get; set; }
        public int? roleXpant_UsuarioModificador { get; set; }
        public DateTime? roleXpant_FechaModificacion { get; set; }

    }
}
