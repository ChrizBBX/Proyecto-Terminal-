using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Terminal.API.Models
{
    public class HorariosViewModel
    {
        public int hora_ID { get; set; }
        public DateTime? hora_Salida { get; set; }
        public DateTime? hora_Llegada { get; set; }
        public string hora_Origen { get; set; }
        public string hora_Destino { get; set; }
        public int? hora_CantidadPasajerosMax { get; set; }
        public int? hora_CantidadPasajerosActual { get; set; }
        public decimal? hora_Precio { get; set; }
        public int? hora_Estado { get; set; }
        public int? hora_UsuarioCreador { get; set; }
        public DateTime? hora_FechaCreacion { get; set; }
        public int? hora_UsuarioModificador { get; set; }
        public DateTime? hora_FechaModificacion { get; set; }

    }
}
