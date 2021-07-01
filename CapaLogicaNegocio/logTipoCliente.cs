using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogicaNegocio
{
    public class logTipoCliente
    {
        //patron de Diseño Singleton
        #region singleton
        private static readonly logTipoCliente _instancia = new logTipoCliente();
        public static logTipoCliente Instancia
        {
            get { return logTipoCliente._instancia; }
        }
        #endregion singleton


        public List<entTipoCliente> ListarTipoCliente()
        {
            return datTipoCliente.Instancia.ListarTipoCliente();// ayudaaaaaaaaaaaa
        }
        public void insertaTipoCliente(entTipoCliente Tipo)

        {
            datTipoCliente.Instancia.InsertarTipoCliente(Tipo);
        }
        public void editaTipoCliente(entTipoCliente Tipo)

        {
            datTipoCliente.Instancia.EditarTipoCliente(Tipo);
        }
        public void deshabilitaTipoCliente(entTipoCliente Tipo)
        {
            datTipoCliente.Instancia.DeshabilitarTipoCliente(Tipo);
        }
    }
}
