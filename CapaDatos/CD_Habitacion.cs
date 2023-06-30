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
    }
}
