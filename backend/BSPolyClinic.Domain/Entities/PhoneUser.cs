using BSPolyClinic.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Domain.Entities
{
    public class PhoneUser : Phone
    {
        public PhoneUser(string number, EPhoneType type) : base(number, type)
        {
        }

        public int PhoneUserId { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
