using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaHotel
{
    public class CN_Permiso
    {
        private CD_Permiso objcd_permiso = new CD_Permiso();
        public List<Permiso> listar(int id_usuario)
        {
            return objcd_permiso.listar(id_usuario);
        }
    }
}

