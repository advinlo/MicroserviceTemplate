using MediatR;
using MicroserviceTemplate.Application.DTOs;
using System.Collections.Generic;

namespace MicroserviceTemplate.Application.Request.Queries {

    public class GetUserQuery : IRequest<UserDto>
    {
        public Guid Id { get; }

        public GetUserQuery(Guid id) 
        {
            Id = id;
        }
      

    }

}

