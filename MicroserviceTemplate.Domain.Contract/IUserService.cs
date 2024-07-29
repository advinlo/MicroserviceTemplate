using MicroserviceTemplate.Domain.Entities;

namespace MicroserviceTemplate.Domain.Contract;

public interface IUserService
{
    Task<User> Get(Guid id);
}
