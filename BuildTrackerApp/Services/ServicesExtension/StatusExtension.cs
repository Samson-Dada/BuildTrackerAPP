using BuildTrackerApp.Models;

namespace BuildTrackerApp.Services.ServicesExtension
{
    public static class StatusExtension
    {
        static readonly Dictionary<BlockerPriority, string> _statusCss = new()
        {
            { BlockerPriority.High, "bg-danger"},
            { BlockerPriority.Low, "bg-success"},
            { BlockerPriority.Medium, "bg-warning"},
        };
        public static string PriorityCss(this BlockerPriority priority)
        {
            return _statusCss[priority];
        }
    }
}
