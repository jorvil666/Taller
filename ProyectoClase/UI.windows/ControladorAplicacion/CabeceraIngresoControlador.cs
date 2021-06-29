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
    public class CabeceraIngresoControlador
    {
        private CabeceraIngresoServicio servicio;

        public bool InsertarCabeceraIngreso(CabeceraIngresoVistaModelo CabeceraIngresoVista)
        {
            CabeceraIngreso nuevo = new CabeceraIngreso();
            try
            {
                nuevo.fechaIngreso = CabeceraIngresoVista.fechaIngreso;
                nuevo.observacion = CabeceraIngresoVista.observacion;
                nuevo.estado = CabeceraIngresoVista.estado;
                servicio = new CabeceraIngresoServicio();
                servicio.InsertarCabeceraIngreso(nuevo);
                return true;
            }
            catch (Exception e)
            {
                return false;

            }
        }
    }
}
