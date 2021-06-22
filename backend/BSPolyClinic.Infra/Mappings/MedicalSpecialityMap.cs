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
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Title).HasColumnType("VARCHAR(512)");
            builder.Property(m => m.Description).HasColumnType("VARCHAR(512)");
            builder.Property(m => m.Observation).HasColumnType("VARCHAR(512)");
            builder.Property(m => m.Active).HasColumnType("BIT");
        }
    }
}
