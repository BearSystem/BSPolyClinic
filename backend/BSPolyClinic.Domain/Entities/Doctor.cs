using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Domain.Entities
{
    [Table("Doctors")]
    public class Doctor : Entity
    {
        public Doctor() { }

        public Doctor(string code, string crm)
        {
            Code = code;
            Crm = crm;
        }

        public string Code { get; private set; }
        public string Crm { get; private set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public ICollection<DoctorMedicalSpeciality> DoctorMedicalSpecialities { get; set; }
        public ICollection<DoctorHealthCenter> DoctorHealthCenters { get; set; }

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
