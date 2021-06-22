using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BSPolyClinic.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EAddressType
    {
        Residential = 0,
        Friends = 1,
        Family = 2,
        Work = 3,
    }
}
