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
    public class PhoneUserMap : IEntityTypeConfiguration<PhoneUser>
    {
        public void Configure(EntityTypeBuilder<PhoneUser> builder)
        {
            builder.ToTable("PhoneUser");

            builder.HasKey(p => p.PhoneUserId);
            builder.Property(p => p.PhoneUserId).ValueGeneratedOnAdd();

            builder.Property(p => p.Number).HasColumnType("VARCHAR(100)");
            builder.Property(p => p.Observation).HasColumnType("VARCHAR(300)");
            builder.Property(a => a.Type).HasConversion<int>(); 
            
            builder.HasOne(c => c.User).WithMany(c => c.PhonesUsers).HasForeignKey(c => c.UserId).IsRequired().OnDelete(DeleteBehavior.NoAction);

            builder.Property(a => a.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.Property(e => e.UpdatedAt).HasColumnType("datetime");
        }
    }
}
