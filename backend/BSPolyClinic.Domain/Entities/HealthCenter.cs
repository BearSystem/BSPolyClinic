using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Domain.Entities
{
    [Table("HealthCenters")]
    public class HealthCenter : Entity
    {
        public HealthCenter()
        {

        }

        public HealthCenter(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Observation { get; private set; }

        public Guid AddressId { get; set; }
        public Address Addresses { get; set; }

        public ICollection<Phone> Phones { get; set; }
        public ICollection<HealthCenterMedicalSpeciality> HealthCenterMedicalSpecialities { get; set; }
        public ICollection<DoctorHealthCenter> DoctorHealthCenter { get; set; }
        public ICollection<HealthCenterNurse> HealthCenterNurses { get; set; }

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
