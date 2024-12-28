using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.Core.Entities;
using LibraryManager.Core.Repositories;

namespace LibraryManager.Infrastructure.Persistence.Repositories
{
    public class BookRepository : IBookRepository
    {
        public Task AddAsync(Book book)
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
