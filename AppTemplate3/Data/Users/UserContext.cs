using Microsoft.EntityFrameworkCore;

namespace AppTemplate3.Data.Users
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
        public DbSet<Auth0User> Auth0Users { get; set; }
        public DbSet<AuditLogin> AuditLogins { get; set; }
    }
}