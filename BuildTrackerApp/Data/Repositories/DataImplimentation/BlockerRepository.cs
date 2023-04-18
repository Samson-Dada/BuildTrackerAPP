using BuildTrackerApp.Data.Repositories.DataInterface;
using BuildTrackerApp.Models;
using Microsoft.EntityFrameworkCore;

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
            var addBlocker = _context.Blockers.AddAsync(blocker);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var deleteBlockerId = await _context.Blockers.FirstOrDefaultAsync(x => x.Id == id);

        }

        public async Task<ICollection<Blocker>> GetAllAsync()
        {
            var allBlocker = await _context.Blockers.ToListAsync();
            return allBlocker;
        }

        public async Task<Blocker> GetByIdAsync(int id)
        {
            var getBlockerId = await _context.Blockers.FirstOrDefaultAsync(x => x.Id == id);
            return getBlockerId;

        }

        public async Task UpdateAsync(Blocker blocker)
        {
            _context.Blockers.Update(blocker).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
