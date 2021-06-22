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
    public class AdministratorMap : IEntityTypeConfiguration<Administrator>
    {
        public void Configure(EntityTypeBuilder<Administrator> builder)
        {
            builder.HasKey(a => a.AdministratorId);
            builder.Property(a => a.AdministratorId).ValueGeneratedOnAdd();

            builder.Property(a => a.Code).HasColumnType("VARCHAR(50)");

            builder.Property(d => d.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.Property(d => d.UpdatedAt).HasColumnType("datetime");
        }
    }
}
