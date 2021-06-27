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
        public decimal PrecioServicio { get; set; }
        public bool estAtencionServicio { get; set; }
        public DateTime fecRegServicio { get; set; }
    }
}
