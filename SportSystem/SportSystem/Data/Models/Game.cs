using SportSystem.Data.Models.Enum;

namespace SportSystem.Data.Models
{
    public class Game
    {

        public Guid Id { get; set; }
        public DateTime GameDate { get; set; }

        public virtual Location Location { get; set; }
        public Guid LocationId { get; set; }

        public virtual Team HostTeam { get; set; }
        public Guid HostTeamId { get; set; }
        public int? HostTeamGoals { get; set; }

        public virtual Team VisitorsTeam { get; set; }
        public Guid VisitorTeamId { get; set; }
        public int? VisitorTeamGoals { get; set; }
    }
}
