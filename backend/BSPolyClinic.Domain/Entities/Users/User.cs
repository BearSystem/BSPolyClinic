using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using BSPolyClinic.Domain.ValueObjects;
using BSPolyClinic.Domain.Enums;
using System.Linq;

namespace BSPolyClinic.Domain.Entities.Users
{
    public class User : IdentityUser<string>
    {

        private readonly IList<Address> _addresses;

        public Name Name { get; private set; }
        public Phone Phones { get; private set; }
        public Email Emails { get; private set; }
        public Document Document { get; private set; }
        public EUserType UserType { get; private set; }

        public IReadOnlyCollection<Address> Addresses => _addresses.ToArray();

        public void AddAddress(Address address)
        {
            _addresses.Add(address);
        }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
