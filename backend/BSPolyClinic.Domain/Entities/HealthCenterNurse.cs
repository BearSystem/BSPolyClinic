using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Domain.Entities
{
    public class HealthCenterNurse : Entity
    {
        public Guid HealthCenterId { get; set; }
        public HealthCenter HealthCenter { get; set; }

        public Guid NurseId { get; set; }
        public Nurse Nurse { get; set; }
    }
}
