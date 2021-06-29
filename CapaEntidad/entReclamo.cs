using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entReclamo
    {
        public int IdCliente { get; set; }
        public int dni { get; set; }
        public string nombreCliente { get; set; }
        public int IdTipoCliente { get; set; }
        public int detalleReclamo { get; set; }
    }
