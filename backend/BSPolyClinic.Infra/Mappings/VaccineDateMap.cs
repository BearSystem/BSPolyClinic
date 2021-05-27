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
            builder.ToTable("VaccineDate");

            builder.HasKey(v => v.Id);

            builder.Property(v => v.Description);
            builder.Property(v => v.Observation);
            builder.Property(v => v.Hour);
            builder.Property(v => v.Checked);


            builder
              .HasOne(bc => bc.Vaccine)
              .WithMany(c => c.VaccineDate)
              .HasForeignKey(bc => bc.VaccinesId);

            builder
              .HasOne(bc => bc.Patient)
              .WithMany(c => c.VaccineDate)
              .HasForeignKey(bc => bc.PatientId);


        }
    }
}
