using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Terminal.API.Models
{
    public class UsuariosViewModel
    {
        public int usua_ID { get; set; }
        public string usua_Usuario { get; set; }

        [NotMapped]
        public string usua_Pass { get; set; }

        public byte[] usua_Clave { get; set; }
        public bool usua_EsAdmin { get; set; }
        public int? empl_ID { get; set; }
        public string empl_PrimerNombre { get; set; }
        public string empl_SegundoNombre { get; set; }
        public string empl_PrimerApellido { get; set; }
        public string empl_SegundoApellido { get; set; }
        public string usua_empl_Nombres { get; set; }
        public string usua_empl_Apellidos { get; set; }
        public string usua_empl_NombreCompleto { get; set; }
        public string usua_UsuarioCreador_Nombre { get; set; }
        public string usua_UsuarioModificador_Nombre { get; set; }
        public int? usua_Estado { get; set; }
        public int? usua_UsuarioCreador { get; set; }
        public DateTime? usua_FechaCreacion { get; set; }
        public int? usua_UsuarioModificador { get; set; }
        public DateTime? usua_FechaModificacion { get; set; }
    }
}
