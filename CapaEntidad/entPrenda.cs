using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPrenda
    {
        public int codigo { get; set; }
        public string tipoPrenda { get; set; }
        public string nroPrenda { get; set; }

        public string estadoPrenda { get; set; }
        public string colorPrenda { get; set; }
        public DateTime fecRegPrenda { get; set; }
        public bool estAtencion { get; set; }
        public int idCliente { get; set; }
    }
}
