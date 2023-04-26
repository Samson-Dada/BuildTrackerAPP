using BuildTrackerApp.Models;
using BuildTrackerApp.Services.ServicesRepositories.ServicesInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BuildTrackerApp.Pages.Builds
{
    public class BuildDetailsModel : PageModel
    {

        private readonly IBuildServices _buildServices;
        public BuildDetailsModel(IBuildServices buildServices)
        {
            _buildServices= buildServices;
        }

        public async Task<IActionResult> OnGet(int id)
        {
            Builds = await _buildServices.GetBuildByIdAsync(id);

            if (Builds == null)
            {
                return NotFound();
            }
            return Page();
        }

        [BindProperty]
        public Build Builds { get; set; }  
    }
}
