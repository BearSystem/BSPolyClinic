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
        private readonly IList<Phone> _phones;

        public User()
        {
        }

        public User(Name name,Document document,Email email, EUserType userType)
        {
            Name = name;
            Document = document;
            Emails = email;
            UserType = userType;
            _addresses = new List<Address>();
            _phones = new List<Phone>();
        }

        public Name Name { get; private set; }
        public Email Emails { get; private set; }
        public Document Document { get; private set; }
        public EUserType UserType { get; private set; }
        public byte[] Foto { get; set; }

        public Administrator Administrator { get; private set; }
        public Attendant Attendant { get; private set; }
        public Manager Manager { get; private set; }

        public Patient Patient { get; set; }

        public Doctor Doctor { get; private set; }

        public Nurse Nurse { get; private set; }


        public IReadOnlyCollection<Phone> Phones => _phones.ToArray();
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
        
        public void AddEmails(Email email)
        {
            Emails = email;
        }

        public void AddPhones(Phone phone)
        {
            _phones.Add(phone);
        }


        public override string ToString()
        {
            return Name.ToString();
        }

    }
}
