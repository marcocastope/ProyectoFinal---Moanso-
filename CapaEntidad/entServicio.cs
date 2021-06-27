using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entServicio
    {
        public int NroServicio { get; set; }
        public int IdCliente { get; set; }
        public string Descripcion { get; set; }
        public double PrecioServicio { get; set; }
        public Boolean estAtencionServicio { get; set; }
        public DateTime fecRegServicio { get; set; }
    }
}
