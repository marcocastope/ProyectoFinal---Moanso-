using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    interface LogTipoHabitacionI
    {
        List<entTipoHabitacion> listarTipoHabitacion();
        void insertarTipoHabitacion(entTipoHabitacion tipoHabitacion);
        void editarTipoHabitacion(entTipoHabitacion tipoHabitacion);
        void desabilitarTipoHabitacion(entTipoHabitacion tipoHabitacion);
    }
}
