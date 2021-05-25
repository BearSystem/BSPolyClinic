using BSPolyClinic.Domain.Entities;
using BSPolyClinic.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Infra.Mappings
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");

            var type = new EnumToNumberConverter<EAddressType, int>();

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Street).HasColumnType("varchar").HasMaxLength(250);
            builder.Property(a => a.Complement).HasColumnType("varchar").HasMaxLength(350);
            builder.Property(a => a.Number).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(a => a.District).HasColumnType("varchar").HasMaxLength(250);
            builder.Property(a => a.City).HasColumnType("varchar").HasMaxLength(250);
            builder.Property(a => a.State).HasColumnType("varchar").HasMaxLength(250);
            builder.Property(a => a.ZipCode).HasColumnType("varchar").HasMaxLength(10);
            builder.Property(a => a.Country).HasColumnType("varchar").HasMaxLength(250);

            builder.Property(a => a.Type).HasColumnType("int").HasConversion(type);

            builder.Property(a => a.Description).HasColumnType("text");

            builder.Property(a => a.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.Property(e => e.UpdatedAt).HasColumnType("datetime");
        }
    }
}
