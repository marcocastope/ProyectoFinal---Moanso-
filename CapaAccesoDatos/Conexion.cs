using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class Conexion
    {

        //patron de Diseño Singleton
        #region singleton
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get {
                return Conexion._instancia;
            }
        }
        #endregion singleton
        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();

            //cn.ConnectionString = "Data Source=DESKTOP-I8JI3BQ\\MSSQLSERVER01; Initial Catalog = DB ProyectoHotel; Integrated Security=true";
            cn.ConnectionString = @"Server=127.0.0.1,1433;Database=ProyectoHotel;User Id=SA;Password=Secret_123";

            return cn;
        }

    }
}
