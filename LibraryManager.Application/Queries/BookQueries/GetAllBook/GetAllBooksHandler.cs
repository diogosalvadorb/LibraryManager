using LibraryManager.Application.ViewModels;
using LibraryManager.Core.Repositories;
using MediatR;

namespace LibraryManager.Application.Queries.BookQueries.GetAllBook
{
    public class GetAllBooksHandler : IRequestHandler<GetAllBooksQuery, List<BookViewModel>>
    {
        private readonly IBookRepository _repository;
        public GetAllBooksHandler(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<BookViewModel>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            var books = await _repository.GetAllAsync();

            return books
                .Select(x => new BookViewModel(x.Title, x.Author, x.Isbn, x.PublicationYear)).ToList();
        }
    }
}
