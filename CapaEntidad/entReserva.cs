using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entReserva
    {
        public int idReserva { get; set; }
        public string nombreCliente { get; set; }
        public string numeroHabitacion { get; set; }
        public DateTime checkIn { get; set; }
        public DateTime checkOut { get; set; }
        public bool estadoReserva { get; set; }
        public int idCliente { get; set; }
        public int idHabitacion { get; set; }
    }
}
