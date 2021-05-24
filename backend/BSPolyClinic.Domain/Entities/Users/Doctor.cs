using BSPolyClinic.Domain.Enums;
using BSPolyClinic.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSPolyClinic.Domain.Entities.Users
{
    public class Doctor : Entity
    {
        public Doctor(Guid userId, Guid healthCenterId, string crm, EMedicalSpeciality speciality)
        {
            UserId = userId;
            HealthCenterId = healthCenterId;
            Crm = crm;
            Speciality = speciality;
        }

        public Guid UserId { get; private set; }
        public Guid HealthCenterId { get; private set; }
        public string Crm { get; private set; }
        public EMedicalSpeciality Speciality { get; private set; }

        public void AlterCrm(string crm)
        {
            Crm = crm;
        }

        public void AlterSpeciality(EMedicalSpeciality eMedicalSpeciality)
        {
            Speciality = eMedicalSpeciality;
        }
    }
}
