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
    public class datTipoCliente
    {
        //patron de Diseño Singleton
        #region singleton
        private static readonly datTipoCliente _instancia = new datTipoCliente();
        public static datTipoCliente Instancia
        {
            get { return datTipoCliente._instancia; }
        }
        #endregion singleton


        #region metodos
        //Listado

        public List<entTipoCliente> ListarTipoCliente()
        {
            SqlCommand cmd = null;
            List<entTipoCliente> lista = new List<entTipoCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarTiposCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoCliente Tipo = new entTipoCliente();
                    Tipo.IdTipoCliente= Convert.ToInt32(dr["TipoclienteID"]);
                    Tipo.TipoCliente = dr["Tipo"].ToString();
                    Tipo.DescripcionTipoCliente = dr["Descripcion"].ToString();
                    Tipo.EstadoTipoCliente =Convert.ToBoolean(dr["Estado"]);
                    Tipo.Createdat =Convert.ToDateTime(dr["Createdat"]);
                    Tipo.Updatedat =Convert.ToDateTime(dr["Updatedat"]);
                    lista.Add(Tipo);
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
        public Boolean InsertarTipoCliente(entTipoCliente Tipo)

        {

            SqlCommand cmd = null;

            Boolean inserta = false;

            try
            {

                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("spInsertarTipoCliente", cn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Tipo", Tipo.TipoCliente);
                cmd.Parameters.AddWithValue("@Descripcion", Tipo.DescripcionTipoCliente);
                cmd.Parameters.AddWithValue("@Estado", Tipo.EstadoTipoCliente);
                          
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
        public Boolean EditarTipoCliente(entTipoCliente Tipo)

        {

            SqlCommand cmd = null;

            Boolean edita = false;

            try
            {

                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("spEditarTipoCliente", cn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TipoclienteID", Tipo.IdTipoCliente);
                cmd.Parameters.AddWithValue("@Tipo", Tipo.TipoCliente);
                cmd.Parameters.AddWithValue("@Descripcion", Tipo.DescripcionTipoCliente);
                cmd.Parameters.AddWithValue("@Estado", Tipo.EstadoTipoCliente);

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
        public Boolean DeshabilitarTipoCliente(entTipoCliente Tipo)
        {
            SqlCommand cmd = null;

            Boolean deshabilita = false;
            try
            {

                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarTipoCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdTipoCliente", Tipo.IdTipoCliente);
                cmd.Parameters.AddWithValue("@EstadoTipoCliente", Tipo.EstadoTipoCliente);
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
