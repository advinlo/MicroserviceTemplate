using MicroserviceTemplate.Domain.Entities;

namespace MicroserviceTemplate.Domain.Contract;

public interface IUserService
{
    User Get(Guid id);
}
