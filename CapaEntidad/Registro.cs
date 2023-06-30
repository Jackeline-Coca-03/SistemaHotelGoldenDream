using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Registro
    {
        public int id_registro { get; set; }
        public Usuario oUsuario { get; set; }
        public int num_registro { get; set; }
        public int ci_cliente { get; set; }
        public string nombre_cliente { get; set; }
        public decimal monto_pago { get; set; }
        public decimal monto_canbio { get; set; }
        public decimal monto_total { get; set; }
        public List<Detalle> oDetalles { get; set; }
        public string fecha_registro { get; set; }
    }
}