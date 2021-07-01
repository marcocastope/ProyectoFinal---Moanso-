﻿using System;
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
                cmd = new SqlCommand("spListarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Cli = new entCliente();

                    Cli.IdCliente= Convert.ToInt32(dr["IdCliente"]);
                    Cli.dni= Convert.ToInt32(dr["dni"]);
                    Cli.nombreCliente= dr["nombreCliente"].ToString();
                    Cli.profesion= dr["profesion"].ToString();
                    Cli.tipoCliente = dr["tipoCliente"].ToString();
                    Cli.ciudad=dr["ciudad"].ToString();
                    Cli.estAtencionCliente=Convert.ToBoolean(dr["estAtencionCliente"]);
                    Cli.fecRegCliente= Convert.ToDateTime(dr["fecRegCliente"]);
                    Cli.IdTipoCliente= Convert.ToInt32(dr["IdTipoCliente"]);
                    Cli.IdCiudad = Convert.ToInt32(dr["IdCiudad"]);
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

                cmd = new SqlCommand("spInsertarCliente", cn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", Cli.dni);
                cmd.Parameters.AddWithValue("@nombreCliente", Cli.nombreCliente);
                cmd.Parameters.AddWithValue("@profesion", Cli.profesion);
                cmd.Parameters.AddWithValue("@IdTipoCliente", Cli.IdTipoCliente);
                cmd.Parameters.AddWithValue("@IdCiudad", Cli.IdCiudad);
                cmd.Parameters.AddWithValue("@estAtencionCliente", Cli.estAtencionCliente);
                cmd.Parameters.AddWithValue("@fecRegCliente", Cli.fecRegCliente);

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

                cmd = new SqlCommand("spEditarCliente", cn);//Falta crear la base de datos 

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdCliente", Cli.IdCliente);
                cmd.Parameters.AddWithValue("@dni", Cli.dni);
                cmd.Parameters.AddWithValue("@nombreCliente", Cli.nombreCliente);
                cmd.Parameters.AddWithValue("@profesion", Cli.profesion);
                cmd.Parameters.AddWithValue("@IdTipoCliente", Cli.IdTipoCliente);
                cmd.Parameters.AddWithValue("@IdCiudad", Cli.IdCiudad);
                cmd.Parameters.AddWithValue("@estAtencionCliente", Cli.estAtencionCliente);
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
        //Inhabilitar o deshabilitar
        public Boolean DeshabilitarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;

            Boolean deshabilita = false;
            try
            {

                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdCliente", Cli.IdCliente);
                cmd.Parameters.AddWithValue("@estAtencionCliente", Cli.estAtencionCliente);
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
