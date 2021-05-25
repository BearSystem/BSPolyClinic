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
    public class PhoneMap : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.ToTable("Phone");

            var type = new EnumToNumberConverter<EPhoneType, int>();

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Telephone);
            builder.Property(p => p.Observation);

            builder.Property(a => a.Type).HasColumnType("int").HasConversion(type);

            builder.Property(a => a.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.Property(e => e.UpdatedAt).HasColumnType("datetime");

        }
    }
}
