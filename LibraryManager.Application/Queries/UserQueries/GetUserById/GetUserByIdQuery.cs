using LibraryManager.Application.ViewModels;
using MediatR;

namespace LibraryManager.Application.Queries.UserQueries.GetUserById
{
    public class GetUserByIdQuery : IRequest<UserViewModel>
    {
        public GetUserByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
