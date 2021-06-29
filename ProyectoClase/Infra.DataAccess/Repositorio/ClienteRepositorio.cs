using Dominio.Modelo.Abstraccion;
using Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Repositorio
{
    public class ClienteRepositorio : BaseRepositorio<Cliente>, Dominio.Modelo.Abstraccion.IClienteRepositorio
    {
        public IEnumerable<Cliente> ListarClientesActivos()
        {
            try
            {
                using (var contex = new tallerDBEntities())
                {
                    //select * from cliente where estadoCliente = 1
                    var query = from cli in contex.Cliente
                                where cli.estadoCliente == 1
                                select cli;
                    return query.ToList();
                }

            }
            catch(Exception ex)
            {
                throw new Exception("No se puede lstar clientes",ex);
            }
        }

        public IEnumerable<Cliente> ListarEmailCliente()
        {
            throw new NotImplementedException();
        }
    }
}
