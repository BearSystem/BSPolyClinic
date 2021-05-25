using BSPolyClinic.Domain.Entities.Users;
using BSPolyClinic.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Domain.Entities
{
    public class MedicalSpeciality : Entity
    {
        public MedicalSpeciality(string title)
        {
            Title = title;
            Active = true;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Observation { get; private set; }
        public bool Active { get; private set; }

        public Doctor Doctor { get; set; }
        public HealthCenter HealthCenter { get; set; }


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
