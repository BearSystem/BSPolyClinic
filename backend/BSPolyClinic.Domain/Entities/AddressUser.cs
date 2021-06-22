using BSPolyClinic.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Domain.Entities
{
    public class AddressUser : Address
    {
        public AddressUser(string street, string number, string complement, string district, string city, string state, string country, string zipCode, string description, EAddressType type) : base(street, number, complement, district, city, state, country, zipCode, description, type)
        {
        }

        public int AddressUserId { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

    }
}
