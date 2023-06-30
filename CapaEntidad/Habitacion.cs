using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Habitacion
    {
        public int id_hab { get; set; }
        public int codigohab { get; set; }
        public string descripcion { get; set; }
        public int cantCamas { get; set; }
        public int num_personas { get; set; }
        public bool estado { get; set; }
        public decimal precio { get; set; }
    }

}