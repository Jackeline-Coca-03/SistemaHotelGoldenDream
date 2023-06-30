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


        public int Registrar( Usuario obj, out string Mensaje)
        {
            int idusuariogenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {


                    SqlCommand cmd = new SqlCommand("SP_REGISTRAUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("ci", obj.ci);
                    cmd.Parameters.AddWithValue("nombreCompleto", obj.nombreCompleto);
                    cmd.Parameters.AddWithValue("pasword", obj.pasword);
                    cmd.Parameters.AddWithValue("cuenta", obj.cuenta);
                    cmd.Parameters.AddWithValue("id_rol", obj.oRol.id_rol);
                    cmd.Parameters.AddWithValue("estado", obj.estado);

                    cmd.Parameters.Add("idusuariogenerado",SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();
                    idusuariogenerado = Convert.ToInt32( cmd.Parameters["idusuariogenerado"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                idusuariogenerado = 0;
                Mensaje = ex.Message;
            }



            return idusuariogenerado;
        }

        public bool Editar(Usuario obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {


                    SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("id_usuario", obj.id_usuario);
                    cmd.Parameters.AddWithValue("ci", obj.ci);
                    cmd.Parameters.AddWithValue("nombreCompleto", obj.nombreCompleto);
                    cmd.Parameters.AddWithValue("pasword", obj.pasword);
                    cmd.Parameters.AddWithValue("cuenta", obj.cuenta);
                    cmd.Parameters.AddWithValue("id_rol", obj.oRol.id_rol);
                    cmd.Parameters.AddWithValue("estado", obj.estado);

                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }



            return respuesta;
        }

        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {


                    SqlCommand cmd = new SqlCommand("SP_ELIMINARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("id_usuario", obj.id_usuario);

                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }



            return respuesta;
        }
    }
}