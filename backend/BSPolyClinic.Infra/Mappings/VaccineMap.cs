﻿using BSPolyClinic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Infra.Mappings
{
    public class VaccineMap : IEntityTypeConfiguration<Vaccine>
    {
        public void Configure(EntityTypeBuilder<Vaccine> builder)
        {
            builder.ToTable("Vaccine");

            builder.HasKey(v => v.Id);

            builder.Property(v => v.Title);
            builder.Property(v => v.Description);
            builder.Property(v => v.Observation);
            builder.Property(v => v.Active);
            builder.Property(v => v.MinimumAge);
            
            builder.Property(v => v.InitialDate);
            builder.Property(v => v.FinalDate);

            builder.HasOne(x => x.HealthCenter).WithMany(x => x.Vaccine).OnDelete(DeleteBehavior.NoAction);


            builder.Property(a => a.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.Property(e => e.UpdatedAt).HasColumnType("datetime");
        }
    }
}
