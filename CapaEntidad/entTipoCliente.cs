using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entTipoCliente
    {
        public int IdTipoCliente { get; set; }
        public string TipoCliente { get; set; }
        public string DescripcionTipoCliente { get; set; }
        public Boolean EstadoTipoCliente { get; set; }
        public DateTime Createdat { get; set; }
        public DateTime Updatedat { get; set; }
    }
}
