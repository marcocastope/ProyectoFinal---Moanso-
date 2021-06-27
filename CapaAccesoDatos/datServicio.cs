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
   public class datServicio
    {
        //patron de Diseño Singleton
        #region singleton
        private static readonly datServicio _instancia = new datServicio();
        public static datServicio Instancia
        {
            get { return datServicio._instancia; }
        }
        #endregion singleton


        #region metodos
        //Listado

        public List<entServicio> ListarServicio()
        {
            SqlCommand cmd = null;
            List<entServicio> lista = new List<entServicio>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarServicio", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entServicio Serv = new entServicio();
                    Serv.NroServicio = Convert.ToInt32(dr["NroServicio"]);
                    Serv.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                    Serv.Descripcion = dr["Descripcion"].ToString();
                    Serv.PrecioServicio = Convert.ToDecimal(dr["PrecioServicio"]);
                    Serv.estAtencionServicio = Convert.ToBoolean(dr["estAtencionServicio"]);
                    Serv.fecRegServicio = Convert.ToDateTime(dr["fecRegServicio"]);
                    lista.Add(Serv);
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
        public Boolean InsertarServicio(entServicio Serv)

        {

            SqlCommand cmd = null;

            Boolean inserta = false;

            try
            {

                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("spInsertarServicio", cn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdCliente", Serv.IdCliente);
                cmd.Parameters.AddWithValue("@Descripcion", Serv.Descripcion);
                cmd.Parameters.AddWithValue("@PrecioServicio", Serv.PrecioServicio);
                cmd.Parameters.AddWithValue("@estAtencionServicio", Serv.estAtencionServicio);
                cmd.Parameters.AddWithValue("@fecRegServicio", Serv.fecRegServicio);

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
        public Boolean EditarServicio(entServicio Serv)

        {

            SqlCommand cmd = null;

            Boolean edita = false;

            try
            {

                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("spEditarServicio", cn);//Falta crear la base de datos 

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NroServicio", Serv.NroServicio);
                cmd.Parameters.AddWithValue("@IdCliente", Serv.IdCliente);
                cmd.Parameters.AddWithValue("@Descripcion", Serv.Descripcion);
                cmd.Parameters.AddWithValue("@PrecioServicio", Serv.PrecioServicio);
                cmd.Parameters.AddWithValue("@estAtencionServicio", Serv.estAtencionServicio);
                cmd.Parameters.AddWithValue("@fecRegServicio", Serv.fecRegServicio);

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
        //Inhabilitar o deshabilitar
        public Boolean DeshabilitarServicio(entServicio Serv)
        {
            SqlCommand cmd = null;

            Boolean deshabilita = false;
            try {

                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarServicio", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NroServicio", Serv.NroServicio);
                cmd.Parameters.AddWithValue("@estAtencionServicio", Serv.estAtencionServicio);
                cn.Open();

                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    deshabilita = true;
                }

            }

            catch (Exception e)

            {
                throw e;
            }

            finally { cmd.Connection.Close(); }

            return deshabilita;
        }
    }

        #endregion metodos
 }
