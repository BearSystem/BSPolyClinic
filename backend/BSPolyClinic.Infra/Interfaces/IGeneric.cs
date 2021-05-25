using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Infra.Interfaces
{
    public interface IGeneric<TEntity> where TEntity : class
    {
        IQueryable<TEntity> findAll();

        Task<TEntity> findById(Guid id);

        Task Insert(TEntity entity);
        Task Insert(List<TEntity> entity);

        Task Update(TEntity entity);
        Task Update(List<TEntity> entity);

        Task Excluir(Guid id);
        Task Excluir(List<TEntity> entity);
    }
}
