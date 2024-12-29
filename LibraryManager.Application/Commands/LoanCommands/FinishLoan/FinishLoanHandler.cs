using LibraryManager.Core.Repositories;
using MediatR;

namespace LibraryManager.Application.Commands.LoanCommands.FinishLoan
{
    public class FinishLoanHandler : IRequestHandler<FinishLoanCommand, Unit>
    {
        private readonly ILoanRepository _repository;
        public FinishLoanHandler(ILoanRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(FinishLoanCommand request, CancellationToken cancellationToken)
        {
            var loancompleted = await _repository.GetByIdAsync(request.Id);

            if (loancompleted == null)
                throw new ArgumentNullException("Nenhum empréstimo encontrado");

            loancompleted.ConfirmReturn();

            if (loancompleted.DueDate < DateTime.Now)
            {
                var daysLate = (DateTime.Now.Date - loancompleted.DueDate.Date).Days;
                Console.WriteLine($"Empréstimo devolvido com {daysLate} dias de atraso.");
            }

            await _repository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
