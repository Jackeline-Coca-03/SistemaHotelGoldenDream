using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente
    {
        public int id_cliente { get; set; }
        public int ci { get; set; }
        public string nombreCompleto { get; set; }
        public int celular { get; set; }
        public bool estado { get; set; }
    }
}