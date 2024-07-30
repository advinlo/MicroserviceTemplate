using AutoMapper;
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
    private readonly IMapper _mapper;

    public GetUserByIdUseCase(IUserService userService, IMapper mapper) {

        _userService = userService;
        _mapper = mapper;
    }
    
    public async Task<UserDto> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        
        var userDto = _mapper.Map<User,UserDto>(await _userService.Get(request.Id));

            if (userDto == null)
                throw new EntityNotFoundException("User", request.Id.ToString());
                    

        return userDto;
    }
}
