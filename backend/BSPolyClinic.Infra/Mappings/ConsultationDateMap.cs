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

            builder.HasKey(v => v.ConsultationDateId);
            builder.Property(v => v.ConsultationDateId).ValueGeneratedOnAdd();

            builder.Property(v => v.Description);
            builder.Property(v => v.Observation);
            builder.Property(v => v.Hour);
            builder.Property(v => v.Checked);

            builder.HasOne(bc => bc.Consultation).WithMany(c => c.ConsultationDate).HasForeignKey(bc => bc.ConsultationId);

            builder.Property(d => d.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.Property(d => d.UpdatedAt).HasColumnType("datetime");
        }
    }
}
