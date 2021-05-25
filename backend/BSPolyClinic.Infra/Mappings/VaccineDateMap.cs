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
    public class VaccineDateMap : IEntityTypeConfiguration<VaccineDate>
    {
        public void Configure(EntityTypeBuilder<VaccineDate> builder)
        {
            throw new NotImplementedException();
        }
    }
}
