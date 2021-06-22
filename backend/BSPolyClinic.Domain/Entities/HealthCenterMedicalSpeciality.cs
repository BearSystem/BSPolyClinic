using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Domain.Entities
{
    public class HealthCenterMedicalSpeciality : Entity
    {
        public Guid HealthCenterId { get; set; }
        public HealthCenter HealthCenter { get; set; }

        public Guid MedicalSpecialityId { get; set; }
        public MedicalSpeciality MedicalSpeciality { get; set; }
    }
}
