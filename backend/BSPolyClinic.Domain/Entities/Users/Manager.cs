using BSPolyClinic.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSPolyClinic.Domain.Entities.Users
{
    public class Manager : Entity
    {
        private readonly IList<HealthCenter> _healthCenter;

        public Manager(Guid userId, string code)
        {
            UserId = userId;
            Code = code;
            _healthCenter = new List<HealthCenter>();
        }
        public string Code { get; private set; }

        public Guid UserId { get; private set; }
        public User User { get; private set; }

        public IReadOnlyCollection<HealthCenter> HealthCenter => _healthCenter.ToArray();

    }
}
