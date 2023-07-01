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

        public int Registrar(Habitacion obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.codigohab == 0)
            {
                Mensaje += "Es necesario el codigo de habitacion\n";
            }

            if (obj.descripcion == "")
            {
                Mensaje += "Es necesario el numero de habitacion\n";
            }

            if (obj.precio == 0)
            {
                Mensaje += "Es necesario el precio de la habitacion\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_habitacion.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(Habitacion obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.codigohab == 0)
            {
                Mensaje += "Es necesario el codigo de habitacion\n";
            }

            if (obj.descripcion == "")
            {
                Mensaje += "Es necesario el numero de habitacion\n";
            }

            if (obj.precio == 0)
            {
                Mensaje += "Es necesario el precio de la habitacion\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_habitacion.Editar(obj, out Mensaje);
            }

        }
        public bool Eliminar(Habitacion obj, out string Mensaje)
        {
            return objcd_habitacion.Eliminar(obj, out Mensaje);
        }
    }
}
