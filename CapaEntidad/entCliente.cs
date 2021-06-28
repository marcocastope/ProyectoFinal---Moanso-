using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCliente
    {
        public int IdCliente { get; set; }
        public int dni { get; set; }
        public string nombreCliente { get; set; }
        public string profesion { get; set; }
        public string pais { get; set; }
        public string ciudad { get; set; }
        public string tipoCliente { get; set; }
        public Boolean estAtencionCliente { get; set; }
        public DateTime fecRegCliente { get; set; }
    }
}
