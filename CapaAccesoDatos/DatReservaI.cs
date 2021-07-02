using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    interface DatReservaI
    {
        List<entReserva> listarReservas();
        void insertarReserva(entReserva reserva);
        void anularReserva(entReserva reserva);
    }
}
