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
    public class AddressUserRepository : GenericRepository<AddressUser>, IAddressUser
    {
        public AddressUserRepository(Context context) : base(context)
        {
        }
    }
}
