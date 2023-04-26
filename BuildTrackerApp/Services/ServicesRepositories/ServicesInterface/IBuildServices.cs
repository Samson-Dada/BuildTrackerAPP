using BuildTrackerApp.Models;

namespace BuildTrackerApp.Services.ServicesRepositories.ServicesInterface
{
    public interface IBuildServices
    {
       Task<ICollection<Build>> GetAllBuildAsync();
       Task  CreateBuildAsync(Build build);
        Task DeleteBuildAsync(int id);
        Task UpdateBuildAsync(Build build);
        Task<Build> GetBuildByIdAsync(int id);
    }
}
