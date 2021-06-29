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
    public class ServiciosServicio
    {
        readonly IServicioRepositorio serviciosRepositorio;

        public ServiciosServicio()
        {
            serviciosRepositorio = new ServiciosRepositorio();
        }

        public void InsertarServicios(Servicios servicios)
        {
            serviciosRepositorio.Add(servicios);
        }

        public void ModificarServicios(Servicios servicios)
        {
            serviciosRepositorio.Modify(servicios);
        }

        public IEnumerable<Servicios> ListarClientes()
        {
            return serviciosRepositorio.GetAll();
        }
        public void EliminarCliente(int id)
        {
            serviciosRepositorio.Delete(id);
        }
    }
}
