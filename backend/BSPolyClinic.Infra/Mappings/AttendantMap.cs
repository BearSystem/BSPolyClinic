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
            builder.HasKey(a => a.AttendantId);
            builder.Property(a => a.AttendantId).ValueGeneratedOnAdd();

            builder.Property(a => a.Code).HasColumnType("VARCHAR(50)");

            builder.Property(d => d.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.Property(d => d.UpdatedAt).HasColumnType("datetime");
        }
    }
}
