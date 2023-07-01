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
    public class CD_Habitacion
    {
        public List<Habitacion> listar()
        {
            List<Habitacion> lista = new List<Habitacion>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select id_hab, codigohab,numerohab,cantCamas,num_personas,estado,precio from Habitacion");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Habitacion()
                            {
                                id_hab = Convert.ToInt32(dr["id_hab"]),
                                codigohab = Convert.ToInt32(dr["codigohab"]),
                                descripcion = dr["numerohab"].ToString(),
                                cantCamas = Convert.ToInt32(dr["cantCamas"]),
                                num_personas = Convert.ToInt32(dr["num_personas"]),
                                estado = Convert.ToBoolean(dr["estado"]),
                                precio = Convert.ToDecimal(dr["precio"])

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Habitacion>();
                }
            }
            return lista;
        }

        public int Registrar(Habitacion obj, out string Mensaje)
        {
            int id_habitacionResultado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {


                    SqlCommand cmd = new SqlCommand("SP_REGISTRARHABITACION", oconexion);
                    cmd.Parameters.AddWithValue("codigohab", obj.codigohab);
                    cmd.Parameters.AddWithValue("numerohab", obj.descripcion);
                    cmd.Parameters.AddWithValue("cantCamas", obj.cantCamas);
                    cmd.Parameters.AddWithValue("num_personas", obj.num_personas);
                    cmd.Parameters.AddWithValue("precio", obj.precio);
                    cmd.Parameters.AddWithValue("estado", obj.estado);

                    cmd.Parameters.Add("id_habitacionResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();
                    id_habitacionResultado = Convert.ToInt32(cmd.Parameters["id_habitacionResultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                id_habitacionResultado = 0;
                Mensaje = ex.Message;
            }



            return id_habitacionResultado;
        }

        public bool Editar(Habitacion obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {


                    SqlCommand cmd = new SqlCommand("SP_EDITARHABITACION", oconexion);
                    cmd.Parameters.AddWithValue("id_hab", obj.id_hab);
                    cmd.Parameters.AddWithValue("codigohab", obj.codigohab);
                    cmd.Parameters.AddWithValue("numhab", obj.descripcion);
                    cmd.Parameters.AddWithValue("cantCamas", obj.cantCamas);
                    cmd.Parameters.AddWithValue("num_personas", obj.num_personas);
                    cmd.Parameters.AddWithValue("precio", obj.precio);
                    cmd.Parameters.AddWithValue("estado", obj.estado);

                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

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
       
        public bool Eliminar(Habitacion obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {


                    SqlCommand cmd = new SqlCommand("SP_ELIMINARHABITACION", oconexion);
                    cmd.Parameters.AddWithValue("id_hab", obj.id_hab);

                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

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
