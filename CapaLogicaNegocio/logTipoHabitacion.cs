using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class logTipoHabitacion : LogTipoHabitacionI
    {
        private static readonly logTipoHabitacion instance = new logTipoHabitacion();

        public static logTipoHabitacion Instance
        {
            get { return logTipoHabitacion.instance; }
        }

        public void desabilitarTipoHabitacion(entTipoHabitacion tipoHabitacion)
        {
            datTipoHabitacion.Instance.desabilitarTipoHabitacion(tipoHabitacion);
        }

        public void editarTipoHabitacion(entTipoHabitacion tipoHabitacion)
        {
             datTipoHabitacion.Instance.editarTipoHabitacion(tipoHabitacion);
        }

        public void insertarTipoHabitacion(entTipoHabitacion tipoHabitacion)
        {
             datTipoHabitacion.Instance.insertarTipoHabitacion(tipoHabitacion);
        }

        public List<entTipoHabitacion> listarTipoHabitacion()
        {
            return datTipoHabitacion.Instance.listarTipoHabitacion();
        }
    }
}
