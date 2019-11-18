using Assignment.Common.Models;
using Assignment.Models;

namespace Assignment.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Response<string> Login(User item);
    }
}
