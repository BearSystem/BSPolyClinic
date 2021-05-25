using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSPolyClinic.Api.Security
{
    public class Settings
    {
        public static string ChaveSecreta = Guid.NewGuid().ToString();
    }
}
