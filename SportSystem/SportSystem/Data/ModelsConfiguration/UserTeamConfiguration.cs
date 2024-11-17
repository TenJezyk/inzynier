using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SportSystem.Data.Models;

namespace SportSystem.Data.ModelsConfiguration
{
    public class UserTeamConfiguration : IEntityTypeConfiguration<UserTeam>
    {
        public void Configure(EntityTypeBuilder<UserTeam> builder)
        {
            builder
                .HasKey(ut => new { ut.UserId, ut.TeamId });

            builder
                .HasOne(ut => ut.Team)
                .WithMany(ut => ut.Users)
                .HasForeignKey(ut => ut.TeamId);

            builder
                .HasOne(ut => ut.User)
                .WithMany(ut => ut.Team)
                .HasForeignKey(ut => ut.UserId);
        }
    }
}
