using System;
using System.Runtime.Serialization;

using System.Collections.Generic;

namespace MicroserviceTemplate.Application.Exceptions {

    [Serializable]
    public class EntityNotFoundException: Exception
    {
        public EntityNotFoundException() : base("The entity is not found.") { }
        public EntityNotFoundException(string entityName, string searchData) : base($"The {entityName} is not found with {searchData}.") { }
        protected EntityNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }

}

