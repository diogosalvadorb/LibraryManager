using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.Core.Entities;
using LibraryManager.Core.Repositories;

namespace LibraryManager.Infrastructure.Persistence.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        public Task AddAsync(Loan loan)
        {
            throw new NotImplementedException();
        }

        public Task<Loan> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
