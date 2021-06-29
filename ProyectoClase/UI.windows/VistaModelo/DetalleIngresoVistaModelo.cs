using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerUI.UI.windows.VistaModelo
{
    public class DetalleIngresoVistaModelo
    {
        public int idDetalle { get; set; }
        public Nullable<int> idIngreso { get; set; }
        public Nullable<int> cantidad { get; set; }
        public string observacion { get; set; }
        public int idServicios { get; set; }
    }
}
