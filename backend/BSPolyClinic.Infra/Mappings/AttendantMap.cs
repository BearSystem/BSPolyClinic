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
    public class AttendantMap : IEntityTypeConfiguration<Attendant>
    {
        public void Configure(EntityTypeBuilder<Attendant> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Code).HasColumnType("VARCHAR(50)");

        }
    }
}
