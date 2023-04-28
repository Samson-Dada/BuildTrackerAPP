using BuildTrackerApp.Models;
using Newtonsoft.Json;

namespace BuildTrackerApp.Data.Repositories.DataInterface
{
    public interface IProjectRepository
    {

        ICollection<ProjectWorkflow> GetProjects();

     
    }
}
