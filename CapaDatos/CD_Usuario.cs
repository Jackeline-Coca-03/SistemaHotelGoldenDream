using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuario> listar()
        {
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select u.id_usuario,u.ci,u.nombreCompleto,u.pasword,u.cuenta,u.estado,r.id_rol,r.descripcion from Usuario u");
                    query.AppendLine("INNER JOIN Rol r on r.id_rol=u.id_rol");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                ci = Convert.ToInt32(dr["ci"]),
                                nombreCompleto = dr["nombreCompleto"].ToString(),
                                pasword = dr["pasword"].ToString(),
                                cuenta = dr["cuenta"].ToString(),
                                estado = Convert.ToBoolean(dr["estado"]),
                                oRol = new Rol() { id_rol = Convert.ToInt32(dr["id_rol"]), descripcion = dr["descripcion"].ToString() }
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                }
            }
            return lista;
        }
    }
}