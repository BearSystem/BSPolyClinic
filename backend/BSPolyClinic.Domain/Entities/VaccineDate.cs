using BSPolyClinic.Domain.Entities.Users;
using BSPolyClinic.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSPolyClinic.Domain.Entities
{
    public class VaccineDate : Entity
    {
        public VaccineDate(Guid vaccinesId, DateTime vaccinationDate, string hour)
        {
            VaccinesId = vaccinesId;
            VaccinationDate = vaccinationDate;
            Hour = hour;
            Checked = false;
        }

        public Guid VaccinesId { get; private set; }
        public Guid HealthCenterId { get; private set; }
        public string PatientId { get; private set; }
        public DateTime VaccinationDate { get; private set; }
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
