using MicroserviceTemplate.Domain.Entities;
namespace MicroserviceTemplate.Infrastructure.Contract;

public interface IUserRepository
{
    User GetById(Guid id);
}
