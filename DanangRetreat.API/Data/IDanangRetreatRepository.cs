using System.Threading.Tasks;
using System.Collections.Generic;
using DanangRetreat.API.Models;

namespace DanangRetreat.API.Data
{
    public interface IDanangRetreatRepository
    {
         void Add<T>(T entity) where T : class;
         void Delete<T>(T entity) where T : class;
         Task<IList<Accommodation>> GetAccommodations();
         Task<Accommodation> GetAccommodation(int id);
         Task<int> SaveChanges();
    }
}