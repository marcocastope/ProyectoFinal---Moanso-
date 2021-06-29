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
    public class datReclamo
    {
        private static readonly datCliente _instancia = new datCliente();
        public static datCliente Instancia
        {
            get { return datCliente._instancia; }
        }

        public List<entReclamo> ListarReclamo()
        {
            SqlCommand cmd = null;
            List<entReclamo> lista = new List<entReclamo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListadoReclamo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entReclamo re = new entReclamo();

                    re.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                    re.dni = Convert.ToInt32(dr["dni"]);
                    re.nombreCliente = dr["nombreCliente"].ToString();
                    re.IdTipoCliente = Convert.ToInt32(dr["IdTipoCliente"]);
                    re.detalleReclamo = dr["detalleReclamo"].ToString();
                    lista.Add(re);
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
        public Boolean InsertarReclamo(entReclamo re)

        {

            SqlCommand cmd = null;

            Boolean inserta = false;

            try
            {

                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("spInsertarReclamo", cn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", re.dni);
                cmd.Parameters.AddWithValue("@nombreCliente", re.nombreCliente);
                cmd.Parameters.AddWithValue("@detalleReclamo", re.fecRegCliente);

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
    }
}