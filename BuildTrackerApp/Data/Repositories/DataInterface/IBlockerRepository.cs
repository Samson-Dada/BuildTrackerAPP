using BuildTrackerApp.Models;

namespace BuildTrackerApp.Data.Repositories.DataInterface
{
    public interface IBlockerRepository
    {
        Task AddAsync(Blocker blocker);
        Task UpdateAsync(Blocker blocker);
        Task<Blocker> GetByIdAsync(int id);
        Task<ICollection<Blocker>> GetAllAsync();
        Task DeleteAsync(int id);

        Task<int> TotalCountAsync();

        ///
      
    }
}
