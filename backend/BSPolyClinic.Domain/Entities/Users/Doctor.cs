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
        private readonly IList<HealthCenter> _healthCenter;

        public Doctor(string userId)
        {
            UserId = userId;
            _speciality = new List<MedicalSpeciality>();
            _healthCenter = new List<HealthCenter>();
        }

        public string UserId { get; private set; }
        public User User { get; private set; }

        public IList<Consultation> Consultation { get; set; }


        public string Code { get; private set; }
        public string Crm { get; private set; }

        public IReadOnlyCollection<HealthCenter> HealthCenter => _healthCenter.ToArray();
        public IReadOnlyCollection<MedicalSpeciality> Speciality => _speciality.ToArray();

        public void AlterCrm(string crm)
        {
            Crm = crm;
        }
        
    }
}
