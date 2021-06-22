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
    public class PhoneMap : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Number).HasColumnType("VARCHAR(100)");
            builder.Property(p => p.Observation).HasColumnType("VARCHAR(300)");
            builder.Property(a => a.Type).HasConversion<int>();
        }
    }
}
