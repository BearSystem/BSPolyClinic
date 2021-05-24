using BSPolyClinic.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSPolyClinic.Domain.Entities.Users
{
    public class Job : IdentityRole<string>
    {
        public Job(string descricao, EUserType type)
        {
            Descricao = descricao;
            Type = type;
        }

        public string Descricao { get; private set; }
        public EUserType Type { get; private set; }
    }
}
