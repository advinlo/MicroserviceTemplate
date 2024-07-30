using MicroserviceTemplate.Domain.Entities;
using MicroserviceTemplate.Infrastructure.Contract;

namespace MicroserviceTemplate.Infrastructure;

public class UserRepository : IUserRepository
{
    public User GetById(Guid id) 
    {
        return new User {
            Id = id,
            Username = "Advinlo",
            EmailAddress = "advinlo@advinlo.com",
            RegistrationDate = DateTime.Now
        };
    }
}
