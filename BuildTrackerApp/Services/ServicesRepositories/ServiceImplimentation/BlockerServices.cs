using BuildTrackerApp.Data.Repositories.DataInterface;
using BuildTrackerApp.Models;
using BuildTrackerApp.Services.ServicesRepositories.ServicesInterface;

namespace BuildTrackerApp.Services.ServicesRepositories.ServiceImplimentation
{
    public class BlockerServices : IBlockerServices
    {
        private readonly IBlockerRepository _blockerRepository;
        public BlockerServices(IBlockerRepository blockerRepository)
        {
            _blockerRepository = blockerRepository;
        }

        public async Task CreateBlockerAsync(Blocker blocker)
        {
            await _blockerRepository.AddAsync(blocker);
        }

        public async Task DeleteBlockerAsync(int BlockerId)
        {
            await _blockerRepository.DeleteAsync(BlockerId);
        }

        public async Task<ICollection<Blocker>> GetAllBlockerAsync()
        {
            var allBlocker = await _blockerRepository.GetAllAsync();
            return allBlocker;
        }

        public Task<Blocker> GetBlockerAsync(int id)
        {
            var blockerId = _blockerRepository.GetByIdAsync(id);
            return blockerId;
        }

        public async Task UpdateBlockerAsync(Blocker blocker)
        {
            await _blockerRepository.UpdateAsync(blocker);
        }
    }
}
