using MicroserviceTemplate.Domain.Contract;
using MicroserviceTemplate.Domain.Service;
using MicroserviceTemplate.Infrastructure;
using MicroserviceTemplate.Infrastructure.Contract;


namespace MicroserviceTemplate.API;
public static class ServiceRegistration
{
    public static void Register(IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
        
        services.AddScoped<IUserRepository, UserRepository>();
    }

}