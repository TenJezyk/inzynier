using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SportSystem.Data.Models;

namespace SportSystem.Data.ModelsConfiguration
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(g => g.Id);

            builder
                .HasOne(g => g.HostTeam)
                .WithMany(t => t.HomeGames)
                .HasForeignKey(gt => gt.HostTeamId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder
                .HasOne(g => g.VisitorsTeam)
                .WithMany(t => t.VisitorsGames)
                .HasForeignKey(gt => gt.VisitorTeamId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder
                .HasOne(g => g.Location)
                .WithMany()
                .HasForeignKey(gt => gt.LocationId);

        }
    }
}
