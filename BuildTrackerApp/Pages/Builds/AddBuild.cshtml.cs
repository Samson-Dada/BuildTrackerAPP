using BuildTrackerApp.Models;
using BuildTrackerApp.Services.ServicesRepositories.ServicesInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BuildTrackerApp.Pages.Builds
{
    public class AddBuidModel : PageModel
    {
        private readonly IBuildServices _buildServices;
        public AddBuidModel(IBuildServices buildServices)
        {
            _buildServices = buildServices;
        }
        [BindProperty]
        public Build NewBuild { get; set; }
     
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var productName = NewBuild.Title;
            NewBuild.CreatedTime = DateTime.Now;
            await _buildServices.CreateBuildAsync(NewBuild);
            return RedirectToPage("viewallbuild");
        }
    }
}
