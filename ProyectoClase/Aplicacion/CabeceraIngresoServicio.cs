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
    public class CabeceraIngresoServicio
    {
        readonly ICabeceraIngresoRepositorio cabeceraIngresoRepositorio;

        public CabeceraIngresoServicio()
        {
            cabeceraIngresoRepositorio = new CabeceraIngresoRepositorio();
        }

        public void InsertarCabeceraIngreso(CabeceraIngreso cabeceraIngreso)
        {
            cabeceraIngresoRepositorio.Add(cabeceraIngreso);
        }

        public void ModificarCabeceraIngreso(CabeceraIngreso cabeceraIngreso)
        {
            cabeceraIngresoRepositorio.Modify(cabeceraIngreso);
        }

        public IEnumerable<CabeceraIngreso> ListarClientes()
        {
            return cabeceraIngresoRepositorio.GetAll();
        }
        public void EliminarCliente(int id)
        {
            cabeceraIngresoRepositorio.Delete(id);
        }

    }
}
