using System.Threading.Tasks;
using DanangRetreat.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DanangRetreat.API.Data
{
    public class DanangRetreatRepository : IDanangRetreatRepository
    {
        private readonly DataContext _dbContext;
        public DanangRetreatRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add<T>(T entity) where T : class
        {
            _dbContext.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _dbContext.Remove(entity);
        }

        public async Task<Accommodation> GetAccommodation(int id)
        {
            return await _dbContext.Accommodations.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IList<Accommodation>> GetAccommodations()
        {
            return await _dbContext.Accommodations.ToListAsync();
        }

        public async Task<int> SaveChanges()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}