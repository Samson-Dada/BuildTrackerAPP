namespace BuildTrackerApp.Models
{
    public class Blocker
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public Role Role { get; set; }
        public BlockerPriority Priority { get; set; }
        public BlockerStatus StackStatus { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
