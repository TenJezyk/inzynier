using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportSystem.Data.Models;
using SportSystem.Data.Models.Enum;
using SportSystem.SharedConfiguration;

namespace SportSystem.Data.ModelsConfiguration
{
    public class UserTeamRoleConfiguration : IEntityTypeConfiguration<UserTeamRole>
    {
        public void Configure(EntityTypeBuilder<UserTeamRole> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Name)
            .IsRequired();

            var roles = new UserTeamRole[]
            {
                Create(1.ToGuid(), UserRoleInTeam.Goalkeeper.ToString()),
                Create(2.ToGuid(), UserRoleInTeam.Defender.ToString()),
                Create(3.ToGuid(), UserRoleInTeam.DefensiveMidfielder.ToString()),
                Create(4.ToGuid(), UserRoleInTeam.ForwardMidfielder.ToString()),
                Create(5.ToGuid(), UserRoleInTeam.Midfielder.ToString()),
                Create(6.ToGuid(), UserRoleInTeam.Striker.ToString()),
            };

            builder.HasData(roles);
        }

        private static UserTeamRole Create(Guid id, string name)
        {
            return new UserTeamRole
            {
                Id = id,
                Name = name
            };
        }
    }
}
