using Assignment.API.Common.Services;
using Assignment.Common.Repository;
using Assignment.Models;

namespace Assignment.Services
{
    public class UserServices : ApplicationService<User>,IUserServices
    {
        public UserServices(IRepository<User> repository) : base(repository)
        {
        }
    }
}
