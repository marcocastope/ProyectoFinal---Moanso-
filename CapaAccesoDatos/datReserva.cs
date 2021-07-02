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
                    reserva.idReserva = Convert.ToInt32(reader["idReserva"]);
                    reserva.nombreCliente = reader["nombreCliente"].ToString();
                    reserva.numeroHabitacion = reader["numHabitacion"].ToString();
                    reserva.checkIn = Convert.ToDateTime(reader["checkIn"]);
                    reserva.checkOut = Convert.ToDateTime(reader["checkOut"]);
                    reserva.estadoReserva = Convert.ToBoolean(reader["estadoReserva"]);
                    reserva.idCliente = Convert.ToInt32(reader["idCliente"]);
                    reserva.idHabitacion = Convert.ToInt32(reader["idHabitacion"]);
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
            command.Parameters.AddWithValue("@nombreCliente", reserva.nombreCliente);
            command.Parameters.AddWithValue("@numeroHabitacion", reserva.numeroHabitacion);
            command.Parameters.AddWithValue("@checkIn", reserva.checkIn);
            command.Parameters.AddWithValue("@checkOut", reserva.checkOut);
            command.Parameters.AddWithValue("@estadoReserva", reserva.estadoReserva);
            command.Parameters.AddWithValue("@idCliente", reserva.idCliente);
            command.Parameters.AddWithValue("@idHabitacion", reserva.idHabitacion);
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
