using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class logReserva : LogReservaI
    {
        private static readonly logReserva instance = new logReserva();

        public static logReserva Instance
        {
            get { return logReserva.instance; }
        }
        public void anularReserva(entReserva reserva)
        {
            datReserva.Instance.anularReserva(reserva);
        }

        public void insertarReserva(entReserva reserva)
        {
            datReserva.Instance.insertarReserva(reserva);
        }

        public List<entReserva> listarReservas()
        {
            return datReserva.Instance.listarReservas();
        }
    }
}
