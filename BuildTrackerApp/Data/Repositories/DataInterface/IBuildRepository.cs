using BuildTrackerApp.Models;

namespace BuildTrackerApp.Data.Repositories.DataInterface
{
    public interface IBuildRepository
    {
        Task AddASync(Build build);
        Task UpdateAsync(Build build);
        Task<Build> GetByIdAsync(int id);
        Task<ICollection<Build>> GetAllAsync();
        Task DeleteAsync(int id);
        Task<int> GetTotalCountAsync();
    }
}
