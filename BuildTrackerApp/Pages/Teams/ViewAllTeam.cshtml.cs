using BuildTrackerApp.Data.Repositories.DataInterface;
using BuildTrackerApp.Models;
using BuildTrackerApp.Services.ServicesRepositories.ServicesInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BuildTrackerApp.Pages.Teams
{
    public class ViewAllTeamModel : PageModel
    {
        private readonly ITeamServices _teamServices;
        public ViewAllTeamModel(ITeamServices teamServices)
        {
            _teamServices = teamServices;
        }

        [BindProperty]
        public ICollection<Team> Teams { get; set; }

        public async Task OnGet()
        {
            Teams = await _teamServices.GetAllTeamAsync();
        }

    }
}
