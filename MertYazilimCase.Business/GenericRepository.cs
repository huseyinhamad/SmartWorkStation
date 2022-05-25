using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MertYazilimCase.Data.Models;
using Microsoft.EntityFrameworkCore;
using MertYazilimCase.Data.DataLayer;
using System.Linq.Expressions;

namespace MertYazilimCase.Business
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        DatabaseContext context = new DatabaseContext();
        private DbSet<T> _dbSet;
        public GenericRepository(DatabaseContext context)
        {
            this.context = context;
            _dbSet = context.Set<T>();
        }
        public virtual IEnumerable<T>GetEntity(Expression<Func<T, bool>> Filter = null)
        {
            if (Filter != null)
            {
                return _dbSet.Where(Filter).ToList();
            }
            return _dbSet.ToList();
        }

        public T GetEntityByID(int Id)
        {
            return _dbSet.Find(Id);
        }

        public void Insert(T t)
        {
            _dbSet.Add(t);
        }

        public void Delete(int Id)
        {
            T entityToDelete = _dbSet.Find(Id);
            Delete(entityToDelete);
        }
        public virtual void Delete(T t)
        {
            if (context.Entry(t).State == EntityState.Detached)
            {
                _dbSet.Attach(t);
            }
            _dbSet.Remove(t);
        }
        public void Update(T t)
        {
            _dbSet.Attach(t);
            context.Entry(t).State = EntityState.Modified;
        }
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
