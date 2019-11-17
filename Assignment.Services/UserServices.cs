using Assigment.Common.Repository;
using Assignment.API.Common.Services;
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
