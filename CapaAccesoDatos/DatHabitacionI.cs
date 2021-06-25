using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    interface DatHabitacionI
    {
        List<entHabitacion> listarHabitaciones();
        void insertarHabitacion(entHabitacion habitacion);
        void editarHabitacion(entHabitacion habitacion);
        void desabilitarHabitacion(entHabitacion habitacion);
    }
}
