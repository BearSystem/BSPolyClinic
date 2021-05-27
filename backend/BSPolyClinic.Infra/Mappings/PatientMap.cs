using BSPolyClinic.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Infra.Mappings
{
    public class PatientMap : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable("Patient");

            builder.HasKey(n => n.Id);

            builder.Property(n => n.Code);



            builder
              .HasOne(bc => bc.User)
              .WithMany(c => c.Patient)
              .HasForeignKey(bc => bc.UserId);



            builder.Property(n => n.CreatedAt).HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.Property(n => n.UpdatedAt).HasColumnType("datetime");
        }
    }
}
