using BuildTrackerApp.Models;

namespace BuildTrackerApp.Data.Repositories.DataInterface
{
    public interface ITeamRepository
    {
        ICollection<Team> GetAllTeam();
    }
}
