using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Domain.Entities.ViewModel
{
    public class UpdateUserViewModel
    {
        public User User { get; set; }
        public string Password { get; set; }
    }
}
