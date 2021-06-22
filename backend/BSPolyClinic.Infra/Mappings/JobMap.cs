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
    public class JobMap : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.ToTable("Jobs");

            builder.HasKey(f => f.Id);

            builder.Property(f => f.Id).ValueGeneratedOnAdd();
            builder.Property(f => f.Description).HasMaxLength(50);

            builder.HasData(
                new Job
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                    Description = "Administrador do sistema"
                },


                new Job
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Manager",
                    NormalizedName = "MANAGER",
                    Description = "Gestor(a)"
                },


                new Job
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Doctor",
                    NormalizedName = "DOCTOR",
                    Description = "Médico(a)"
                },


                new Job
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Nurse",
                    NormalizedName = "NURSE",
                    Description = "Enfermeiro(a)"
                },

                
                new Job
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Attendant",
                    NormalizedName = "ATTENDANT",
                    Description = "Atendente"
                },


                new Job
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Patient",
                    NormalizedName = "PATIENT",
                    Description = "Paciente"
                }
                );
        }
    }
}
