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
    public class datTipoHabitacion
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
                command = new SqlCommand("spListarTipoHabitacion", connection);

                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                reader = command.ExecuteReader();

                while(reader.Read())
                {
                    var tipoHabitacion = new entTipoHabitacion();
                    tipoHabitacion.ID = Convert.ToInt32(reader["idTipoHab"]);
                    tipoHabitacion.Tipo = reader["tipo"].ToString();
                    tipoHabitacion.Descripcion = reader["descripcion"].ToString();
                    tipoHabitacion.Estado = Convert.ToBoolean(reader["estTipoHab"]);
                    tipos.Add(tipoHabitacion);
                }
            } catch (Exception e)
            {
                throw e;
            } finally { command.Connection.Close(); }

            return tipos;
        }

        public Boolean insertarTipoHabitacion(entTipoHabitacion tipoHabitacion)
        {
            SqlCommand command = null;
            bool seInserto = false;

            try
            {
                var connection = Conexion.Instancia.Conectar();
                command = new SqlCommand("spInsertarTipoHabitacion", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@tipo", tipoHabitacion.Tipo);
                command.Parameters.AddWithValue("@descripcion", tipoHabitacion.Descripcion);
                command.Parameters.AddWithValue("@estTipoHab", tipoHabitacion.Estado);
                connection.Open();

                var i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    seInserto = true;
                }
            } catch(Exception e)
            {
                throw e;
            } finally { command.Connection.Close(); }

            return seInserto;
        }
    }
}
