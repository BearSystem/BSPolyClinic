using BSPolyClinic.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSPolyClinic.Domain.Entities.Users
{
    public class Administrator : Entity
    {
        public Administrator(string userId)
        {
            UserId = userId;
        }

        public User User { get; private set; }
        public string UserId { get; private set; }
        public string Codigo { get; private set; }
    }
}
