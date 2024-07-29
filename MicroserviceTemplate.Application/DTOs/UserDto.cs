using System.Collections.Generic;

namespace MicroserviceTemplate.Application.DTOs {

    public class UserDto
    {
        public Guid? id { get; set; }
        public string? Username { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public DateTime? RegistrationDate { get; set; }

    }

}

