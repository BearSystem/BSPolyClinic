using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Domain.Entities
{
    public class DoctorHealthCenter : Entity
    {
        public int DoctorHealthCenterId { get; private set; }
        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public Guid HealthCenterId { get; set; }
        public HealthCenter HealthCenter { get; set; }
    }
}
