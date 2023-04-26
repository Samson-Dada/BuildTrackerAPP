using BuildTrackerApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BuildTrackerApp.Pages.Builds
{
    public class AddBuidModel : PageModel
    {
        
        [BindProperty]
        public Build NewBuild { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {
            if (ModelState.IsValid)
            {

                var productName = NewBuild.Title;
                return RedirectToPage("viewallbuild");
            }
            return Page();
        }
    }
}
