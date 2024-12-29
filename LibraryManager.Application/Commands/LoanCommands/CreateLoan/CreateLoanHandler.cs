using LibraryManager.Core.Entities;
using LibraryManager.Core.Repositories;
using MediatR;

namespace LibraryManager.Application.Commands.LoanCommands.CreateLoan
{
    public class CreateLoanHandler : IRequestHandler<CreateLoanCommand, int>
    {
        private readonly ILoanRepository _repository;
        public CreateLoanHandler(ILoanRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(CreateLoanCommand request, CancellationToken cancellationToken)
        {
            var loan = new Loan(request.BookId, request.UserId);

            await _repository.AddAsync(loan);

            return loan.Id;
        }
    }
}
