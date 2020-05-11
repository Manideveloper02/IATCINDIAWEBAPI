using System.Collections.Generic;
using System.Threading.Tasks;

namespace IATCINDIAWEBAPI.Data
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);

    }
}
