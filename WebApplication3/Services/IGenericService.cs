using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication3.Models.education;

namespace WebApplication3.Services
{
    public interface IGenericService<T>
        where T: Education
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Post(T obj);
        Task Put(T obj);
        Task Delete(int id);
       
    }

}

