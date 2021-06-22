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
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();

            builder.OwnsOne(u => u.Name).Property(n => n.FirstName);
            builder.OwnsOne(u => u.Name).Property(n => n.LastName);
            builder.OwnsOne(u => u.Name).Property(n => n.NickName);

            builder.OwnsOne(u => u.Emails).Property(e => e.Address);
            builder.OwnsOne(u => u.Emails).Property(e => e.SecundaryAddress);

            builder.OwnsOne(u => u.Document).Property(d => d.CPF);
            builder.OwnsOne(u => u.Document).Property(d => d.RG);
            builder.OwnsOne(u => u.Document).Property(d => d.NumberSUS);

            builder.OwnsOne(u => u.Document).HasIndex(d => d.CPF).IsUnique();
            builder.OwnsOne(u => u.Document).HasIndex(d => d.RG).IsUnique();
            builder.OwnsOne(u => u.Document).HasIndex(d => d.NumberSUS).IsUnique();

            builder.Property(u => u.UserType).HasConversion<int>();

            builder.HasMany(u => u.AddressesUsers).WithOne(u => u.User).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(u => u.PhonesUsers).WithOne(u => u.User).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
