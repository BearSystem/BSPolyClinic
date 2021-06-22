using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Domain.Entities
{
    public class Entity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public void AddCreateDate()
        {
           CreatedAt = DateTime.Now.Date;
        }

        public void AddUpdatedDate()
        {
            UpdatedAt = DateTime.Now.Date;
        }
    }
}
