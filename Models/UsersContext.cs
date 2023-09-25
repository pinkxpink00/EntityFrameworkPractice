using Microsoft.EntityFrameworkCore;

namespace EFPractice.Models
{
    public class UsersContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Company> Companys { get; set; } = null!;
        public UsersContext(DbContextOptions<UsersContext> options):base (options) 
        {
            Database.EnsureCreated();
        }
    }
}
