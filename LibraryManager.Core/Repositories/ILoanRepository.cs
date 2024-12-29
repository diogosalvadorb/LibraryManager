using LibraryManager.Core.Entities;

namespace LibraryManager.Core.Repositories
{
    public interface ILoanRepository
    {
        Task<Loan> GetByIdAsync(int id);
        Task AddAsync(Loan loan);
        Task SaveChangesAsync();
    }
}
