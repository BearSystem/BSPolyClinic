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
    public class NurseMap : IEntityTypeConfiguration<Nurse>
    {
        public void Configure(EntityTypeBuilder<Nurse> builder)
        {
            builder.HasKey(n => n.Id);

            builder.Property(n => n.Code).HasColumnType("VARCHAR(50)");
            builder.Property(n => n.Crm).HasColumnType("VARCHAR(150)");
        }
    }
}
