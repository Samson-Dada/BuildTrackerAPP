using BuildTrackerApp.Models;

namespace BuildTrackerApp.Data.Repositories.DataInterface
{
    public interface ITeamRepository
    {
        Task<ICollection<Team>> GetAllTeamAsync();

        Task GetTeamByIdAsync(int id);
    }
}
