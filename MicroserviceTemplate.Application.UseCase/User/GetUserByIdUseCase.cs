using MicroserviceTemplate.Domain.Contract;


namespace MicroserviceTemplate.Application.UseCase;

public class GetUserByIdUseCase
{

    private IUserService _userService;

    public GetUserByIdUseCase(IUserService userService) {

        _userService = userService;
    }

}
