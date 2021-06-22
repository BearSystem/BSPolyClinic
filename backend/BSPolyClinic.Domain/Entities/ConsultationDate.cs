using BSPolyClinic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSPolyClinic.Domain.Entities
{
    public class ConsultationDate : Entity
    {
        public ConsultationDate(DateTime consultationDay, string hour)
        {
            ConsultationDay = consultationDay;
            Hour = hour;
            Checked = false;
        }

        public int ConsultationDateId { get; private set; }
        public DateTime ConsultationDay { get; private set; }
        public string Description { get; private set; }
        public string Observation { get; private set; }
        public string Hour { get; private set; }
        public bool Checked { get; private set; }



        public Guid ConsultationId { get; private set; }
        public Consultation Consultation { get; private set; }
        public Guid PatientId { get; private set; }
        public Patient Patient { get; private set; }



        public void MakingAnAppointment(Patient patient)
        {
            Patient = patient;
            Checked = true;
        }

        public void ClearConsultation()
        {
            if(ConsultationDay >= DateTime.Now)
                Patient = new Patient();
                Checked = false;
        }
    }
}
