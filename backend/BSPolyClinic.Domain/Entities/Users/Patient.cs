using BSPolyClinic.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSPolyClinic.Domain.Entities.Users
{
    public class Patient : Entity
    {
        private readonly IList<HealthCenter> _healthCenter;
        public Patient(string userId, string code)
        {
            UserId = userId;
            Code = code;
            _healthCenter = new List<HealthCenter>();
        }

        public string UserId { get; private set; }
        public User User { get; private set; }

        public Guid VaccineDateId { get; private set; }
        public IEnumerable<VaccineDate> VaccineDate { get; set; }


        public Guid ConsultationDateId { get; private set; }
        public IEnumerable<ConsultationDate> ConsultationDate { get; set; }



        public IReadOnlyCollection<HealthCenter> HealthCenter => _healthCenter.ToArray();

        public string Code { get; private set; }
    }
}
