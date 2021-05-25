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

        public User(Name name,Document document,Email email,Phone phone)
        {
            Name = name;
            Document = document;
            Emails = email;
            Phones = phone;
            _addresses = new List<Address>();
        }

        public Name Name { get; private set; }
        public Phone Phones { get; private set; }
        public Email Emails { get; private set; }
        public Document Document { get; private set; }
        public EUserType UserType { get; private set; }
        public byte[] Foto { get; set; }

        public Administrator Administrator { get; private set; }
        public Attendant Attendant { get; private set; }
        public Manager Manager { get; private set; }
        public Patient Patient { get; private set; }
        public Doctor Doctor { get; private set; }
        public Nurse Nurse { get; private set; }




        public IReadOnlyCollection<Address> Addresses => _addresses.ToArray();

        public void AlterDocument(Document document)
        {
            Document = document;
        }

        public void AlterUserType(EUserType eUserType)
        {
            UserType = eUserType;
        }

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
