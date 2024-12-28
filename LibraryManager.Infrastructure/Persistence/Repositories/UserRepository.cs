using LibraryManager.Core.Entities;
using LibraryManager.Core.Repositories;

namespace LibraryManager.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task AddAsync(User book)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
