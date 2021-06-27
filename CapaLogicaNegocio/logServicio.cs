using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
   public class logServicio
    {
        //patron de Diseño Singleton
        #region singleton
        private static readonly logServicio _instancia = new logServicio();
        public static logServicio Instancia
        {
            get { return logServicio._instancia; }
        }
        #endregion singleton


        public List<entServicio> ListarServicio()
        {
            return datServicio.Instancia.ListarServicio();// ayudaaaaaaaaaaaa
        }
        public void insertaServicio(entServicio Serv)

        {
            datServicio.Instancia.InsertarServicio(Serv);
        }
        public void editaServicio(entServicio Serv)

        {
            datServicio.Instancia.EditarServicio(Serv);
        }
    }
}
