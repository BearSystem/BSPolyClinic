using BSPolyClinic.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Infra.Mappings
{
    public class PatientMap : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable("Patient");

            builder.HasKey(n => n.Id);

            builder.Property(n => n.Code);


            builder.HasOne(a => a.User).WithMany(b => b.Patient).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(u => u.HealthCenter).WithOne(u => u.Patient).OnDelete(DeleteBehavior.NoAction);

            builder.Property(n => n.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.Property(n => n.UpdatedAt).HasColumnType("datetime");
        }
    }
}
