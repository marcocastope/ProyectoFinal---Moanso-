using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;

namespace CapaAccesoDatos
{
   public class datCiudad
    {
        //patron de Diseño Singleton
        #region singleton
        private static readonly datCiudad _instancia = new datCiudad();
        public static datCiudad Instancia
        {
            get { return datCiudad._instancia; }
        }
        #endregion singleton


        #region metodos
        //Listado

        public List<entCiudad> ListarCiudad()
        {
            SqlCommand cmd = null;
            List<entCiudad> lista = new List<entCiudad>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarCiudad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCiudad Ciu = new entCiudad();
                    Ciu.IdCiudad= Convert.ToInt32(dr["IdCiudad"]);
                    Ciu.Ciudad = dr["Ciudad"].ToString();
                    Ciu.EstadoCiudad= Convert.ToBoolean(dr["EstadoCiudad"]);

                    lista.Add(Ciu);
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
        public Boolean InsertarCiudad(entCiudad Ciu)

        {

            SqlCommand cmd = null;

            Boolean inserta = false;

            try
            {

                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("spInsertarCiudad", cn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Ciudad", Ciu.Ciudad);
                cmd.Parameters.AddWithValue("@EstadoCiudad", Ciu.EstadoCiudad);

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
        public Boolean EditarCiudad(entCiudad Ciu)

        {

            SqlCommand cmd = null;

            Boolean edita = false;

            try
            {

                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("spEditarCiudad", cn);//Falta crear la base de datos 

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdCiudad", Ciu.IdCiudad);
                cmd.Parameters.AddWithValue("@Ciudad", Ciu.Ciudad);
                cmd.Parameters.AddWithValue("@EstadoCiudad", Ciu.EstadoCiudad);

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
        public Boolean DeshabilitarCiudad(entCiudad Ciu)
        {
            SqlCommand cmd = null;

            Boolean deshabilita = false;
            try
            {

                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarCiudad", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdCiudad", Ciu.IdCiudad);
                cmd.Parameters.AddWithValue("@EstadoCiudad", Ciu.EstadoCiudad);
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
        #endregion metodos
    }
}
