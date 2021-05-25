using BSPolyClinic.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSPolyClinic.Domain.ValueObjects
{
    public class Email : BaseVO
    {
        public Email()
        {

        }
        public Email(string address)
        {
            Address = address;
        }

        public string Address { get; private set; }
        public string SecundaryAddress { get; private set; }

        public void InsertSecundaryEmail(string email)
        {
            SecundaryAddress = email;
        }
    }
}
