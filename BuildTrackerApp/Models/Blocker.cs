using System.ComponentModel.DataAnnotations;

namespace BuildTrackerApp.Models
{
    public class Blocker
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public Role Role { get; set; }
        [Required]
        public BlockerPriority Priority { get; set; }
        [Required]
        public BlockerStatus BlockerStatus { get; set; }
        [Required]
        public DateTime CreatedTime { get; set; }
    }
}
