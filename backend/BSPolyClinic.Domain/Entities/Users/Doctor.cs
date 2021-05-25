using BSPolyClinic.Domain.Enums;
using BSPolyClinic.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSPolyClinic.Domain.Entities.Users
{
    public class Doctor : Entity
    {
        private readonly IList<MedicalSpeciality> _speciality;

        public Doctor(Guid userId, Guid healthCenterId, string crm)
        {
            UserId = userId;
            HealthCenterId = healthCenterId;
            Crm = crm;
        }

        public Guid UserId { get; private set; }
        public Guid HealthCenterId { get; private set; }
        public string Crm { get; private set; }

        public IReadOnlyCollection<MedicalSpeciality> Speciality => _speciality.ToArray();

        public void AlterCrm(string crm)
        {
            Crm = crm;
        }

    }
}
