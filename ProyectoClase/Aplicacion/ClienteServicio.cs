using Dominio.Modelo.Abstraccion;
using Dominio.Modelo.Entidades;
using Infra.DataAccess.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class ClienteServicio
    {
        readonly IClienteRepositorio clienteRepositorio;
        public ClienteServicio()
        {
            clienteRepositorio = new ClienteRepositorio();
        
        }

        public void InsertarCliente(Cliente cliente)
        {
            clienteRepositorio.Add(cliente);
        }

        public void ModificarCliente(Cliente cliente)
        {
            clienteRepositorio.Modify(cliente);
        }

        public IEnumerable<Cliente> ListarClientes()
        {
          return clienteRepositorio.GetAll();
        }
        public void EliminarCliente(int id)
        {
            clienteRepositorio.Delete(id);
        }
        public IEnumerable<Cliente> ListarClientesActivos()
        {
            return clienteRepositorio.ListarClientesActivos();

        }
    }
}
