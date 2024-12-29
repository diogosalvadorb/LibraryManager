using LibraryManager.Application.ViewModels;
using MediatR;

namespace LibraryManager.Application.Queries.BookQueries.GetAllBook
{
    public class GetAllBooksQuery : IRequest<List<BookViewModel>>
    {
    }
}
