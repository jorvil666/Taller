using Aplicacion;
using Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.windows.VistaModelo;

namespace UI.windows.ControladorAplicacion
{
    public class ClienteControlador
    {
        private ClienteServicio servicio;


        public bool InsertarCliente(ClienteVistaModelo ClienteVista)
        {
            Cliente nuevo = new Cliente();
            try
            {
                nuevo.nombreCliente = ClienteVista.nombreCliente;
                nuevo.apellidoCliente = ClienteVista.apellidoCliente;
                nuevo.emailCliente = ClienteVista.emailCliente;
                servicio = new ClienteServicio();
                servicio.InsertarCliente(nuevo);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public IEnumerable<ClienteVistaModelo> ListarClientesActivos()
        {
            var ClienteLista = new ClienteServicio().ListarClientesActivos();
            List<ClienteVistaModelo> ListaClienteVista = new List<ClienteVistaModelo>();
            foreach (Cliente item in ClienteLista)
            {
                ListaClienteVista.Add(new ClienteVistaModelo
                {
                    idCliente = item.idCliente,
                    nombreCliente = item.nombreCliente,
                    apellidoCliente = item.apellidoCliente,
                    direccionCliente = item.direccionCliente,
                    emailCliente = item.emailCliente,
                    estadoCliente = item.estadoCliente,
                    fonoCliente = item.fonoCliente

                });

            }
            return ListaClienteVista;
        }
    }
}

