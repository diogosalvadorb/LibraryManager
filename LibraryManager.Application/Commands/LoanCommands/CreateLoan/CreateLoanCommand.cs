using MediatR;

namespace LibraryManager.Application.Commands.LoanCommands.CreateLoan
{
    public class CreateLoanCommand : IRequest<int>
    {
        public CreateLoanCommand(int bookId, int userId)
        {
            BookId = bookId;
            UserId = userId;
        }

        public int BookId { get; set; }
        public int UserId { get; set; }
    }
}
