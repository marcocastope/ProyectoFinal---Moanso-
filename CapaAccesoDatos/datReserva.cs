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
    public class datReserva : DatReservaI
    {
        SqlDataReader reader;

        private static readonly datReserva instance = new datReserva();

        public static datReserva Instance
        {
            get { return datReserva.instance; }
        }

        public List<entReserva> listarReservas()
        {
            SqlCommand command = null;
            var reservas = new List<entReserva>();

            try
            {
                var connection = Conexion.Instancia.Conectar();
                command = new SqlCommand("spListarReservas", connection);

                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var reserva = new entReserva();
                    reserva.idReserva = Convert.ToInt32(reader["ReservaID"]);
                    reserva.nombreCliente = reader["Nombre"].ToString();
                    reserva.numeroHabitacion = reader["Numero"].ToString();
                    reserva.checkIn = Convert.ToDateTime(reader["checkint"]);
                    reserva.checkOut = Convert.ToDateTime(reader["checkout"]);
                    reserva.estadoReserva = Convert.ToBoolean(reader["Estado"]);
                    reserva.idCliente = Convert.ToInt32(reader["ClienteID"]);
                    reserva.idHabitacion = Convert.ToInt32(reader["HabitacionID"]);
                    reservas.Add(reserva);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { command.Connection.Close(); }

            return reservas;
        }

        public void insertarReserva(entReserva reserva)
        {
            SqlCommand command = null;

            var connection = Conexion.Instancia.Conectar();
            command = new SqlCommand("spInsertarReserva", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@checkint", reserva.checkIn);
            command.Parameters.AddWithValue("@checkout", reserva.checkOut);
            command.Parameters.AddWithValue("@Estado", reserva.estadoReserva);
            command.Parameters.AddWithValue("@ClienteID", reserva.idCliente);
            command.Parameters.AddWithValue("@HabitacionID", reserva.idHabitacion);
            connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
        }

        public void anularReserva(entReserva reserva)
        {
            SqlCommand command = null;
            var connection = Conexion.Instancia.Conectar();
            command = new SqlCommand("spAnularReserva", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idReserva", reserva.idReserva);
            command.Parameters.AddWithValue("@estadoReserva", reserva.estadoReserva);
            connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
        }
    }
}
