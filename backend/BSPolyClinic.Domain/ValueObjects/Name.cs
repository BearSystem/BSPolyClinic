using BSPolyClinic.Domain.Enums;
using BSPolyClinic.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSPolyClinic.Domain.ValueObjects
{
    public class Name : BaseVO
    {
        public Name()
        {

        }
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string NickName { get; private set; }

        public void InsertNickName(string nick)
        {
            NickName = nick;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
