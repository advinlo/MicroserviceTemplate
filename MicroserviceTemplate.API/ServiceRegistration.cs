using MicroserviceTemplate.Domain.Contract;
using MicroserviceTemplate.Domain.Service;


namespace MicroserviceTemplate.API;
public static class ServiceRegistration
{
    public static void Register(IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();  
    }

}