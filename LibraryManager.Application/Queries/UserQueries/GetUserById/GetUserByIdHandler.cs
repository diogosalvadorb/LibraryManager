using LibraryManager.Application.ViewModels;
using LibraryManager.Core.Repositories;
using MediatR;

namespace LibraryManager.Application.Queries.UserQueries.GetUserById
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, UserViewModel>
    {
        private readonly IUserRepository _repository;

        public GetUserByIdHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<UserViewModel> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _repository.GetByIdAsync(request.Id);

            if (user == null) return null;

            return new UserViewModel(user.FullName, user.Email);
        }
    }
}
