using BSPolyClinic.Domain.Entities.Users;
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
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            var type = new EnumToNumberConverter<EUserType, int>();

            builder.Property(u => u.Id).ValueGeneratedOnAdd();

            builder.OwnsOne(u => u.Name).Property(n => n.FirstName);
            builder.OwnsOne(u => u.Name).Property(n => n.LastName);
            builder.OwnsOne(u => u.Name).Property(n => n.NickName);

            builder.OwnsOne(u => u.Emails).Property(e => e.Address);
            builder.OwnsOne(u => u.Emails).Property(e => e.SecundaryAddress);

            builder.OwnsOne(u => u.Document).Property(d => d.CPF);
            builder.OwnsOne(u => u.Document).Property(d => d.RG);
            builder.OwnsOne(u => u.Document).Property(d => d.NumberSUS);

            builder.HasMany(u => u.Phones).WithMany(u => u.User);
            builder.HasMany(u => u.Addresses).WithMany(u => u.User);

            builder.Property(a => a.UserType).HasColumnType("int").HasConversion(type);

        }
    }
}
