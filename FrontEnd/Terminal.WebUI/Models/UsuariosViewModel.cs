using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Terminal.WebUI.Models
{
    public class UsuariosViewModel
    {
        [Display(Name = "ID")]
        public int usua_ID { get; set; }

        [Display(Name = "Usuario")]
        public string usua_Usuario { get; set; }

        [Display(Name = "Clave")]
        public byte[] usua_Clave { get; set; }

        [NotMapped]
        [Display(Name = "Clave")]
        public string usua_Pass { get; set; }

        [Display(Name = "Es Admin?")]
        public bool usua_EsAdmin { get; set; }

        [Display(Name = "Empleado ID")]
        public int empl_ID { get; set; }

        [Display(Name = "Primer nombre")]
        public string empl_PrimerNombre { get; set; }


        [Display(Name = "Segundo nombre")]
        public string empl_SegundoNombre { get; set; }

        [Display(Name = "Primer apellido")]
        public string empl_PrimerApellido { get; set; }

        [Display(Name = "Segundo apellido")]
        public string empl_SegundoApellido { get; set; }

        [Display(Name = "Nombres")]
        public string usua_empl_Nombres { get; set; }

        [Display(Name = "Apellidos")]
        public string usua_empl_Apellidos { get; set; }

        [Display(Name = "Nombre completo")]
        public string usua_empl_NombreCompleto { get; set; }

        [Display(Name = "Cargo ID")]
        public int carg_ID { get; set; }

        [Display(Name = "Cargo")]
        public string carg_Nombre { get; set; }

        [Display(Name = "Rol ID")]
        public int role_ID { get; set; }

        [Display(Name = "Rol")]
        public string role_Descripcion { get; set; }

        [Display(Name = "Usuario creador")]
        public string usua_UsuarioCreador_Nombre { get; set; }

        [Display(Name = "Usuario modificador")]
        public string usua_UsuarioModificador_Nombre { get; set; }

        [Display(Name = "Estado")]
        public int? usua_Estado { get; set; }

        [Display(Name = "Usuario creador ID")]
        public int? usua_UsuarioCreador { get; set; }

        [Display(Name = "Fecha creación")]
        public DateTime? usua_FechaCreacion { get; set; }

        [Display(Name = "Usuario modificador ID")]
        public int? usua_UsuarioModificador { get; set; }

        [Display(Name = "Fecha modificación")]
        public DateTime? usua_FechaModificacion { get; set; }
    }
}
