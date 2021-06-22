using BSPolyClinic.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Domain.Entities
{
    public class AddressHealthCenter : Address
    {
        public AddressHealthCenter(string street, string number, string complement, string district, string city, string state, string country, string zipCode, string description, EAddressType type) : base(street, number, complement, district, city, state, country, zipCode, description, type)
        {
        }

        public int AddressHealthCenterId { get; set; }
        public int HealthCenterId { get; set; }
        public HealthCenter HealthCenter { get; set; }


    }
}
