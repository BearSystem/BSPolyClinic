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


            builder
              .HasOne(bc => bc.User)
              .WithMany(c => c.Attendant)
              .HasForeignKey(bc => bc.UserId);


            builder.Property(a => a.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.Property(e => e.UpdatedAt).HasColumnType("datetime");
        }
    }
}
