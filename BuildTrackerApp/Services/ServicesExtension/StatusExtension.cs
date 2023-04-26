using BuildTrackerApp.Models;

namespace BuildTrackerApp.Services.ServicesExtension
{
    public static class StatusExtension
    {
        static readonly Dictionary<bool, string> _statusCss = new()
        {
            { true, "bg-gradient-success"},
            { false, "bg-gradient-red"}
        };
        //public static string StatusInfo(this string status ) 
        //{
        //   return _statusCss[bool, _statusCss];
        //}
    }
}
