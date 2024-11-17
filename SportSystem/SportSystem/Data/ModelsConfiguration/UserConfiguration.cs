using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportSystem.Data.Models;
using SportSystem.SharedConfiguration;

namespace SportSystem.Data.ModelsConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.RoleId)
                .HasDefaultValue(1.ToGuid());
        }
    }
}
