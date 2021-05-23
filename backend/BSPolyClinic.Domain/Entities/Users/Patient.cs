using BSPolyClinic.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSPolyClinic.Domain.Entities.Users
{
    public class Patient : Entity
    {
        public Guid UserId { get; private set; }
        public Guid HealthCenterId { get; private set; }
        public string Codigo { get; private set; }
    }
}
