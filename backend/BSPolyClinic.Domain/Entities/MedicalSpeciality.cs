using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Domain.Entities
{
    [Table("MedicalSpecialties")]
    public class MedicalSpeciality : Entity
    {
        public MedicalSpeciality(string title, string description, bool active)
        {
            Title = title;
            Description = description;
            Active = active;
        }

        public string Title { get; private set; }
        public bool Active { get; private set; }
        public string Description { get; private set; }
        public string Observation { get; private set; }

        public ICollection<HealthCenterMedicalSpeciality> HealthCenterMedicalSpecialities { get; set; }
        public ICollection<DoctorMedicalSpeciality> DoctorMedicalSpecialities { get; set; }

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

        public void AlterDescription(string description)
        {
            Description = description;
        }

        public void IncludeNote(string observation)
        {
            Observation = observation;
        }
    }
}
