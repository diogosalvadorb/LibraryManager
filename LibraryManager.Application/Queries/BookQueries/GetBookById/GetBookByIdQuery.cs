using LibraryManager.Application.ViewModels;
using MediatR;

namespace LibraryManager.Application.Queries.BookQueries.GetBookById
{
    public class GetBookByIdQuery : IRequest<BookViewModel>
    {
        public GetBookByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
