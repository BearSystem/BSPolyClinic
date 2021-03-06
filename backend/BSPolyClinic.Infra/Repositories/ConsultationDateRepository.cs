using BSPolyClinic.Domain.Entities;
using BSPolyClinic.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Infra.Repositories
{
    public class ConsultationDateRepository : GenericRepository<ConsultationDate>, IConsultationDate
    {
        public ConsultationDateRepository(Context context) : base(context)
        {
        }
    }
}
