using Aplicacion;
using Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tallerUI.UI.windows.VistaModelo;

namespace tallerUI.UI.windows.ControladorAplicacion
{
   public class DetalleIngresoControlador
    {
        private DetalleIngresoServicio servicio;

        public bool InsertarDetalleIngreso(DetalleIngresoVistaModelo DetalleIngresoVista)
        {
            DetalleIngreso nuevo = new DetalleIngreso();
            try
            {
                nuevo.cantidad = DetalleIngresoVista.cantidad;
                nuevo.observacion = DetalleIngresoVista.observacion;
                servicio = new DetalleIngresoServicio();
                servicio.InsertarDetalleIngreso(nuevo);
                return true;
            }
            catch (Exception e)
            {
                return false;

            }
        }



    }
}
