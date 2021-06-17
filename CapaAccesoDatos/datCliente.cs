using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
namespace CapaAccesoDatos
{
   public class datCliente
    {
        //patron de Diseño Singleton
        #region singleton
        private static readonly datCliente _instancia = new datCliente();
        public static datCliente Instancia
        {
            get { return datCliente._instancia; }
        }
        #endregion singleton


        #region metodos
        //Listado

        public List<entCliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Cli = new entCliente();
                    Cli.idCliente=Convert.ToInt32(dr["idCliente"]);
                    Cli.dniCliente=Convert.ToInt32(dr["dniCliente"]);
                    Cli.nombreCliente= dr["nombreCliente"].ToString();
                    Cli.apellidoCliente= dr["apellidoCliente"].ToString();
                    Cli.emailCliente= dr["emailCliente"].ToString();
                    Cli.telefonoCliente= dr["telefonoCliente"].ToString();
                    Cli.fecRegCliente= Convert.ToDateTime(dr["fecRegCliente"]);
                                 
                    lista.Add(Cli);
                }

            }

            catch (Exception e)
            {

                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }
        //Insertar
        public Boolean InsertarCliente(entCliente Cli)

        {

            SqlCommand cmd = null;

            Boolean inserta = false;

            try
            {

                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("spInsertaCliente", cn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dniCliente",Cli.dniCliente);
                cmd.Parameters.AddWithValue("@nombreCliente",Cli.nombreCliente);
                cmd.Parameters.AddWithValue("@apellidoCliente",Cli.apellidoCliente);
                cmd.Parameters.AddWithValue("@emailCliente",Cli.emailCliente);
                cmd.Parameters.AddWithValue("@telefonoCliente",Cli.telefonoCliente);
                cmd.Parameters.AddWithValue("@fecRegCliente",Cli.fecRegCliente);

                cn.Open();

                int i = cmd.ExecuteNonQuery();

                if (i > 0)

                {
                    inserta = true;
                }

            }
            catch (Exception e)
            {
                throw e;
            }

            finally { cmd.Connection.Close(); }

            return inserta;

        }
        //Editar
        public Boolean EditarCliente(entCliente Cli)

        {

            SqlCommand cmd = null;

            Boolean edita = false;

            try
            {

                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("spEditaCliente", cn);//Falta crear la base de datos 

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", Cli.idCliente);
                cmd.Parameters.AddWithValue("@dniCliente", Cli.dniCliente);
                cmd.Parameters.AddWithValue("@nombreCliente", Cli.nombreCliente);
                cmd.Parameters.AddWithValue("@apellidoCliente", Cli.apellidoCliente);
                cmd.Parameters.AddWithValue("@emailCliente", Cli.emailCliente);
                cmd.Parameters.AddWithValue("@telefonoCliente", Cli.telefonoCliente);
                cmd.Parameters.AddWithValue("@fecRegCliente", Cli.fecRegCliente);

                cn.Open();

                int i = cmd.ExecuteNonQuery();

                if (i > 0)

                {

                    edita = true;

                }

            }

            catch (Exception e)

            {

                throw e;

            }

            finally { cmd.Connection.Close(); }

            return edita;

        }
        //Inhabilitar

        #endregion metodos
    }
}
