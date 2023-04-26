using BuildTrackerApp.Data.Repositories.DataInterface;
using BuildTrackerApp.Models;
using BuildTrackerApp.Services.ServicesRepositories.ServicesInterface;

namespace BuildTrackerApp.Services.ServicesRepositories.ServiceImplimentation
{
    public class BuildServices : IBuildServices
    {
        private readonly IBuildRepository _buildRepository;
        public BuildServices(IBuildRepository buildRepository)
        {
            _buildRepository = buildRepository; 
        }
        public async Task CreateBuildAsync(Build build)
        {
           await  _buildRepository.AddASync(build);
        }

        public async Task DeleteBuildAsync(int id)
        {
            await _buildRepository.DeleteAsync(id);
        }

        public async Task<ICollection<Build>> GetAllBuildAsync()
        {
            var allBuild = await _buildRepository.GetAllAsync();
            return allBuild;
        }

        public async Task<Build> GetBuildByIdAsync(int id)
        {
           var buildId =  await _buildRepository.GetByIdAsync(id);
            return buildId;
        }

        public async Task UpdateBuildAsync(Build build)
        {
           await _buildRepository.UpdateAsync(build);
        }
    }
}

