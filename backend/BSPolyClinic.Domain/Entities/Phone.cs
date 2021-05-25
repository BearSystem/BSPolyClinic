using BSPolyClinic.Domain.Entities.Users;
using BSPolyClinic.Domain.Enums;
using BSPolyClinic.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSPolyClinic.Domain.Entities
{
    public class Phone : Entity
    {
        public Phone(string telephone, EPhoneType type)
        {
            Telephone = telephone;
            Type = type;
        }

        public string Telephone { get; private set; }
        public string Observation { get; private set; }
        public EPhoneType Type { get; private set; }


        public string UserId { get; set; }
        public IEnumerable<User> User { get; set; }


        public Guid HealthCenterId { get; set; }
        public IEnumerable<HealthCenter> HealthCenter { get; set; }

        public void IncludeNote(string observation)
        {
            Observation = observation;
        }

        public void AlterTypePhone(EPhoneType type)
        {
            Type = type;
        }
    }
}
