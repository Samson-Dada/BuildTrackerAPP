using BuildTrackerApp.Models;

namespace BuildTrackerApp.Services.ServicesRepositories.ServicesInterface
{
    public interface IBlockerServices
    {

        Task CreateBlockerAsync(Blocker blocker);
        Task UpdateBlockerAsync(Blocker blocker);
        Task DeleteBlockerAsync(int BlockerId);
        Task<Blocker> GetBlockerAsync(int id);
        Task<ICollection<Blocker>> GetAllBlockerAsync();

        Task<int> GetTotalBlockerCountAsync();
    }
}
