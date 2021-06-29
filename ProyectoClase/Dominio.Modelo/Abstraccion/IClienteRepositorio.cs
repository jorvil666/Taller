using Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelo.Abstraccion
{
    public interface IClienteRepositorio: IBaseRepositorio<Cliente>
    {
        IEnumerable<Cliente> ListarClientesActivos();
        IEnumerable<Cliente> ListarEmailCliente();

    }
}
