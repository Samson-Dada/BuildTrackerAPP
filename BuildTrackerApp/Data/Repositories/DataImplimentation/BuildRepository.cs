using BuildTrackerApp.Data.Repositories.DataInterface;
using BuildTrackerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BuildTrackerApp.Data.Repositories.DataImplimentation
{
    public class BuildRepository : IBuildRepository
    {
        private readonly BuildAppContext _context;

        public BuildRepository(BuildAppContext context)
        {
            _context = context;
        }
        public async Task AddASync(Build build)
        {
            var addBuild = _context.Builds.AddAsync(build);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var buildId = _context.Builds.FirstOrDefault(x => x.Id == id);
            if (buildId is not null)
            {
                return;
            }
            _context.Builds.Remove(buildId);
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<Build>> GetAllAsync()
        {
            var allbuild = await _context.Builds.ToListAsync();
            return allbuild;
        }

        public async Task<Build> GetByIdAsync(int id)
        {
            var buildId =  await _context.Builds.FirstOrDefaultAsync(b => b.Id == id);
            if (buildId is null)
            {
                return null;
            }
            return buildId;
        }

        public async Task UpdateAsync(Build build)
        {
            var updateBuild = _context.Builds.Update(build);
            await _context.SaveChangesAsync();


        }
    }
}
