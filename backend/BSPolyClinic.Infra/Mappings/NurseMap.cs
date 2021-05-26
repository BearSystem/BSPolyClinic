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
    public class NurseMap : IEntityTypeConfiguration<Nurse>
    {
        public void Configure(EntityTypeBuilder<Nurse> builder)
        {
            builder.ToTable("Nurse");

            builder.HasKey(n => n.Id);

            builder.Property(n => n.Code);

            builder.HasOne(u => u.User).WithOne(n => n.Nurse).HasForeignKey<Nurse>(n => n.UserId).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(u => u.HealthCenter).WithOne(u => u.Nurse).OnDelete(DeleteBehavior.NoAction);

            builder.Property(n => n.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.Property(n => n.UpdatedAt).HasColumnType("datetime");
        }
    }
}
