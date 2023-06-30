using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Habitacion
    {
        private CD_Habitacion objcd_habitacion = new CD_Habitacion();
        public List<Habitacion> listar()
        {
            return objcd_habitacion.listar();
        }
    }
}
