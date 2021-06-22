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
    public class PhoneHealthCenterMap : IEntityTypeConfiguration<PhoneHealthCenter>
    {
        public void Configure(EntityTypeBuilder<PhoneHealthCenter> builder)
        {
            builder.ToTable("PhoneHealthCenter");

            builder.HasKey(p => p.PhoneHealthCenterId);
            builder.Property(p => p.PhoneHealthCenterId).ValueGeneratedOnAdd();

            builder.Property(p => p.Number).HasColumnType("VARCHAR(100)");
            builder.Property(p => p.Observation).HasColumnType("VARCHAR(300)");
            builder.Property(a => a.Type).HasConversion<int>(); 
            
            builder.HasOne(c => c.HealthCenter).WithMany(c => c.Phones).HasForeignKey(c => c.HealthCenterId).IsRequired().OnDelete(DeleteBehavior.NoAction);

            builder.Property(a => a.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.Property(e => e.UpdatedAt).HasColumnType("datetime");
        }
    }
}
