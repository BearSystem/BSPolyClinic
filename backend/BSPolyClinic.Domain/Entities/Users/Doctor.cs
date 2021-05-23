using BSPolyClinic.Domain.Enums;
using BSPolyClinic.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSPolyClinic.Domain.Entities.Users
{
    public class Doctor : Entity
    {
        public Guid UserId { get; private set; }
        public Guid HealthCenterId { get; private set; }
        public string Crm { get; private set; }
        public EMedicalSpeciality Speciality { get; private set; }
    }
}
