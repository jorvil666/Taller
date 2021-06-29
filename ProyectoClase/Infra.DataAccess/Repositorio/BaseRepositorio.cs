using Dominio.Modelo.Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Repositorio
{
    public class BaseRepositorio<TEntity> : IDisposable, IBaseRepositorio<TEntity> where TEntity : class
    {
        public void Add(TEntity entity)
        {
            try
            {
                using (var context = new tallerDBEntities())
                {
                    context.Set<TEntity>().Add(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Noo se puede guardar el registro",ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var context = new tallerDBEntities())
                {
                    var entity = context.Set<TEntity>().Find(id);
                    context.Set<TEntity>().Remove(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede eliminar el registro", ex);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Modify(TEntity entity)
        {
            try
            {
                using (var context = new tallerDBEntities())
                {
                    context.Entry(entity).State=System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede actualizar el registro", ex);
            }

        }
    }
}
