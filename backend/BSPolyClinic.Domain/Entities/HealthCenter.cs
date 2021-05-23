using BSPolyClinic.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSPolyClinic.Domain.Entities
{
    public class HealthCenter : Entity
    {
        public HealthCenter(string title, Phone phone, Address address)
        {
            Title = title;
            Phone = phone;
            Address = address;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Observation { get; private set; }
        public Phone Phone { get; private set; }
        public Address Address { get; private set; }

        public void IncludeDescription(string description)
        {
            Description = description;
        }

        public void IncludeNote(string observation)
        {
            Observation = observation;
        }
    }
}
