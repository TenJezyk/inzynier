using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportSystem.Data.Models;

namespace SportSystem.Data.DataContext
{
    public class SportSystemDbContext : IdentityDbContext<ApplicationUser>
    {
        public SportSystemDbContext(DbContextOptions<SportSystemDbContext> options): base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<UserTeam> UserTeams { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(SportSystemDbContext).Assembly);

            builder.HasDefaultSchema("Identity");
            builder.Entity<ApplicationUser>(
                entity =>
                {
                    entity.ToTable("IdentityUsers");
                });

            builder.Entity<IdentityRole>(
                entity =>
                {
                    entity.ToTable("IdentityRole");
                });

            builder.Entity<IdentityUserRole<string>>(
                entity =>
                {
                    entity.ToTable("IdentityUserRoles");
                });

            builder.Entity<IdentityUserClaim<string>>(
                entity =>
                {
                    entity.ToTable("UserClaims");
                });

            builder.Entity<IdentityUserLogin<string>>(
                entity =>
                {
                    entity.ToTable("UserLogins");
                });

            builder.Entity<IdentityRoleClaim<string>>(
                entity =>
                {
                    entity.ToTable("IdentityRoleClaims");
                });

            builder.Entity<IdentityUserToken<string>>(
                entity =>
                {
                    entity.ToTable("UserTokens");
                });
        }
    }
}
