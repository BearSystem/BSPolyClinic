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
    public class DoctorMedicalSpecialityRepository : GenericRepository<DoctorMedicalSpeciality>, IDoctorMedicalSpeciality
    {
        public DoctorMedicalSpecialityRepository(Context context) : base(context)
        {
        }
    }
}
