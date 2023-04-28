using BuildTrackerApp.Data.Repositories.DataInterface;
using BuildTrackerApp.Models;
using Newtonsoft.Json;

namespace BuildTrackerApp.Data.Repositories.DataImplimentation
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly IWebHostEnvironment _environment;

        public ProjectRepository(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        public ICollection<ProjectWorkflow> GetProjects()
        {
            //var filePath = Path.Combine(_environment.ContentRootPath)
            var jsonProjects = System.IO.File.ReadAllText("wwwroot/Data/ProjectWorkflow.json");
            var product = JsonConvert.DeserializeObject<List<ProjectWorkflow>>(jsonProjects);
            return product;
        }
    }
}

