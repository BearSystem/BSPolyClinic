using System;
using System.Collections.Generic;
using System.Text;

namespace BSPolyClinic.Domain.ValueObjects
{
    public class Document
    {
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public string NumberSUS { get; private set; }
    }
}
