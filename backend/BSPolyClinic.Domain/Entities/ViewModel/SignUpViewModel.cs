using BSPolyClinic.Domain.Entities.Users;
using BSPolyClinic.Domain.Enums;
using BSPolyClinic.Domain.ValueObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Domain.Entities.ViewModel
{
    public class SignUpViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public byte[] Foto { get; set; }

        public string Password { get; set; }
        public string RepeatPassword { get; set; }

        public EUserType TypeUser { get; set; }
    }
}
