using BSPolyClinic.Infra;
using BSPolyClinic.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Infra.Repositories
{
    public class GenericRepository<TEntity> : IGeneric<TEntity> where TEntity : class
    {
        private readonly Context _context;

        public GenericRepository(Context context)
        {
            _context = context;
        }

        public async Task DeleteById(Guid id)
        {
            try
            {
                var entity = await FindById(id);
                _context.Set<TEntity>().Remove(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Delete(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Remove(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<TEntity> FindAll()
        {
            try
            {
                return _context.Set<TEntity>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<TEntity> FindById(Guid id)
        {
            try
            {
                var entity = await _context.Set<TEntity>().FindAsync(id);
                return entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Insert(TEntity entity)
        {
            try
            {
                await _context.AddAsync(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task InsertList(List<TEntity> entity)
        {
            try
            {
                await _context.AddRangeAsync(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Update(TEntity entity)
        {
            try
            {
                var result = _context.Set<TEntity>().Update(entity);
                result.State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
