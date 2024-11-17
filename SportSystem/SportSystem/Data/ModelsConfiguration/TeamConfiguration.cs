using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportSystem.Data.Models;

namespace SportSystem.Data.ModelsConfiguration
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasMany(x => x.VisitorsGames)
                .WithOne(x => x.VisitorsTeam)
                .HasForeignKey(x => x.VisitorTeamId);

            builder
                .HasMany(x => x.HomeGames)
                .WithOne(x => x.HostTeam)
                .HasForeignKey(x => x.HostTeamId);
        }
    }
}
