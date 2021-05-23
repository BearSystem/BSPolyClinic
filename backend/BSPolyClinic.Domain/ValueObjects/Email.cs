using System;
using System.Collections.Generic;
using System.Text;

namespace BSPolyClinic.Domain.ValueObjects
{
    public class Email
    {

        public string PrimaryEmail { get; private set; }
        public string SecundaryEmail { get; private set; }
    }
}
