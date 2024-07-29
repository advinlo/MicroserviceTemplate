using MediatR;
using Microsoft.AspNetCore.Mvc;
using MicroserviceTemplate.Application.DTOs;
using MicroserviceTemplate.Application.Exceptions;
using MicroserviceTemplate.Application.Queries;

namespace MicroserviceTemplate.API.Controllers
{

    [ApiController]
    [Route("/users/api/userController")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly ISender _mediator;

        public UserController(ILogger<UserController> logger, ISender mediator){
            _logger = logger;
            _mediator = mediator;
        }
        

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(Guid id)
        {
            try{
                var client = await _mediator.Send(new GetUserQuery(id));
                return Ok(client);  
            }
            catch (EntityNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            
        }
    }
}
                    




