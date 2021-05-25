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
    public class AttendantMap : IEntityTypeConfiguration<Attendant>
    {
        public void Configure(EntityTypeBuilder<Attendant> builder)
        {
            builder.ToTable("Attendant");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Code);

            builder.HasOne(a => a.User).WithOne(b => b.Attendant).HasForeignKey<Attendant>(b => b.UserId).IsRequired().OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(u => u.HealthCenter).WithOne(u => u.Attendant).OnDelete(DeleteBehavior.NoAction);

            builder.Property(a => a.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.Property(e => e.UpdatedAt).HasColumnType("datetime");
        }
    }
}
