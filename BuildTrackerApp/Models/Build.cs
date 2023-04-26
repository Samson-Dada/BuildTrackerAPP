using System.ComponentModel.DataAnnotations;

namespace BuildTrackerApp.Models
{
    public class Build
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        
        [Required]
        public string ShortDescription { get; set; }
        [Required]

        public string Description { get; set; }
        [Required]
        public Role Role { get; set; }
        
        [Required]
        public int OpenTask { get; set; }

        [Required]
        public int CloseTask { get; set; }

        [Required]
        public DateTime CreatedTime { get; set; }
    }
}

/*
 
        public int Id { get; set; }
        public string Titile { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public Role Role { get; set; }
        public BlockerPriority Priority { get; set; }
        public BlockerStatus StackStatus { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime Completed { get; set;}
 */