using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        private CD_Cliente objcd_cliente = new CD_Cliente();
        public List<Cliente> listar()
        {
            return objcd_cliente.listar();
        }

        public int Registrar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.nombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del cliente\n";
            }

            if (obj.ci == 0)
            {
                Mensaje += "Es necesario el numero de carnet de identidad del cliente\n";
            }

            if (obj.celular == 0)
            {
                Mensaje += "Es necesario el celular del cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_cliente.Registrar(obj, out Mensaje);
            }

        }

        public bool Editar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.nombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del cliente\n";
            }

            if (obj.ci == 0)
            {
                Mensaje += "Es necesario el numero de carnet de identidad del cliente\n";
            }

            if (obj.celular == 0)
            {
                Mensaje += "Es necesario el celular del cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_cliente.Eliminar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Cliente obj, out string Mensaje)
        {
            return objcd_cliente.Eliminar(obj, out Mensaje);
        }
    }
}
