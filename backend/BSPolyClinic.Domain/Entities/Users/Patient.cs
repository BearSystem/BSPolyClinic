using BSPolyClinic.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSPolyClinic.Domain.Entities.Users
{
    public class Patient : Entity
    {
        public Patient(Guid userId, Guid healthCenterId, string codigo)
        {
            UserId = userId;
            HealthCenterId = healthCenterId;
            Codigo = codigo;
        }

        public Guid UserId { get; private set; }
        public Guid HealthCenterId { get; private set; }
        public string Codigo { get; private set; }
    }
}
