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
    public class DoctorHealthCenterMap : IEntityTypeConfiguration<DoctorHealthCenter>
    {
        public void Configure(EntityTypeBuilder<DoctorHealthCenter> builder)
        {
            builder.HasKey(d => d.DoctorHealthCenterId);
            
            builder.Property(d => d.DoctorHealthCenterId).ValueGeneratedOnAdd();
            builder.Property(d => d.DoctorId).IsRequired();
            builder.Property(d => d.HealthCenterId).IsRequired();

            builder.Property(d => d.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.Property(d => d.UpdatedAt).HasColumnType("datetime");
        }
    }
}
