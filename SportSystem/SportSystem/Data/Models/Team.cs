namespace SportSystem.Data.Models
{
    public class Team
    {

        public Team()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<UserTeam> Users { get; set; }
        public virtual ICollection<Game> HomeGames { get; set; }
        public virtual ICollection<Game> VisitorsGames { get; set; }
    }
}
