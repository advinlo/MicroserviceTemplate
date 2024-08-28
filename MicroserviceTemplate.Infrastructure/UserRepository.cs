using MicroserviceTemplate.Domain.Entities;
using MicroserviceTemplate.Application.Contract;
using MicroserviceTemplate.Infrastructure;
using Microsoft.EntityFrameworkCore;


namespace MicroserviceTemplate.Infrastructure;

public class UserRepository : IUserRepository
{
    private readonly DataContext _dbContext;

    public UserRepository(DataContext dbContext){
        _dbContext = dbContext;
    }

    public async Task<User?> GetById(Guid id) 
    {
        return await _dbContext.Set<User>()
            .FirstOrDefaultAsync(u => u.Id == id);
    }

    public async Task<User?> GetByEmail(string emailAddress) 
    {
        return await _dbContext.Set<User>()
            .FirstOrDefaultAsync(u => u.EmailAddress == emailAddress); 
    }
}
