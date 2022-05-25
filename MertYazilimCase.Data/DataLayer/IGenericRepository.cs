using MertYazilimCase.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MertYazilimCase.Data.DataLayer
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T>GetEntity(Expression<Func<T, bool>> Filter = null);
        T GetEntityByID(int Id);
        void Insert(T t);
        void Delete(int Id);
        void Update(T t);
        void Save();
    }
}
