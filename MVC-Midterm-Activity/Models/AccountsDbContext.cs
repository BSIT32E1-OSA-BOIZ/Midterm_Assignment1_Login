using Microsoft.EntityFrameworkCore;

namespace MVC_Midterm_Activity.Models
{
    public class AccountsDbContext : DbContext
    {
        public AccountsDbContext(DbContextOptions options) : base(options)
        { 
        }

        public DbSet<Account> Accounts { get; set;}
    }
}
