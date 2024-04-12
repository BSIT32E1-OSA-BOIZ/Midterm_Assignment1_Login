using Microsoft.EntityFrameworkCore;
using MVC_Midterm_Activity.Models;

namespace MVC_Midterm_Activity.Data
{
    public class AccountsDbContext : DbContext
    {
        public AccountsDbContext(DbContextOptions<AccountsDbContext> options) : base(options)
        {
        }

        public DbSet<AccountUser> Accounts { get; set; }
    }
}
