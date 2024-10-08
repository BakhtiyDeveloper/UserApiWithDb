using UserApiWithDb.Models.Users;

namespace UserApiWithDb.Servises.Users
{
    public interface IUserService
    {
        ValueTask<User> AddUserAsync(User user);
        ValueTask<IQueryable<User>> RetvieveAllUserAsync(); 
        ValueTask<User> UpdateUserAsync(User user);
        ValueTask<User> DeleteUserAsync(User user);
    }
}