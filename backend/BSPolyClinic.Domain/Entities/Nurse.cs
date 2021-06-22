using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Domain.Entities
{
    [Table("Nurses")]
    public class Nurse : Entity
    {
        public Nurse() { }

        public Nurse(string code, string crm, User user)
        {
            Code = code;
            Crm = crm;
            UserId = user.Id;
        }

        public int NurseId { get; private set; }
        public string Code { get; private set; }
        public string Crm { get; private set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public ICollection<HealthCenterNurse> HealthCenterNurses { get; set; }

        public void AlterCode(string code)
        {
            Code = code;
        }

        public void AlterCrm(string crm)
        {
            Crm = crm;
        }
    }
}
