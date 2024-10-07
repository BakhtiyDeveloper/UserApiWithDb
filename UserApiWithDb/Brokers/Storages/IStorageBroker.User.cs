using UserApiWithDb.Models.Users;

namespace UserApiWithDb.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<User> InsertUserAsync(User user);
        ValueTask<IQueryable<User>> SelectAllUserAsync();
        ValueTask<User> UptadeUserAsync(User user);
        ValueTask<User> DeleteUserAsync(User user);
    }
}
