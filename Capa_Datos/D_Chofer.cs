using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidad;

namespace Capa_Datos
{
    public class D_Chofer
    {
        private readonly string connectionString;

        public D_Chofer()
        {
            connectionString = ConfigurationManager.ConnectionStrings["BusControlDB"].ConnectionString;
        }

        public bool InsertarChofer(E_Chofer chofer)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("RegistrarChofer", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", chofer.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", chofer.Apellido);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", chofer.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@Cedula", chofer.Cedula);

                    conexion.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public List<E_Chofer> ObtenerChoferes()
        {
            List<E_Chofer> lista = new List<E_Chofer>();

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("ObtenerChoferes", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            E_Chofer chofer = new E_Chofer
                            {
                                ChoferID = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Apellido = reader.GetString(2),
                                FechaNacimiento = reader.GetDateTime(3),
                                Cedula = reader.GetString(4)
                            };
                            lista.Add(chofer);
                        }
                    }
                }
            }
            return lista;
        }
    }
}