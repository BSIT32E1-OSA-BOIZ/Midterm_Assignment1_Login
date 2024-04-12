using MVC_Midterm_Activity.Models;

namespace MVC_Midterm_Activity.Providers.Repositories
{
    public interface IUserRepository
    {
        //...
    }

    public class UserRepository : IUserRepository
    {
        private readonly AccountsDbContext _db;

        public UserRepository(AccountsDbContext db) 
        { 
            _db = db;
        }

        //...
    }
}
