using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> listar(int id_usuario)
        {
            List<Permiso> lista = new List<Permiso>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.id_rol, p.nombreMenu from Permiso p");
                    query.AppendLine("inner join Rol r on  r.id_rol = p.id_rol");
                    query.AppendLine("inner join Usuario u on  u.id_rol = r.id_rol");
                    query.AppendLine("where u.id_usuario = @id_usuario");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                oRol = new Rol() { id_rol = Convert.ToInt32(dr["id_rol"]) },
                                nombreMenu = dr["nombreMenu"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Permiso>();
                }
            }
            return lista;
        }
    }
}