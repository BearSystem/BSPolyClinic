using BSPolyClinic.Domain.Entities.Users;
using BSPolyClinic.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSPolyClinic.Domain.Entities
{
    public class VaccineDate : Entity
    {

        private readonly IList<HealthCenter> _healthCenter;

        public VaccineDate()
        {

        }
        public VaccineDate(Guid vaccinesId, DateTime vaccinationDate, string hour)
        {
            VaccinesId = vaccinesId;
            VaccinationDate = vaccinationDate;
            Hour = hour;
            Checked = false;
            _healthCenter = new List<HealthCenter>();
        }

        public Guid VaccinesId { get; private set; }
        public Vaccine Vaccine { get; private set; }

        public Guid HealthCenterId { get; private set; }
        public HealthCenter HealthCenter { get; private set; }

        public string PatientId { get; private set; }
        public Patient Patient { get; private set; }
        public DateTime VaccinationDate { get; private set; }
        public string Description { get; private set; }
        public string Observation { get; private set; }
        public string Hour { get; private set; }
        public bool Checked { get; private set; }

        public void MakingAnAppointment(User patient)
        {
            PatientId = patient.Id;
            Checked = true;
        }

        public void ClearConsultation()
        {
            PatientId = "";
            Checked = false;
        }
    }
}
