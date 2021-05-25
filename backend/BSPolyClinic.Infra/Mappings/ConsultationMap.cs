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
    public class ConsultationMap : IEntityTypeConfiguration<Consultation>
    {
        public void Configure(EntityTypeBuilder<Consultation> builder)
        {
            builder.ToTable("Consultation");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Description);
            builder.Property(c => c.Observation);

            builder.HasOne(a => a.Doctor).WithOne(b => b.Consultation).HasForeignKey<Consultation>(b => b.DoctorId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(a => a.Speciality).WithOne(b => b.Consultation).HasForeignKey<Consultation>(b => b.SpecialityId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(a => a.HealthCenter).WithOne(b => b.Consultation).HasForeignKey<Consultation>(b => b.HealthCenterId).OnDelete(DeleteBehavior.NoAction);

            builder.Property(c => c.Active);

            builder.Property(a => a.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.Property(e => e.UpdatedAt).HasColumnType("datetime");
        }
    }
}
