using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class logReclamo
    {
        //patron de Diseño Singleton
        #region singleton
        private static readonly logReclamo _instancia = new logReclamo();
        public static logReclamo Instancia
        {
            get { return logReclamo._instancia; }
        }
        #endregion singleton

        public List<entReclamo> ListarReclamo()
        {
            return datReclamo.Instancia.ListarReclamo();// ayudaaaaaaaaaaaa
        }
        public void insertaReclamo(entReclamo re
        {
            datReclamo.Instancia.InsertarReclamo(re);
        }