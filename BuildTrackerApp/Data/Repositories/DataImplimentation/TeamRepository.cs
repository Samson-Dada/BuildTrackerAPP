using BuildTrackerApp.Data.Repositories.DataInterface;
using BuildTrackerApp.Models;

namespace BuildTrackerApp.Data.Repositories.DataImplimentation
{
    public class TeamRepository : ITeamRepository
    {
        private readonly BuildAppContext _context;

        public TeamRepository(BuildAppContext context)
        {
            _context = context;
        }
        public ICollection<Team> GetAllTeam()
        {
            var getallTeam =  _context.Teams.ToList();
            return getallTeam;
        }
    }
}
