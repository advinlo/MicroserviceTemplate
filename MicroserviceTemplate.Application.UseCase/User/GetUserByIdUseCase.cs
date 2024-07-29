using MediatR;
using MicroserviceTemplate.Application.DTOs;
using MicroserviceTemplate.Application.Queries;
using MicroserviceTemplate.Application.Exceptions;

using MicroserviceTemplate.Domain.Contract;
using MicroserviceTemplate.Domain.Entities;


namespace MicroserviceTemplate.Application.UseCase;

public class GetUserByIdUseCase : IRequestHandler<GetUserQuery, UserDto>
{

    private IUserService _userService;

    public GetUserByIdUseCase(IUserService userService) {

        _userService = userService;
    }
    
    public async Task<UserDto> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _userService.Get(request.Id);
            var userDto = new UserDto 
            {
                  Id = user.Id,
                  Username = user.Username,
                  EmailAddress = user.EmailAddress,
                  RegistrationDate = user.RegistrationDate
            };

             if (user == null)
                 throw new EntityNotFoundException("User", request.Id.ToString());
                     

            return userDto;
        }
}
