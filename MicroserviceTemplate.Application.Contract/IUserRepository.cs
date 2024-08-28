using MicroserviceTemplate.Domain.Entities;

namespace MicroserviceTemplate.Application.Contract;

public interface IUserRepository
{
    Task<User?> GetById(Guid id);
    Task<User?> GetByEmail(string emailAddress);
}
