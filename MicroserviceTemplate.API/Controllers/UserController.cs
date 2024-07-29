using Microsoft.AspNetCore.Mvc;
using MicroserviceTemplate.Application.DTOs;

namespace MicroserviceTemplate.API.Controllers
{

    [ApiController]
    [Route("/users/api/weatherController")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        //private readonly ISender _mediator;

        public UserController(ILogger<UserController> logger){
            _logger = logger;
        }



        [HttpGet(Name = "GetUser")]
        public UserDto Get()
        {
            return new UserDto {
                id = Guid.NewGuid(),
                Username = "Advinlo",
                EmailAddress = "advinlo@advinlo.com",
                RegistrationDate = DateTime.Now            
            };
        }
    }
}
                    




