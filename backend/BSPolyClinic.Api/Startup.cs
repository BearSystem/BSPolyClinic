using BSPolyClinic.Domain.Entities.Users;
using BSPolyClinic.Infra;
using BSPolyClinic.Infra.Interfaces;
using BSPolyClinic.Infra.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSPolyClinic.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<Context>(opcoes => opcoes.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<User, Job>().AddEntityFrameworkStores<Context>();


            services.AddScoped<IAddress, AddressRepository>();
            services.AddScoped<IAdministrator, AdministratorRepository>();
            services.AddScoped<IAttendant, AttendantRepository>();
            services.AddScoped<IConsultation, ConsultationRepository>();
            services.AddScoped<IConsultationDate, ConsultationDateRepository>();
            services.AddScoped<IDoctor, DoctorRepository>();
            services.AddScoped<IHealthCenter, HealthCenterRepository>();
            services.AddScoped<IJob, JobRepository>();
            services.AddScoped<IManager, ManagerRepository>();
            services.AddScoped<IMedicalSpeciality, MedicalSpecialityRepository>();
            services.AddScoped<INurse, NurseRepository>();
            services.AddScoped<IPatient, PatientRepository>();
            services.AddScoped<IUser, UserRepository>();
            services.AddScoped<IVaccine, VaccineRepository>();
            services.AddScoped<IVaccineDate, VaccineDateRepository>();


            services.AddCors();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Bear System Poly Clinic",
                        Version = "v1",
                        Description = "API REST para clínica médica. <br/> " +
                        "<h5>" +
                        "<ol>" +
                        "  <li>Consultas médicas</li>" +
                        "  <li>Agendar vacinação</li>" +
                        "  <li>Cadastro de Pacientes</li>" +
                        "</ol>" +
                        "</h5>",
                        Contact = new OpenApiContact
                        {
                            Name = "Kägi Carvalho",
                            Url = new Uri("https://github.com/kagicarvalho")
                        }
                    });
            });

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
            }

            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BSPolyClinic.Api v1"));

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
