using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Infra.Interfaces
{
    public interface IGeneric<TEntity> where TEntity : class
    {
        IQueryable<TEntity> FindAll();
        Task<TEntity> FindById(Guid id);
        Task Insert(TEntity entity);
        Task InsertList(List<TEntity> entity);
        Task Update(TEntity entity);
        Task DeleteById(Guid id);
        Task Delete(TEntity entity);
    }
}
