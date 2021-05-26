using BSPolyClinic.Domain.ValueObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace BSPolyClinic.Domain.Enums
{
    public enum EUserType : Int64
    {
        Patient = 0,
        Attendant = 1,
        Nurse = 2,
        Doctor = 3,
        Manager = 4,
        Administrator = 5
    }
}
