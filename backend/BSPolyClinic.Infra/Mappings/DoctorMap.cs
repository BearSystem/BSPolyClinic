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
    public class DoctorMap : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.ToTable("Doctor");

            builder.HasKey(d => d.Id);

            builder.Property(d => d.Code);
            builder.Property(d => d.Crm);

            builder.HasOne(a => a.User).WithOne(b => b.Doctor).HasForeignKey<Doctor>(b => b.UserId).IsRequired().OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(u => u.Speciality).WithOne(u => u.Doctor).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(u => u.HealthCenter).WithOne(u => u.Doctor).OnDelete(DeleteBehavior.NoAction);

            builder.Property(a => a.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.Property(e => e.UpdatedAt).HasColumnType("datetime");
        }
    }
}
