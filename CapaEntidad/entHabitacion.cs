using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entHabitacion
    {
        public int idHabitacion { get; set; }
        public string numeroHabitacion { get; set; }
        public string tipoHabitacion { get; set; }
        public int cantidadCamas { get; set; }
        public string pisoHabitacion { get; set; }
        public double precio { get; set; }
        public Boolean estadoHabitacion { get; set; }
        public int idTipoHabitacion { get; set; }
    }
}
