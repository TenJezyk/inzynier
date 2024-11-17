namespace SportSystem.Data.Models
{
    public class UserTeam
    {
        public User User { get; set; }
        public Guid UserId { get; set; }
        public Team Team { get; set; }
        public Guid TeamId { get; set; }

    }
}
