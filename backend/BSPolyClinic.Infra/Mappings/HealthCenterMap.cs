using BSPolyClinic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Infra.Mappings
{
    public class HealthCenterMap : IEntityTypeConfiguration<HealthCenter>
    {
        public void Configure(EntityTypeBuilder<HealthCenter> builder)
        {
            throw new NotImplementedException();
        }
    }
}
