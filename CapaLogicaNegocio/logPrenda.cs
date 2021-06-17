using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;


namespace CapaLogicaNegocio
{
    public class logPrenda
    {
        //patron de Diseño Singleton
        #region singleton
        private static readonly logPrenda _instancia = new logPrenda();
        public static logPrenda Instancia
        {
            get { return logPrenda._instancia; }
        }
        #endregion singleton


        public List<entPrenda> ListarPrenda()
        {
            return datPrenda.Instancia.ListarPrenda();
        }
        public void insertaPrenda(entPrenda Pren)

        {
            datPrenda.Instancia.InsertarPrenda(Pren);
        }
        public void editaPrenda(entPrenda Pren)

        {
            datPrenda.Instancia.EditarPrenda(Pren);
        }
    }
}

