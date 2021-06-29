using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.windows.VistaModelo
{
    public class ClienteVistaModelo
    {
        //Permite el manejo de validaciones
        public int idCliente { get; set; }
        public string nombreCliente { get; set; }
        public string apellidoCliente { get; set; }
        public string direccionCliente { get; set; }
        public string fonoCliente { get; set; }
        public string emailCliente { get; set; }
        public Nullable<int> estadoCliente { get; set; }
    }
}
