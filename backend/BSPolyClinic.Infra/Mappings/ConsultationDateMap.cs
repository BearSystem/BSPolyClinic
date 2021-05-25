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
    public class ConsultationDateMap : IEntityTypeConfiguration<ConsultationDate>
    {
        public void Configure(EntityTypeBuilder<ConsultationDate> builder)
        {

            builder.ToTable("ConsultationDate");

            builder.HasKey(v => v.Id);

            builder.Property(v => v.Description);
            builder.Property(v => v.Observation);
            builder.Property(v => v.Hour);
            builder.Property(v => v.Checked);


            builder.HasOne(x => x.Consultation).WithMany(x => x.ConsultationDate).IsRequired().OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.HealthCenter).WithMany(x => x.ConsultationDate).IsRequired().OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Patient).WithMany(x => x.ConsultationDate).IsRequired().OnDelete(DeleteBehavior.NoAction);
        }
    }
}
