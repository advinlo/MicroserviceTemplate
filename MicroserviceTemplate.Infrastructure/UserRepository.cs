using MicroserviceTemplate.Domain.Entities;
using MicroserviceTemplate.Application.Contract;

namespace MicroserviceTemplate.Infrastructure;

public class UserRepository : IUserRepository
{
    public async Task<User> GetById(Guid id) 
    {
        User user = new User {
            Id = id,
            Username = "Advinlo",
            EmailAddress = "advinlo@advinlo.com",
            RegistrationDate = DateTime.Now
        };

        return user; 
    }

    public async Task<User> GetByEmail(string emailAddress) 
    {
        User user = new User {
            Id = Guid.NewGuid(),
            Username = "Advinlo",
            EmailAddress = emailAddress,
            RegistrationDate = DateTime.Now
        };

        return user; 
    }
}
