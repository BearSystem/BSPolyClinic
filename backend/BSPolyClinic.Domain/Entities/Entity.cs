using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Domain.Entities
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
