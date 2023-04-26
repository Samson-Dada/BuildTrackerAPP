using BuildTrackerApp.Data.Repositories.DataInterface;
using BuildTrackerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BuildTrackerApp.Data.Repositories.DataImplimentation
{
    public class TeamRepository : ITeamRepository
    {
        private readonly BuildAppContext _context;

        public TeamRepository(BuildAppContext context)
        {
            _context = context;
        }
        public async Task<ICollection<Team>> GetAllTeamAsync()
        {
            var getallTeam = await _context.Teams.ToListAsync();
            return getallTeam;
        }

        public async Task GetTeamByIdAsync(int id)
        {
            var team = await _context.Teams.FirstOrDefaultAsync(t => t.Id == id);
        }
    }
}
