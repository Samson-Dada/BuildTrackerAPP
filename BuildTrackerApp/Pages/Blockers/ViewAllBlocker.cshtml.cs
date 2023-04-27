using BuildTrackerApp.Models;
using BuildTrackerApp.Services.ServicesRepositories.ServicesInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BuildTrackerApp.Pages.Blockers
{
    public class ViewAllBlockerModel : PageModel
    {
        private readonly IBlockerServices _blockerServices;
        public ViewAllBlockerModel(IBlockerServices blockerServices)
        {
            _blockerServices= blockerServices;
        }
        //public async Task OnGet()
        //{
        //    Blockers = await _blockerServices.GetAllBlockerAsync();
        //}

        public async Task OnGet()
        {
            Blockers = await _blockerServices.GetAllBlockerAsync();
            if (Blockers == null)
            {
                // Handle null case
                // For example, set a default value or throw an exception
                Blockers = new List<Blocker>();
                // throw new Exception("Blockers list is null");
            }
            else
            {
                // Access elements of the Blockers list
                foreach (var blocker in Blockers)
                {
                    // ...
                }
            }
        }



        [BindProperty]
        public ICollection<Blocker> Blockers { get; set; }
    }
}
