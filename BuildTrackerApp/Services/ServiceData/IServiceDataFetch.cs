using BuildTrackerApp.Models;

namespace BuildTrackerApp.Services.ServiceData
{
    public interface IServiceDataFetch
    {
        ICollection<ProjectWorkflow> GetAllProject();
    }
}
