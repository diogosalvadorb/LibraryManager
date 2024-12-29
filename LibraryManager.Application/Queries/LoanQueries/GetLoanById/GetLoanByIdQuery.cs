using LibraryManager.Application.ViewModels;
using MediatR;

namespace LibraryManager.Application.Queries.LoanQueries.GetLoanById
{
    public class GetLoanByIdQuery : IRequest<LoanViewModel>
    {
        public GetLoanByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
