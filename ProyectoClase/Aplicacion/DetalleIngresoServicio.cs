using Dominio.Modelo.Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Modelo.Entidades;
using Infra.DataAccess.Repositorio;

namespace Aplicacion
{
    public class DetalleIngresoServicio
    {
        readonly IDetalleIngresoRepositorio detalleIngresoRepositorio;

        public DetalleIngresoServicio()
        {
            detalleIngresoRepositorio = new DetalleIngresoRepositorio();
        }

        public void InsertarDetalleIngreso(DetalleIngreso detalleIngreso)
        {
            detalleIngresoRepositorio.Add(detalleIngreso);
        }

        public void ModificarDetalleIngreso(DetalleIngreso detalleIngreso)
        {
            detalleIngresoRepositorio.Modify(detalleIngreso);
        }

        public IEnumerable<DetalleIngreso> ListarClientes()
        {
            return detalleIngresoRepositorio.GetAll();
        }
        public void EliminarCliente(int id)
        {
            detalleIngresoRepositorio.Delete(id);
        }


    }
}
