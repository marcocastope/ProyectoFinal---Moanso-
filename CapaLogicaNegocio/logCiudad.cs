using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogicaNegocio
{
    public class logCiudad
    {
        //patron de Diseño Singleton
        #region singleton
        private static readonly logCiudad _instancia = new logCiudad();
        public static logCiudad Instancia
        {
            get { return logCiudad._instancia; }
        }
        #endregion singleton


        public List<entCiudad> ListarCiudad()
        {
            return datCiudad.Instancia.ListarCiudad();// ayudaaaaaaaaaaaa
        }
        public void insertaCiudad(entCiudad Ciu)

        {
            datCiudad.Instancia.InsertarCiudad(Ciu);
        }
        public void editaCiudad(entCiudad Ciu)

        {
            datCiudad.Instancia.EditarCiudad(Ciu);
        }
        public void deshabilitaCiudad(entCiudad Ciu)
        {
            datCiudad.Instancia.DeshabilitarCiudad(Ciu);
        }
    }
}
