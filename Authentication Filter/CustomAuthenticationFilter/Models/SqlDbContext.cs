using System.Data.Entity;

namespace CustomAuthenticationFilter.Models
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext() : base("name=SqlConnection")
        {
        }
        public DbSet<User> Users { get; set; }
    }
}