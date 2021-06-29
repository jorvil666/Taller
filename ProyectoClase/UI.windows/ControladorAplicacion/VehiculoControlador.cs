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
    public class VehiculoControlador
    {
        private VehiculoServicio servicio;
        
        public bool InsertarVehiculo(VehiculoVistaModelo VehiculoVista)
            {
            Vehiculo nuevo = new Vehiculo();
            try
            {
                nuevo.marca = VehiculoVista.marca;
                nuevo.modelo = VehiculoVista.modelo;
                nuevo.color = VehiculoVista.color;
                nuevo.placa = VehiculoVista.placa;
                servicio = new VehiculoServicio();
                servicio.InsertarVehiculo(nuevo);
                return true;
            }
            catch (Exception e)
            {
                return false;

            }
            }

    }
}
