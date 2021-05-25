using BSPolyClinic.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Infra.Repositories
{
    public class GenericRepository<TEntity> : IGeneric<TEntity> where TEntity : class
    {
        public Task Excluir(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Excluir(List<TEntity> entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> findAll()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> findById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task Insert(List<TEntity> entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(List<TEntity> entity)
        {
            throw new NotImplementedException();
        }
    }
}
