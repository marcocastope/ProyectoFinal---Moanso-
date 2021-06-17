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
    public class datPrenda
    {
        //patron de Diseño Singleton
        #region singleton
        private static readonly datPrenda _instancia = new datPrenda();
        public static datPrenda Instancia
        {
            get { return datPrenda._instancia; }
        }
        #endregion singleton


        #region metodos
        //Listado

        public List<entPrenda> ListarPrenda()
        {
            SqlCommand cmd = null;
            List<entPrenda> lista = new List<entPrenda>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaPrenda", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPrenda Pren = new entPrenda();
                    Pren.idCliente = Convert.ToInt32(dr["idCliente"]);
                    Pren.tipoPrenda = dr["tipoPrenda"].ToString();
                    Pren.nroPrenda = dr["nroPrenda"].ToString();
                    Pren.estadoPrenda = dr["estadoPrenda"].ToString();
                    Pren.colorPrenda = dr["colorPrenda"].ToString();
                    Pren.fecRegPrenda = Convert.ToDateTime(dr["fecRegPrenda"]);
                    Pren.estAtencion = Convert.ToBoolean(dr["estAtencion"]);
                    lista.Add(Pren);
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
        public Boolean InsertarPrenda(entPrenda Pren)

        {

            SqlCommand cmd = null;

            Boolean inserta = false;

            try
            {

                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("spInsertaPrenda", cn);

                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@tipoPrenda", Pren.tipoPrenda);
                cmd.Parameters.AddWithValue("@nroPrenda", Pren.nroPrenda);
                cmd.Parameters.AddWithValue("@estadoPrenda", Pren.estadoPrenda);
                cmd.Parameters.AddWithValue("@colorPrenda", Pren.colorPrenda);
                cmd.Parameters.AddWithValue("@fecRegPrenda", Pren.fecRegPrenda);
                cmd.Parameters.AddWithValue("@estAtencion", Pren.estAtencion);
                
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
        public Boolean EditarPrenda(entPrenda Pren)

        {

            SqlCommand cmd = null;

            Boolean edita = false;

            try
            {

                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("spEditarPrenda", cn);//Falta crear la base de datos 

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idCliente", Pren.idCliente);
                cmd.Parameters.AddWithValue("@tipoPrenda", Pren.tipoPrenda);
                cmd.Parameters.AddWithValue("@nroPrenda", Pren.nroPrenda);
                cmd.Parameters.AddWithValue("@estadoPrenda", Pren.estadoPrenda);
                cmd.Parameters.AddWithValue("@colorPrenda", Pren.colorPrenda);
                cmd.Parameters.AddWithValue("@fecRegPrenda", Pren.fecRegPrenda);
                cmd.Parameters.AddWithValue("@estAtencion", Pren.estAtencion);

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
