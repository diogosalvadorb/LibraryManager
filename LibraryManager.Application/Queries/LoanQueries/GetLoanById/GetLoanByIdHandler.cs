using LibraryManager.Application.ViewModels;
using LibraryManager.Core.Repositories;
using MediatR;

namespace LibraryManager.Application.Queries.LoanQueries.GetLoanById
{
    public class GetLoanByIdHandler : IRequestHandler<GetLoanByIdQuery, LoanViewModel>
    {
        private readonly ILoanRepository _repository;
        public GetLoanByIdHandler(ILoanRepository repository)
        {
            _repository = repository;
        }

        public async Task<LoanViewModel> Handle(GetLoanByIdQuery request, CancellationToken cancellationToken)
        {
            var loan = await _repository.GetByIdAsync(request.Id);

            if (loan == null) return null;

            return new LoanViewModel(loan.BookId, loan.UserId, loan.LoanDate, loan.ReturnDate, loan.DueDate);
        }
    }
}
