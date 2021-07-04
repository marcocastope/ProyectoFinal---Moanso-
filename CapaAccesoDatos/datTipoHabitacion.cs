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
    public class datTipoHabitacion : DatTipoHabitacionI
    {
        SqlDataReader reader;

        private static readonly datTipoHabitacion instance = new datTipoHabitacion();

        public static datTipoHabitacion Instance
        {
            get { return datTipoHabitacion.instance; }
        }

        public List<entTipoHabitacion> listarTipoHabitacion()
        {
            SqlCommand command = null;
            var tipos = new List<entTipoHabitacion>();

            try
            {
                var connection = Conexion.Instancia.Conectar();
                command = new SqlCommand("spListarTiposHabitacion", connection);

                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                reader = command.ExecuteReader();

                while(reader.Read())
                {
                    var tipoHabitacion = new entTipoHabitacion();
                    tipoHabitacion.Id = Convert.ToInt32(reader["TipohabitacionID"]);
                    tipoHabitacion.Tipo = reader["Tipo"].ToString();
                    tipoHabitacion.Descripcion = reader["Descripcion"].ToString();
                    tipoHabitacion.Estado = Convert.ToBoolean(reader["Estado"]);
                    tipoHabitacion.Createdat = Convert.ToDateTime(reader["Createdat"]);
                    tipoHabitacion.Updateat = Convert.ToDateTime(reader["Updateat"]);
                    tipos.Add(tipoHabitacion);
                }
            } catch (Exception e)
            {
                throw e;
            } finally { command.Connection.Close(); }

            return tipos;
        }

        public void insertarTipoHabitacion(entTipoHabitacion tipoHabitacion)
        {
            SqlCommand command = null;
  
            var connection = Conexion.Instancia.Conectar();
            command = new SqlCommand("spInsertarTipoHabitacion", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Tipo", tipoHabitacion.Tipo);
            command.Parameters.AddWithValue("@Descripcion", tipoHabitacion.Descripcion);
            command.Parameters.AddWithValue("@EsTado", tipoHabitacion.Estado);
            connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close(); 
        }

        public void editarTipoHabitacion(entTipoHabitacion tipoHabitacion)
        {
            SqlCommand command = null;
            var connection = Conexion.Instancia.Conectar();
            command = new SqlCommand("spEditarTipoHabitacion", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Tipo", tipoHabitacion.Tipo);
            command.Parameters.AddWithValue("@Descripcion", tipoHabitacion.Descripcion);
            command.Parameters.AddWithValue("@Estado", tipoHabitacion.Estado);
            command.Parameters.AddWithValue("@TipohabitacionID", tipoHabitacion.Id);
            connection.Open();

            command.ExecuteNonQuery();
            command.Connection.Close();
        }

        public void desabilitarTipoHabitacion(entTipoHabitacion tipoHabitacion)
        {
            SqlCommand command = null;
            var connection = Conexion.Instancia.Conectar();
            command = new SqlCommand("spDeshabilitarTipoHabitacion", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idTipoHab", tipoHabitacion.Id);
            command.Parameters.AddWithValue("@estTipoHab", tipoHabitacion.Estado);
            connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close(); 
        }
    }
}
