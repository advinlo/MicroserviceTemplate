using System.Dynamic;
using MicroserviceTemplate.Domain.Contract;
using MicroserviceTemplate.Domain.Entities;
using MicroserviceTemplate.Infrastructure.Contract;

namespace MicroserviceTemplate.Domain.Service;

public class UserService : IUserService
{
    private IUserRepository _userRepository;
    public UserService(IUserRepository userRepository){
        _userRepository = userRepository;
    }

    public async Task<User> Get(Guid id){
        
        var user = _userRepository.GetById(id);

        return user;
    }
}
