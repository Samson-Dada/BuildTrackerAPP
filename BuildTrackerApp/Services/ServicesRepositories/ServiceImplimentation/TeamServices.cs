using BuildTrackerApp.Data.Repositories.DataInterface;
using BuildTrackerApp.Models;
using BuildTrackerApp.Services.ServicesRepositories.ServicesInterface;

namespace BuildTrackerApp.Services.ServicesRepositories.ServiceImplimentation
{
    public class TeamServices : ITeamServices
    {

        private readonly ITeamRepository _teamRepository;
        public TeamServices(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }
        public async Task<ICollection<Team>> GetAllTeamAsync()
        {
            var allTeam = await _teamRepository.GetAllTeamAsync();
            return allTeam;
        }

        public async Task GetTeamAsync(int teamId)
        {
         await _teamRepository.GetTeamByIdAsync(teamId);
        }
    }
}
