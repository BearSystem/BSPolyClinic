using BSPolyClinic.Domain.Entities.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Infra
{
    public class Context : IdentityDbContext<User, Job, string>
    {
        public Context(DbContextOptions options) : base(options)
        {
        }
    }
}
