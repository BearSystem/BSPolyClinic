using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Domain.Entities
{
    [Table("Attendants")]
    public class Attendant : Entity
    {
        public Attendant()
        {

        }

        public Attendant(string code)
        {
            Code = code;
        }

        public string Code { get; private set; }
        
        public string UserId { get; set; }
        public User User { get; set; }

        public void AlterCode(string code)
        {
            Code = code;
        }
    }
}
