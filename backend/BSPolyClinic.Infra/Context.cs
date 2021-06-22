using BSPolyClinic.Domain.Entities;
using BSPolyClinic.Infra.Mappings;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSPolyClinic.Infra
{
    public class Context : IdentityDbContext<User, Job, string>
    {
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Attendant> Attendants { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorHealthCenter> DoctorHealthCenter { get; set; }
        public DbSet<DoctorMedicalSpeciality> DoctorMedicalSpeciality { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Address> Addresses { get; set; }
        //public DbSet<Consultation> Consultations { get; set; }
        //public DbSet<ConsultationDate> ConsultationDates { get; set; }
        public DbSet<HealthCenter> HealthCenters { get; set; }
        public DbSet<HealthCenterMedicalSpeciality> HealthCenterMedicalSpeciality { get; set; }
        public DbSet<HealthCenterNurse> HealthCenterNurses { get; set; }
        public DbSet<MedicalSpeciality> MedicalSpecialities { get; set; }
        public DbSet<Phone> Phones { get; set; }
        //public DbSet<Vaccine> Vaccines { get; set; }
        //public DbSet<VaccineDate> VaccineDates { get; set; }



        public Context(DbContextOptions<Context> opcoes) : base(opcoes) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new AddressMap());
            builder.ApplyConfiguration(new AdministratorMap());
            builder.ApplyConfiguration(new AttendantMap());
            //builder.ApplyConfiguration(new ConsultationDateMap());
            //builder.ApplyConfiguration(new ConsultationMap());
            builder.ApplyConfiguration(new DoctorMap());
            builder.ApplyConfiguration(new HealthCenterMap());
            builder.ApplyConfiguration(new ManagerMap());
            builder.ApplyConfiguration(new MedicalSpecialityMap());
            builder.ApplyConfiguration(new NurseMap());
            builder.ApplyConfiguration(new PatientMap());
            builder.ApplyConfiguration(new PhoneMap());
            builder.ApplyConfiguration(new UserMap());
            //builder.ApplyConfiguration(new VaccineDateMap());
            //builder.ApplyConfiguration(new VaccineMap());
        }
    }
}
