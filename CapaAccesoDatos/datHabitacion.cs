using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class datHabitacion : DatHabitacionI
    {
        SqlDataReader reader;

        private static readonly datHabitacion instance = new datHabitacion();

        public static datHabitacion Instance
        {
            get { return datHabitacion.instance; }
        }

        public List<entHabitacion> listarHabitaciones()
        {
            SqlCommand command = null;
            var habitaciones = new List<entHabitacion>();

            try
            {
                var connection = Conexion.Instancia.Conectar();
                command = new SqlCommand("spListarHabitacion", connection);

                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var habitacion = new entHabitacion();
                    habitacion.idHabitacion = Convert.ToInt32(reader["idHabitacion"]);
                    habitacion.numeroHabitacion = reader["numHabitacion"].ToString();
                    habitacion.tipoHabitacion = reader["tipo"].ToString();
                    habitacion.cantidadCamas = Convert.ToInt32(reader["cantCamas"].ToString());
                    habitacion.pisoHabitacion = reader["ubiPiso"].ToString();
                    habitacion.precio = Convert.ToDouble(reader["precio"]);
                    habitacion.estadoHabitacion = Convert.ToBoolean(reader["estHabitacion"]);
                    habitacion.idTipoHabitacion = Convert.ToInt32(reader["idTipoHab"]);
                    habitaciones.Add(habitacion);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { command.Connection.Close(); }

            return habitaciones;
        }

        public void insertarHabitacion(entHabitacion habitacion)
        {
            SqlCommand command = null;
            var connection = Conexion.Instancia.Conectar();
            command = new SqlCommand("spInsertarHabitacion", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@numHabitacion", habitacion.numeroHabitacion);
            command.Parameters.AddWithValue("@cantCamas", habitacion.cantidadCamas);
            command.Parameters.AddWithValue("@ubiPiso", habitacion.pisoHabitacion);
            command.Parameters.AddWithValue("@precio", habitacion.precio);
            command.Parameters.AddWithValue("@idTipoHab", habitacion.idTipoHabitacion);
            command.Parameters.AddWithValue("@estHabitacion", habitacion.estadoHabitacion);
            connection.Open();

            command.ExecuteNonQuery();
            command.Connection.Close(); 

          
        }

        public void editarHabitacion(entHabitacion habitacion)
        {
            SqlCommand command = null;
            var connection = Conexion.Instancia.Conectar();
            command = new SqlCommand("spEditarHabitacion", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idHabitacion", habitacion.idHabitacion);
            command.Parameters.AddWithValue("@numHabitacion", habitacion.numeroHabitacion);
            command.Parameters.AddWithValue("@cantCamas", habitacion.cantidadCamas);
            command.Parameters.AddWithValue("@ubiPiso", habitacion.pisoHabitacion);
            command.Parameters.AddWithValue("@precio", habitacion.precio);
            command.Parameters.AddWithValue("@idTipoHab", habitacion.idTipoHabitacion);
            command.Parameters.AddWithValue("@estHabitacion", habitacion.estadoHabitacion);
            connection.Open();

            command.ExecuteNonQuery();
            command.Connection.Close();
        }

        public void desabilitarHabitacion(entHabitacion habitacion)
        {
            SqlCommand command = null;
            var connection = Conexion.Instancia.Conectar();
            command = new SqlCommand("spDeshabilitarHabitacion", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idHabitacion", habitacion.idHabitacion);
            command.Parameters.AddWithValue("@estHabitacion", habitacion.estadoHabitacion);
            connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
        }
    }
}
