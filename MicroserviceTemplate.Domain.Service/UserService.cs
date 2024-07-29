using System.Dynamic;
using MicroserviceTemplate.Domain.Contract;
using MicroserviceTemplate.Domain.Entities;

namespace MicroserviceTemplate.Domain.Service;

public class UserService : IUserService
{
    public UserService(){

    }

    public User Get(Guid id){
        var user = new User {
            id = id,
            Username = "Advinlo",
            EmailAddress = "advinlo@advinlo.com",
            RegistrationDate = DateTime.Now
        };

        return user;
    }
}
