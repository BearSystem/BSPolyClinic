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
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.Id);

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

        }
    }
}
