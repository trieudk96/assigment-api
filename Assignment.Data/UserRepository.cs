using Assignment.Common.Repository;
using Assignment.Data.DbContexts;
using Assignment.Data.Interfaces;
using Assignment.Models;

namespace Assignment.Data
{
    public class UserRepository:ApplicationRepository<User>, IUserRepository
    {
        public UserRepository(UserDbContext context) : base(context)
        {

        }


    }
}
