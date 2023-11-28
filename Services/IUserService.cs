using Streamberry.Models;

namespace Streamberry.Services
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}
