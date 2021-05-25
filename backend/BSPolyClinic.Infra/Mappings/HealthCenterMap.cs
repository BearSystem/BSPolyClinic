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
            builder.ToTable("HealthCenter");

            builder.HasKey(h => h.Id);

            builder.HasOne(a => a.Phone).WithMany(b => b.HealthCenter).OnDelete(DeleteBehavior.NoAction);
            
            
            builder.HasOne(a => a.Address).WithMany(b => b.HealthCenter).OnDelete(DeleteBehavior.NoAction);

            builder.Property(h => h.Description);
            builder.Property(h => h.Observation);


            builder.Property(a => a.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.Property(e => e.UpdatedAt).HasColumnType("datetime");
        }
    }
}
