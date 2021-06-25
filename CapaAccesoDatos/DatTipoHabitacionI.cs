using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    interface DatTipoHabitacionI
    {
        List<entTipoHabitacion> listarTipoHabitacion();
        void insertarTipoHabitacion(entTipoHabitacion tipoHabitacion);
        void editarTipoHabitacion(entTipoHabitacion tipoHabitacion);
        void desabilitarTipoHabitacion(entTipoHabitacion tipoHabitacion);
    }
}
