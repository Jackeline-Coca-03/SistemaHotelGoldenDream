using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalle
    {
        public int id_detalle { get; set; }
        public Habitacion oHabitacion { get; set; }
        public decimal precio_hosp { get; set; }
        public int cant_dia { get; set; }
        public int cant_noche { get; set; }
        public int cant_hab { get; set; }
        public string fechaIng { get; set; }
        public string fechaSal { get; set; }
        public decimal subtotal { get; set; }
        public string fecha_registro { get; set; }
    }

}