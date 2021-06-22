using BSPolyClinic.Domain.Entities;
using BSPolyClinic.Infra;
using BSPolyClinic.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Infra.Repositories
{
    public class PhoneUserRepository : GenericRepository<PhoneUser>, IPhoneUser
    {
        public PhoneUserRepository(Context context) : base(context)
        {
        }
    }
}
