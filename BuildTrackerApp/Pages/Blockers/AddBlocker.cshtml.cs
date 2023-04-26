using BuildTrackerApp.Models;
using BuildTrackerApp.Services.ServicesRepositories.ServicesInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BuildTrackerApp.Pages.Blockers
{
    public class AddBlockerModel : PageModel
    {
        private readonly IBlockerServices _blockerServices;
        public AddBlockerModel(IBlockerServices blockerServices)
        {
            _blockerServices = blockerServices;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await _blockerServices.CreateBlockerAsync(Blockers);
            return RedirectToPage("../Index");
        }

        [BindProperty]
        public Blocker Blockers { get; set; }
    }
}
