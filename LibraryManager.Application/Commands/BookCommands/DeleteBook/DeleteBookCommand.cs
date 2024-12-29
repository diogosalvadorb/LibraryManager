using MediatR;

namespace LibraryManager.Application.Commands.BookCommands.DeleteBook
{
    public class DeleteBookCommand : IRequest<Unit>
    {
        public DeleteBookCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
