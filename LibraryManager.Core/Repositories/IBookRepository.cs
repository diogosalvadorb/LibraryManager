﻿using LibraryManager.Core.Entities;

namespace LibraryManager.Core.Repositories
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllAsync();
        Task<Book> GetByIdAsync(int id);
        Task AddAsync(Book book);
        Task SaveChangesAsync();
    }
}
