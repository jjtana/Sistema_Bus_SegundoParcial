using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Configuration;

namespace Capa_Datos
{
    public class D_Bus
    {
        private readonly string connectionString;

        public D_Bus()
        {
            connectionString = ConfigurationManager.ConnectionStrings["BusControlDB"].ConnectionString;
        }

        // Método para insertar un autobús
        public bool InsertarBus(E_Bus bus)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarBus", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@Marca", bus.Marca);
                cmd.Parameters.AddWithValue("@Modelo", bus.Modelo);
                cmd.Parameters.AddWithValue("@Placa", bus.Placa);
                cmd.Parameters.AddWithValue("@Color", bus.Color);
                cmd.Parameters.AddWithValue("@Anio", bus.Anio);

                connection.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Método para obtener la lista de autobuses
        public List<E_Bus> ObtenerListaBuses()
        {
            List<E_Bus> lista = new List<E_Bus>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerBuses", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new E_Bus
                        {
                            AutobusID = Convert.ToInt32(reader["AutobusID"]),
                            Marca = reader["Marca"].ToString(),
                            Modelo = reader["Modelo"].ToString(),
                            Placa = reader["Placa"].ToString(),
                            Color = reader["Color"].ToString(),
                            Anio = Convert.ToInt32(reader["Anio"])
                        });
                    }
                }
            }
            return lista;
        }

        // Método para actualizar un autobús
        public bool ActualizarBus(E_Bus bus)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarBus", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@AutobusID", bus.AutobusID);
                cmd.Parameters.AddWithValue("@Marca", bus.Marca);
                cmd.Parameters.AddWithValue("@Modelo", bus.Modelo);
                cmd.Parameters.AddWithValue("@Placa", bus.Placa);
                cmd.Parameters.AddWithValue("@Color", bus.Color);
                cmd.Parameters.AddWithValue("@Anio", bus.Anio);

                connection.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Método para eliminar un autobús
        public bool EliminarBus(int autobusID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarBus", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@AutobusID", autobusID);

                connection.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}