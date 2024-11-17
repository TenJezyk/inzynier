using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportSystem.Data.Models;
using SportSystem.Data.Models.Enum;
using SportSystem.SharedConfiguration;
using System.Data;

namespace SportSystem.Data.ModelsConfiguration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRoles>
    {
        public void Configure(EntityTypeBuilder<UserRoles> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Name)
            .IsRequired();

            var roles = new UserRoles[]
            {
                Create(1.ToGuid(), UserRoleName.Coach.ToString()),
                Create(2.ToGuid(), UserRoleName.NormalUser.ToString())
            };

            builder.HasData(roles);
        }

        private static UserRoles Create(Guid id, string name)
        {
            return new UserRoles
            {
                Id = id,
                Name = name
            };
        }
    }
}
