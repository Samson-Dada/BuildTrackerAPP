using BuildTrackerApp.Models;

namespace BuildTrackerApp.Services.ServicesRepositories.ServicesInterface
{
    public interface ITeamServices
    {
        Task<ICollection<Team>> GetAllTeamAsync();
         Task GetTeamAsync(int teamId);
    }
}
