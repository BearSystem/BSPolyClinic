using BSPolyClinic.Domain.Enums;
using BSPolyClinic.Domain.ValueObjects;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Domain.Entities
{
    [Table("Users")]
    public class User : IdentityUser<string>
    {
        public User() { }

        public User(Name name, Document document, Email email, EUserType userType)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Document = document;
            Emails = email;
            UserType = userType;
        }
        public Name Name { get; private set; }
        public Email Emails { get; private set; }
        public Document Document { get; private set; }
        public EUserType UserType { get; private set; }
        public byte[] Foto { get; set; }
        public ICollection<Phone> Phones { get; set; }
        public ICollection<Address> Addresses { get; set; }

        [NotMapped]
        public string Crm { get; set; }

        public void AlterDocument(Document document)
        {
            Document = document;
        }

        public void AlterUserType(EUserType eUserType)
        {
            UserType = eUserType;
        }

        public void AddEmails(Email email)
        {
            Emails = email;
        }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
