using BuildTrackerApp.Models;
using BuildTrackerApp.Services.ServicesRepositories.ServicesInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BuildTrackerApp.Pages.Blockers
{
    public class ResolveBlockerModel : PageModel
    {
    private readonly IBlockerServices _blockerServices;
        public ResolveBlockerModel(IBlockerServices blockerServices)
        {
            _blockerServices= blockerServices;
        }
        public async Task OnGet(int id) =>
           Blocker = await _blockerServices.GetBlockerAsync(id);


        public  async Task OnGetResolve(int id)
        {
            var blockerToUpdate = await _blockerServices.GetBlockerAsync(id);
            if(blockerToUpdate is null)
            {
                return;
            }
           await _blockerServices.UpdateBlockerAsync(blockerToUpdate);
        }
        public Blocker Blocker { get; set; }
    }
}
