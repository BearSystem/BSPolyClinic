using BSPolyClinic.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Infra.Interfaces
{
    public interface IJob : IGeneric<Job>
    {
        IQueryable<Job> FiltrarFuncoes(string nameJob);
    }
}
