using MVC_Midterm_Activity.Data;
using MVC_Midterm_Activity.Models;

namespace MVC_Midterm_Activity.Providers.Repositories
{
    public interface IUserRepository
    {
        AccountUser Register(AccountUser user);
        AccountUser Validate(AccountUser user);
    }


    public class UserRepository : IUserRepository
    {
        private readonly AccountsDbContext _db;

        public UserRepository(AccountsDbContext db) 
        { 
            _db = db;
        }

        public AccountUser Register(AccountUser user)
        {
            throw new NotImplementedException();
        }

        public AccountUser Validate(AccountUser user)
        {
            throw new NotImplementedException();
        }

        //...
    }
}
