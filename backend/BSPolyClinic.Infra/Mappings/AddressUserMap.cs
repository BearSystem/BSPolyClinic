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
    public class AddressUserMap : IEntityTypeConfiguration<AddressUser>
    {
        public void Configure(EntityTypeBuilder<AddressUser> builder)
        {
            builder.HasKey(a => a.AddressUserId);
            builder.Property(a => a.AddressUserId).ValueGeneratedOnAdd();

            builder.Property(a => a.Street).HasColumnType("VARCHAR(512)");
            builder.Property(a => a.Number).HasColumnType("VARCHAR(20)");
            builder.Property(a => a.Complement).HasColumnType("VARCHAR(512)");
            builder.Property(a => a.District).HasColumnType("VARCHAR(512)");
            builder.Property(a => a.City).HasColumnType("VARCHAR(512)");
            builder.Property(a => a.State).HasColumnType("CHAR(2)");
            builder.Property(a => a.Country).HasColumnType("VARCHAR(512)");
            builder.Property(a => a.ZipCode).HasColumnType("VARCHAR(100)");
            builder.Property(a => a.Description).HasColumnType("VARCHAR(512)");
            builder.Property(a => a.Type).HasConversion<int>();

            builder.HasOne(a => a.User).WithMany(a => a.AddressesUsers).HasForeignKey(a => a.UserId).IsRequired().OnDelete(DeleteBehavior.NoAction);

            builder.Property(d => d.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.Property(d => d.UpdatedAt).HasColumnType("datetime");
        }
    }
}
