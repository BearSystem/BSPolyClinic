using BSPolyClinic.Domain.Entities.Users;
using BSPolyClinic.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Infra.Repositories
{
    public class JobRepository : GenericRepository<Job>, IJob
    {
        public IQueryable<Job> FiltrarFuncoes(string nameJob)
        {
            throw new NotImplementedException();
        }
    }
}
