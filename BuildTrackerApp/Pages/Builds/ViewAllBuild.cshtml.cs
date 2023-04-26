using BuildTrackerApp.Data.Repositories.DataInterface;
using BuildTrackerApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BuildTrackerApp.Pages.Builds
{
    public class ViewAllBuildModel : PageModel
    {
        private readonly IBuildRepository _buildRepository;
        public ViewAllBuildModel(IBuildRepository buildRepository)
        {
            _buildRepository = buildRepository;
        }

        [BindProperty]
        public ICollection<Build> Builds { get; set; }
        public async void OnGet()
        {
          Builds = await _buildRepository.GetAllAsync();
        }
    }
}
