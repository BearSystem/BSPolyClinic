using BSPolyClinic.Domain.Entities;
using BSPolyClinic.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Infra.Repositories
{
    public class AddressHealthCenterRepository : GenericRepository<AddressHealthCenter>, IAddressHealthCenter
    {
        public AddressHealthCenterRepository(Context context) : base(context)
        {
        }
    }
}
