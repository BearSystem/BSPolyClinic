using BSPolyClinic.Domain.Entities.Users;
using BSPolyClinic.Domain.Enums;
using BSPolyClinic.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSPolyClinic.Domain.Entities
{
    public class Address : Entity
    {
        public Address(string street, string number, string complement, string district, string city, string state, string country, string zipCode, EAddressType type)
        {
            Street = street;
            Number = number;
            Complement = complement;
            District = district;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;
            Type = type;
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Complement { get; private set; }
        public string District { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
        public string Description { get; private set; }
        public EAddressType Type { get; private set; }


        public Guid HealthCenterId { get; set; }
        public IEnumerable<HealthCenter> HealthCenter { get; set; }
        public string UserId { get; set; }
        public IEnumerable<User> User { get; set; }


        public void InsertDescription(string description)
        {
            Description = description;
        }

        public void AlterAddressType(EAddressType eAddressType)
        {
            Type = eAddressType;
        }

        public override string ToString()
        {
            return $"{Street}, {Number} - {City}/{State}";
        }
    }
}
