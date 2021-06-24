using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class logHabitacion
    {
        private static readonly logHabitacion instance = new logHabitacion();

        public static logHabitacion Instance
        {
            get { return logHabitacion.instance; }
        }

        public List<entHabitacion> listarHabitacion()
        {
            return datHabitacion.Instance.listarHabitacion();
        }

        public void insertarHabitacion(entHabitacion habitacion)
        {
            datHabitacion.Instance.insertarHabitacion(habitacion);
        }
    }
}
