﻿using BSPolyClinic.Domain.Entities.Users;
using BSPolyClinic.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Infra.Repositories
{
    public class AdministratorRepository : GenericRepository<Administrator>, IAdministrator
    {
        private readonly Context context;
        public AdministratorRepository(Context context) : base(context)
        {
            this.context = context;
        }
    }
}
