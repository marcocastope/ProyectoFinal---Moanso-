using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class logHabitacion : LogHabitacionI
    {
        private static readonly logHabitacion instance = new logHabitacion();

        public static logHabitacion Instance
        {
            get { return logHabitacion.instance; }
        }

        public List<entHabitacion> listarHabitaciones()
        {
            return datHabitacion.Instance.listarHabitaciones();
        }

        public void insertarHabitacion(entHabitacion habitacion)
        {
            datHabitacion.Instance.insertarHabitacion(habitacion);
        }

        public void editarHabitacion(entHabitacion habitacion)
        {
            datHabitacion.Instance.editarHabitacion(habitacion);
        }

        public void desabilitarHabitacion(entHabitacion habitacion)
        {
            datHabitacion.Instance.desabilitarHabitacion(habitacion);
        }
    }
}
