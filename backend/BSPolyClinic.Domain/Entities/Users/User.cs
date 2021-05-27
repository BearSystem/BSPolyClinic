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



        public IReadOnlyCollection<Phone> Phones => _phones.ToArray();
        public IReadOnlyCollection<Address> Addresses => _addresses.ToArray();



        public IEnumerable<Administrator> Administrator { get; set; }
        public IEnumerable<Attendant> Attendant { get; set; }
        public IEnumerable<Manager> Manager { get; set; }
        public IEnumerable<Patient> Patient { get; set; }
        public IEnumerable<Doctor> Doctor { get; set; }
        public IEnumerable<Nurse> Nurse { get; set; }




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
