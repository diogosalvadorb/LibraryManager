using LibraryManager.Core.Entities;
using LibraryManager.Core.Repositories;
using MediatR;

namespace LibraryManager.Application.Commands.BookCommands.CreateBook
{
    public class CreateBookHandler : IRequestHandler<CreateBookCommand, int>
    {
        private readonly IBookRepository _repository;
        public CreateBookHandler(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Book(request.Title, request.Author, request.Isbn, request.PublicationYear);

            await _repository.AddAsync(book);

            return book.Id;
        }
    }
}
