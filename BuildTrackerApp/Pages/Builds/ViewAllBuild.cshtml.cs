using BuildTrackerApp.Data.Repositories.DataInterface;
using BuildTrackerApp.Models;
using BuildTrackerApp.Services.ServicesRepositories.ServicesInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BuildTrackerApp.Pages.Builds
{
    public class ViewAllBuildModel : PageModel
    {
        private readonly IBuildServices _buildServices;
        public ViewAllBuildModel(IBuildServices buildServices)
        {
            _buildServices = buildServices;
        }

        [BindProperty]
        public ICollection<Build> Builds { get; set; }
        public async Task OnGet()
        {
          Builds = await _buildServices.GetAllBuildAsync();
        }
    }
}


/*
 
   public ICollection<Team> Teams { get; set; }

        public async Task OnGet()
        {
            Teams = await _teamServices.GetAllTeamAsync();
        }
 */
