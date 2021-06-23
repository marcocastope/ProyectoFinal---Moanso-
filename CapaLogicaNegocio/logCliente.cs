using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class logCliente
    {
        //patron de Diseño Singleton
        #region singleton
        private static readonly logCliente _instancia = new logCliente();
        public static logCliente Instancia
        {
            get { return logCliente._instancia; }
        }
        #endregion singleton


        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();// ayudaaaaaaaaaaaa
        }
        public void insertaCliente(entCliente Cli)

        {
            datCliente.Instancia.InsertarCliente(Cli);
        }
        public void editaCliente(entCliente Cli)

        {
            datCliente.Instancia.EditarCliente(Cli);
        }
    }
}
