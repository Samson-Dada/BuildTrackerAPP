namespace BuildTrackerApp.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ProductRole {get; set;}
        public string Role { get; set; }
        public bool Status { get; set; }
        public string ImageUrl { get; set; }
        public string Task { get; set; }


    }
}
