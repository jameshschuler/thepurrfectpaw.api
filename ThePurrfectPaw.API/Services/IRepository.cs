using System.Collections.Generic;
using System.Threading.Tasks;
using ThePurrfectPaw.API.Entities;

namespace ThePurrfectPaw.API.Services
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}
