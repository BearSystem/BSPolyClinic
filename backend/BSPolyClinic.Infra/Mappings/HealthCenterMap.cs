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
    public class HealthCenterMap : IEntityTypeConfiguration<HealthCenter>
    {
        public void Configure(EntityTypeBuilder<HealthCenter> builder)
        {
            builder.HasKey(h => h.HealthCenterId);
            builder.Property(h => h.HealthCenterId).ValueGeneratedOnAdd();

            builder.Property(h => h.Title).HasColumnType("VARCHAR(120)");
            builder.Property(h => h.Description).HasColumnType("VARCHAR(512)");
            builder.Property(h => h.Observation).HasColumnType("VARCHAR(512)");

            builder.Property(d => d.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.Property(d => d.UpdatedAt).HasColumnType("datetime");

            builder.HasMany(u => u.AddressHealthCenters).WithOne(u => u.HealthCenter).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(u => u.Phones).WithOne(u => u.HealthCenter).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
