using BSPolyClinic.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSPolyClinic.Domain.Entities
{
    public class Vaccine : Entity
    {
        public Vaccine()
        {
        }

        public Vaccine(string title, int minimumAge, string description, string observations, DateTime initialDate, DateTime finalDate, bool active)
        {
            Title = title;
            MinimumAge = minimumAge;
            Description = description;
            InitialDate = initialDate;
            Active = active;
            FinalDate = finalDate;
        }

        public int VaccineId { get; private set; }
        public string Title { get; private set; }
        public int MinimumAge { get; private set; }
        public string Description { get; private set; }
        public string Observation { get; private set; }
        public bool Active { get; private set; }
        public DateTime InitialDate { get; private set; }
        public DateTime FinalDate { get; private set; }

        public IList<VaccineDate> VaccineDate { get; set; }

        public Guid HealthCenterId { get; private set; }
        public HealthCenter HealthCenter { get; private set; }

        public void ActivateVaccine()
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

        public void IncludeNote(string observation)
        {
            Observation = observation;
        }
    }
}
