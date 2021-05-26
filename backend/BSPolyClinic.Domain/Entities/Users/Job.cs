using BSPolyClinic.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSPolyClinic.Domain.Entities.Users
{
    public class Job : IdentityRole<string>
    {
        public string Description { get; set; }
    }
}
