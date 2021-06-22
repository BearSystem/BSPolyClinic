using BSPolyClinic.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Domain.Entities
{
    public class PhoneHealthCenter : Phone
    {
        public PhoneHealthCenter(string number, EPhoneType type) : base(number, type)
        {
        }
        public int PhoneHealthCenterId { get; set; }

        public int HealthCenterId { get; set; }
        public HealthCenter HealthCenter { get; set; }

    }
}
