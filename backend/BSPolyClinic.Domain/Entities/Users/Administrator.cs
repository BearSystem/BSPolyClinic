using BSPolyClinic.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSPolyClinic.Domain.Entities.Users
{
    public class Administrator : Entity
    {
        public Guid UserId { get; private set; }
        public string Codigo { get; private set; }
    }
}
