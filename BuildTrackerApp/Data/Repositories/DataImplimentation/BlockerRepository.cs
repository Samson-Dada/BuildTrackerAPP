using BuildTrackerApp.Data.Repositories.DataInterface;
using BuildTrackerApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlTypes;

namespace BuildTrackerApp.Data.Repositories.DataImplimentation
{
    public class BlockerRepository : IBlockerRepository
    {
        private readonly BuildAppContext _context;

        public BlockerRepository(BuildAppContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Blocker blocker)
        {
            await _context.Blockers.AddAsync(blocker);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _context.Blockers.FirstOrDefaultAsync(x => x.Id == id);
        }


        public async Task<ICollection<Blocker>> GetAllAsync()
        {
            try
            {
                var allBlocker = await _context.Blockers.ToListAsync();
                return allBlocker;
            }
            catch (SqlNullValueException)
            {
                return new List<Blocker>();

            }
        }


        public async Task<Blocker> GetByIdAsync(int id)
        {
            var getBlockerId = await _context.Blockers.FirstOrDefaultAsync(x => x.Id == id);
            return getBlockerId;

        }

        public async Task UpdateAsync(Blocker blocker)
        {
            if(blocker == null)
            {
                throw new ArgumentNullException(nameof(blocker));
            }
            _context.Blockers.Update(blocker).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }


        public async Task<int> TotalCountAsync()
        {
            try
            {

                int totalCount = await _context.Blockers.CountAsync();
                if (totalCount >= 1)
                {
                    return totalCount;
                }
                return totalCount;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
