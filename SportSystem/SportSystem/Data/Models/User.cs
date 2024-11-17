namespace SportSystem.Data.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public virtual ICollection<UserTeam> Team { get; set; }

        public Guid? UserRoleInTeamId { get; set; }
        public virtual UserTeamRole? RoleInTeam { get; set; }

        public Guid RoleId { get; set; }
        public virtual UserRoles Role { get; set; }
    }
}
