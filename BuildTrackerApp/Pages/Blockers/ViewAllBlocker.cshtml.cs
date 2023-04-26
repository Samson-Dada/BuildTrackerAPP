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
        public async Task OnGet()
        {
            Blockers = await _blockerServices.GetAllBlockerAsync();
        }


        [BindProperty]
        public ICollection<Blocker> Blockers { get; set; }
    }
}
