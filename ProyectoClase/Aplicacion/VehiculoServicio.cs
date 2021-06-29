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
    public class VehiculoServicio
    {
        readonly IVehiculoRepositorio vehiculoRepositorio;

        public VehiculoServicio()
        {
            vehiculoRepositorio = new VehiculoRepositorio();
        }

        public void InsertarVehiculo (Vehiculo vehiculo)
        {
            vehiculoRepositorio.Add(vehiculo);
        }

        public void ModificarVehiculo(Vehiculo vehiculo)
        {
            vehiculoRepositorio.Modify(vehiculo);
        }

        public IEnumerable<Vehiculo> ListarClientes()
        {
            return vehiculoRepositorio.GetAll();
        }
        public void EliminarCliente(int id)
        {
            vehiculoRepositorio.Delete(id);
        }
    }
}
