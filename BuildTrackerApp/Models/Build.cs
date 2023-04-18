namespace BuildTrackerApp.Models
{
    public class Build
    {
        public int Id { get; set; }
        public string Titile { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public Role Role { get; set; }
        public int OpenTask { get; set; }
        public int CloseTask { get; set; }
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