using MicroserviceTemplate.Infrastructure;
using MicroserviceTemplate.Application.Contract;


namespace MicroserviceTemplate.API;
public static class ServiceRegistration
{
    public static void Register(IServiceCollection services)
    {
        
        services.AddScoped<IUserRepository, UserRepository>();
    }

}