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
    public class MedicalSpecialityRepository : GenericRepository<MedicalSpeciality>, IMedicalSpeciality
    {
        public MedicalSpecialityRepository(Context context) : base(context)
        {
        }
    }
}
