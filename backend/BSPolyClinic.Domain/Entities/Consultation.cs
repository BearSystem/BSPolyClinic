using BSPolyClinic.Domain.Entities.Users;
using BSPolyClinic.Domain.Enums;
using BSPolyClinic.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSPolyClinic.Domain.Entities
{
    public class Consultation : Entity
    {
        public Consultation(Guid doctorId, Guid healthCenterId, bool active)
        {
            DoctorId = doctorId;
            HealthCenterId = healthCenterId;
            Active = active;
        }

        public Guid DoctorId { get; private set; }
        public Doctor Doctor { get; private set; }

        public Guid SpecialityId { get; private set; }
        public MedicalSpeciality Speciality { get; private set; }

        public Guid HealthCenterId { get; private set; }
        public HealthCenter HealthCenter { get; private set; }

        public Guid ConsultationDateId { get; private set; }
        public IEnumerable<ConsultationDate> ConsultationDate { get; set; }




        public string Description { get; private set; }
        public string Observation { get; private set; }
        public bool Active { get; private set; }

        public void ActivateConultation()
        {
            if (Active)
            {
                Active = false;
            }
            else
            {
                Active = true;
            }
        }

        public void IncludeDescription(string description)
        {
            Description = description;
        }

        public void IncludeNote(string observation)
        {
            Observation = observation;
        }
    }
}
