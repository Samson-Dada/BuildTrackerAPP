using BuildTrackerApp.Data.Repositories.DataInterface;
using BuildTrackerApp.Models;
namespace BuildTrackerApp.Services.ServiceData
{
    public class ServiceDataFetch : IServiceDataFetch
    {
        private readonly IProjectRepository _projectRepository;

        public ServiceDataFetch(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public ICollection<ProjectWorkflow> GetAllProject()
        {
            var project = _projectRepository.GetProjects();
            return project;
        }

       // public ICollection<ProjectWorkflow> GetData{ get; set; }
    }
}
