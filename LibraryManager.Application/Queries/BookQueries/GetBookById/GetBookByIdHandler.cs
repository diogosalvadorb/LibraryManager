using LibraryManager.Application.ViewModels;
using LibraryManager.Core.Repositories;
using MediatR;

namespace LibraryManager.Application.Queries.BookQueries.GetBookById
{
    public class GetBookByIdHandler : IRequestHandler<GetBookByIdQuery, BookViewModel>
    {
        private readonly IBookRepository _repository;
        public GetBookByIdHandler(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task<BookViewModel> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            var responseBook = await _repository.GetByIdAsync(request.Id);

            if (responseBook == null) return null;

            return new BookViewModel(responseBook.Title, responseBook.Author, responseBook.Isbn, responseBook.PublicationYear);
        }
    }
}
