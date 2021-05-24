using BSPolyClinic.Domain.Entities.Users;
using BSPolyClinic.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSPolyClinic.Domain.Entities
{
    public class ConsultationDate : Entity
    {
        public ConsultationDate(Guid consultationId, Guid healthCenterId, DateTime consultationDay, string hour)
        {
            ConsultationId = consultationId;
            ConsultationDay = consultationDay;
            HealthCenterId = healthCenterId;
            Hour = hour;
            Checked = false;
        }

        public Guid ConsultationId { get; private set; }
        public Guid HealthCenterId { get; private set; }
        public string PatientId { get; private set; }
        public DateTime ConsultationDay { get; private set; }
        public string Hour { get; private set; }
        public bool Checked { get; private set; }
       

        public void MakingAnAppointment(User patient)
        {
            PatientId = patient.Id;
            Checked = true;
        }

        public void ClearConsultation()
        {

            if(ConsultationDay >= DateTime.Now)
                PatientId = "";
                Checked = false;

        }
    }
}
