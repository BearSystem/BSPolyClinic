using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Domain.Entities
{
    [Table("Administrators")]
    public class Administrator : Entity
    {
        public Administrator()
        {

        }
        public Administrator(string code, User user)
        {
            Code = code;
            UserId = user.Id;
        }


        public int AdministratorId { get; private set; }
        public string Code { get; private set; }
        public string UserId { get; set; }
        public User User { get; set; }

        public void AlterCode(string code)
        {
            Code = code;
        }
    }
}
