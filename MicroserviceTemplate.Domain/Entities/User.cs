using System.Collections.Generic;

namespace MicroserviceTemplate.Domain.Entities {

    public class User
    {
        public Guid? id { get; set; }
        public string? Username { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string? Password { get; set; }
        public bool IsActive { get; set; } = true;        
        public DateTime? LastLogin { get; set; }
        public string ProfilePicture { get; set; }
        public string Bio { get; set; }
        public string Address { get; set; }

    }

}

