using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int id_usuario { get; set; }
        public int ci { get; set; }
        public string nombreCompleto { get; set; }
        public string cuenta { get; set; }
        public string pasword { get; set; }
        public Rol oRol { get; set; }
        public bool estado { get; set; }
    }
}