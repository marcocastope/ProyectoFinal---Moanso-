using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entTipoHabitacion
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public Boolean Estado { get; set; }
        public DateTime Createdat { get; set; }
        public DateTime Updateat { get; set; }
    }
}
