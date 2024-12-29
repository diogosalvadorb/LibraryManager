using MediatR;

namespace LibraryManager.Application.Commands.LoanCommands.FinishLoan
{
    public class FinishLoanCommand : IRequest<Unit>
    {
        public FinishLoanCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
