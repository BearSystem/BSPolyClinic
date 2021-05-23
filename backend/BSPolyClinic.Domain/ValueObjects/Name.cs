using BSPolyClinic.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSPolyClinic.Domain.ValueObjects
{
    public class Name
    {
        public string FistNameName { get; private set; }
        public string LastName { get; private set; }
        public string NickName { get; private set; }
    }
}
