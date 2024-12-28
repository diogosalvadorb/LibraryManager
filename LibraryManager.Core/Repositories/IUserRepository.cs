using LibraryManager.Core.Entities;

namespace LibraryManager.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(int id);
        Task AddAsync(User book);
    }
}
