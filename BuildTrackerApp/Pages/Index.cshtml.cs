using BuildTrackerApp.Data.Repositories.DataInterface;
using BuildTrackerApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BuildTrackerApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IBuildRepository _buildRepository;

        public IndexModel(IBuildRepository buildRepository)
        {
            _buildRepository = buildRepository;
        }

        public async Task OnGet()
        {
           Builds =  await _buildRepository.GetAllAsync();
        }
      
        public ICollection<Build> Builds { get; set; }
    }
}