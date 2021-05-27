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

            builder
              .HasOne(bc => bc.Doctor)
              .WithMany(c => c.Consultation)
              .HasForeignKey(bc => bc.DoctorId);


            builder
              .HasOne(bc => bc.HealthCenter)
              .WithMany(c => c.Consultation)
              .HasForeignKey(bc => bc.HealthCenterId);


            builder.HasMany(u => u.Speciality).WithOne(u => u.Consultation).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(u => u.ConsultationDate).WithOne(u => u.Consultation).OnDelete(DeleteBehavior.NoAction);


            builder.Property(c => c.Active);

            builder.Property(a => a.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.Property(e => e.UpdatedAt).HasColumnType("datetime");
        }
    }
}
