using BSPolyClinic.Api.Security;
using BSPolyClinic.Domain.Entities;
using BSPolyClinic.Infra;
using BSPolyClinic.Infra.Interfaces;
using BSPolyClinic.Infra.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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


            services.AddScoped<IAddressUser, AddressUserRepository>();
            services.AddScoped<IAddressHealthCenter, AddressHealthCenterRepository>();
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

            services.AddSpaStaticFiles(diretorio =>
            {
                //diretorio.RootPath = "";
            });

            services.AddControllers();
            services.AddControllers().AddNewtonsoftJson();


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Bear System Poly Clinic",
                        Version = "v1",
                        Description = "API REST para cl?nica m?dica. <br/> " +
                        "<h5>" +
                        "<ol>" +
                        "  <li>Consultas m?dicas</li>" +
                        "  <li>Agendar vacina??o</li>" +
                        "  <li>Cadastro de Pacientes</li>" +
                        "</ol>" +
                        "</h5>",
                        Contact = new OpenApiContact
                        {
                            Name = "K?gi Carvalho",
                            Url = new Uri("https://github.com/kagicarvalho")
                        }
                    });
            });
            var key = Encoding.ASCII.GetBytes(Settings.ChaveSecreta);

            services.AddAuthentication(opcoes =>
            {
                opcoes.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opcoes.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(opcoes =>
                {
                    opcoes.RequireHttpsMetadata = false;
                    opcoes.SaveToken = true;
                    opcoes.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });


            services.AddControllers()
                .AddJsonOptions(opcoes =>
                {
                    opcoes.JsonSerializerOptions.IgnoreNullValues = true;
                })
                .AddNewtonsoftJson(opcoes =>
                {
                    opcoes.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
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

            app.UseCors(opcoes => opcoes.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseAuthentication();

            app.UseStaticFiles();

            //app.UseSpaStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
