using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ThePurrfectPaw.API.Entities;

namespace ThePurrfectPaw.API.Services
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<T> GetById( int id );
        Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate, string includeProperties = "");
        Task<List<T>> GetAll( string includeProperties = "" );
        Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate, string includeProperties = "" );
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
        Task<int> CountAll();
        Task<int> CountWhere(Expression<Func<T, bool>> predicate);
    }
}
