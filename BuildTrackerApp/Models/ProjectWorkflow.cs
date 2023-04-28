namespace BuildTrackerApp.Models
{
    public class ProjectWorkflow
    {
        public int Id { get; set; }
        public string Backlog { get; set; }
        public string Status { get; set; }
        public int Completion { get; set; }
    }
}
