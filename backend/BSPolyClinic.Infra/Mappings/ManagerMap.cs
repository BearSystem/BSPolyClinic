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
    public class ManagerMap : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.HasKey(m => m.ManagerId);
            builder.Property(m => m.ManagerId).ValueGeneratedOnAdd();

            builder.Property(m => m.Code).HasColumnType("VARCHAR(50)");

            builder.Property(d => d.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.Property(d => d.UpdatedAt).HasColumnType("datetime");
        }
    }
}
