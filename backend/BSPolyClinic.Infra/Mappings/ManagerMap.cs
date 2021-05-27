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
    public class ManagerMap : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.ToTable("Manager");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.Code);



            builder
              .HasOne(bc => bc.User)
              .WithMany(c => c.Manager)
              .HasForeignKey(bc => bc.UserId);



            builder.Property(m => m.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.Property(m => m.UpdatedAt).HasColumnType("datetime");
        }
    }
}
