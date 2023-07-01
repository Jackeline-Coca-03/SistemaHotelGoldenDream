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
    public class CD_Cliente
    {
        public List<Cliente> listar()
        {
            List<Cliente> lista = new List<Cliente>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select id_cliente,ci,nombreCompleto,celular,estado from Cliente");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Cliente()
                            {
                                id_cliente = Convert.ToInt32(dr["id_Cliente"]),
                                ci = Convert.ToInt32(dr["ci"]),
                                nombreCompleto = dr["nombreCompleto"].ToString(),
                                celular = Convert.ToInt32(dr["celular"]),
                                estado = Convert.ToBoolean(dr["estado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Cliente>();
                }
            }
            return lista;
        }
       

        public int Registrar(Cliente obj, out string Mensaje)
        {
            int id_clienteResultado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {


                    SqlCommand cmd = new SqlCommand("SP_REGISTRARCLIENTE", oconexion);
                    cmd.Parameters.AddWithValue("ci", obj.ci);
                    cmd.Parameters.AddWithValue("nombreCompleto", obj.nombreCompleto);
                    cmd.Parameters.AddWithValue("celular", obj.celular);
                    cmd.Parameters.AddWithValue("estado", obj.estado);

                    cmd.Parameters.Add("id_clienteResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();
                    id_clienteResultado = Convert.ToInt32(cmd.Parameters["id_clienteResultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                id_clienteResultado = 0;
                Mensaje = ex.Message;
            }



            return id_clienteResultado;
        }

        public bool Editar(Cliente obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {


                    SqlCommand cmd = new SqlCommand("SP_EDITARCLIENTE", oconexion);
                    cmd.Parameters.AddWithValue("id_cliente", obj.id_cliente);
                    cmd.Parameters.AddWithValue("ci", obj.ci);
                    cmd.Parameters.AddWithValue("nombreCompleto", obj.nombreCompleto);
                    cmd.Parameters.AddWithValue("celular", obj.celular);
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

        public bool Eliminar(Cliente obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("delete from Cliente where id_cliente = @id_cliente", oconexion);
                    cmd.Parameters.AddWithValue("id_Cliente", obj.id_cliente);
                    cmd.CommandType=CommandType.Text;
                    oconexion.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
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
