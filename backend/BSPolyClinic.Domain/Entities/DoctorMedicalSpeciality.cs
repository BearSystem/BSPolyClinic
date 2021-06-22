using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Domain.Entities
{
    public class DoctorMedicalSpeciality : Entity
    {
        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public Guid MedicalSpecialityId { get; set; }
        public MedicalSpeciality MedicalSpeciality { get; set; }
    }
}
