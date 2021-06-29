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
    public class ServiciosControlador
    {
        private ServiciosServicio servicio;

        public bool InsertarServicios(ServiciosVistaModelo ServiciosVista)
        {
            Servicios nuevo = new Servicios();
            try
            {
                nuevo.servicioNombre = ServiciosVista.servicioNombre;
                nuevo.servicioDescripcion = ServiciosVista.servicioDescripcion;
                nuevo.estado = ServiciosVista.estado;
                servicio = new ServiciosServicio();
                servicio.InsertarServicios(nuevo);
                return true;
            }
            catch (Exception e)
            {
                return false;

            }
        }

    }
}
