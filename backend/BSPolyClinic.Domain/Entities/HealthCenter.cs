using BSPolyClinic.Domain.Entities.Users;
using BSPolyClinic.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSPolyClinic.Domain.Entities
{
    public class HealthCenter : Entity
    {
        public HealthCenter(string title)
        {
            Title = title;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Observation { get; private set; }


        public Guid PhoneId { get; private set; }
        public Phone Phone { get; private set; }


        public Guid AddressId { get; private set; }
        public Address Address { get; private set; }


        public Guid ConsultationId { get; private set; }
        public Consultation Consultation { get; private set; }

        public Guid DoctorId { get; private set; }
        public Doctor Doctor { get; private set; }

        public Guid AttendantId { get; private set; }
        public Attendant Attendant { get; private set; }

        public Guid PatientId { get; private set; }
        public Patient Patient { get; private set; }

        public Guid NurseId { get; private set; }
        public Nurse Nurse { get; private set; }

        public Guid ManagerId { get; private set; }
        public Manager Manager { get; private set; }

        public Guid ConsultationDateId { get; private set; }
        public IEnumerable<ConsultationDate> ConsultationDate { get; set; }

        public Guid VaccineId { get; private set; }
        public IEnumerable<Vaccine> Vaccine { get; set; }

        public Guid VaccineDateId { get; private set; }
        public IEnumerable<VaccineDate> VaccineDate { get; set; }

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
