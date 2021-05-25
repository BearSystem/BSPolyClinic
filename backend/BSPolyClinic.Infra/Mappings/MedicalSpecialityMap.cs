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
    public class MedicalSpecialityMap : IEntityTypeConfiguration<MedicalSpeciality>
    {
        public void Configure(EntityTypeBuilder<MedicalSpeciality> builder)
        {
            builder.ToTable("MedicalSpeciality");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.Description);
            builder.Property(m => m.Observation);
            builder.Property(m => m.Active);

            builder.Property(m => m.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.Property(m => m.UpdatedAt).HasColumnType("datetime");
        }
    }
}
