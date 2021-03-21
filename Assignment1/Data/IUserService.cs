using Models;

namespace Assignment1.Data
{
    public interface IUserService
    {
        Account ValidateUser(string username, string password);
    }
}
    
    