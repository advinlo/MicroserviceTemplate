using AutoMapper;
using MediatR;

using MicroserviceTemplate.Application.Contract;
using MicroserviceTemplate.Application.DTOs;
using MicroserviceTemplate.Application.Exceptions;
using MicroserviceTemplate.Application.Request.Queries;


using MicroserviceTemplate.Domain.Entities;


namespace MicroserviceTemplate.Application;

public class GetUserByIdHandler : IRequestHandler<GetUserQuery, UserDto>
{

    private IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public GetUserByIdHandler(IUserRepository userRepository, IMapper mapper) {

        _userRepository = userRepository;
        _mapper = mapper;
    }
    
    public async Task<UserDto> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        
        var userDto = _mapper.Map<User,UserDto>(await _userRepository.GetById(request.Id));

            if (userDto == null)
                throw new EntityNotFoundException("User", request.Id.ToString());
                    

        return userDto;
    }
}
