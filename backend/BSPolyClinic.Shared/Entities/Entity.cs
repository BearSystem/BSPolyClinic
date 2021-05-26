using FluentValidator;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSPolyClinic.Shared.Entities
{
    public class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public void AddCreatedDate()
        {
            CreatedAt = DateTime.Now.Date;
        }

        public void AddUpdatedDate()
        {
            UpdatedAt = DateTime.Now.Date;
        }

    }
}
