using BSPolyClinic.Domain.Enums;
using BSPolyClinic.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Domain.Entities
{
    [Table("Phones")]
    public class Phone : Entity
    {
        public Phone(string number, EPhoneType type)
        {
            Number = number;
            Type = type;
        }

        public string Number { get; private set; }
        public EPhoneType Type { get; private set; }
        public string Observation { get; private set; }


        public void AlterPhone(string telephone)
        {
            Number = telephone;
        }

        public void AlterTypePhone(EPhoneType type)
        {
            Type = type;
        }
        public void IncludeNote(string observation)
        {
            Observation = observation;
        }

    }
}
