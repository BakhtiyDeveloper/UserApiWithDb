using Microsoft.EntityFrameworkCore;
using UserApiWithDb.Models.Users;

namespace UserApiWithDb.Brokers.Storages
{
    public partial class StorageBroker
    {
        DbSet<User> Users { get; set; }
        public async ValueTask<User> InsertUserAsync(User user) => 
            await InsertUserAsync(user);

        public async ValueTask<IQueryable<User>> SelectAllUserAsync() => 
            SelectAllAsync<User>();

        public async ValueTask<User> UptadeUserAsync(User user) =>
            await UptadeUserAsync(user);
        
        public async ValueTask<User> DeleteUserAsync(User user) =>
            await DeleteUserAsync(user);        
    }
}
