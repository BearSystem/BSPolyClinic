using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BSPolyClinic.Infra.Migrations
{
    public partial class PolyClinicV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Street = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true),
                    Number = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Complement = table.Column<string>(type: "varchar(350)", maxLength: 350, nullable: true),
                    District = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true),
                    City = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true),
                    State = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true),
                    Country = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true),
                    ZipCode = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    HealthCenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name_NickName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emails_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emails_SecundaryAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document_CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document_RG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document_NumberSUS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HealthCenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AddressUser",
                columns: table => new
                {
                    AddressesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressUser", x => new { x.AddressesId, x.UserId });
                    table.ForeignKey(
                        name: "FK_AddressUser_Address_AddressesId",
                        column: x => x.AddressesId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AddressUser_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Administrator",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrator", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Administrator_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attendant",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendant_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConsultationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Crm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctor_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Manager",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Manager_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Nurse",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nurse_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    VaccineDateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsultationDateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patient_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PhoneUser",
                columns: table => new
                {
                    PhonesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneUser", x => new { x.PhonesId, x.UserId });
                    table.ForeignKey(
                        name: "FK_PhoneUser_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhoneUser_Phone_PhonesId",
                        column: x => x.PhonesId,
                        principalTable: "Phone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthCenter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsultationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttendantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NurseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsultationDateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VaccineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VaccineDateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthCenter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthCenter_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HealthCenter_Attendant_AttendantId",
                        column: x => x.AttendantId,
                        principalTable: "Attendant",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HealthCenter_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HealthCenter_Manager_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Manager",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HealthCenter_Nurse_NurseId",
                        column: x => x.NurseId,
                        principalTable: "Nurse",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HealthCenter_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HealthCenter_Phone_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "Phone",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MedicalSpeciality",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HealthCenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsultationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalSpeciality", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalSpeciality_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedicalSpeciality_HealthCenter_HealthCenterId",
                        column: x => x.HealthCenterId,
                        principalTable: "HealthCenter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vaccine",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinimumAge = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    InitialDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VaccineDateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HealthCenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vaccine_HealthCenter_HealthCenterId",
                        column: x => x.HealthCenterId,
                        principalTable: "HealthCenter",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Consultation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpecialityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HealthCenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsultationDateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consultation_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Consultation_HealthCenter_HealthCenterId",
                        column: x => x.HealthCenterId,
                        principalTable: "HealthCenter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Consultation_MedicalSpeciality_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "MedicalSpeciality",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VaccineDate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VaccinesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VaccineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HealthCenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VaccinationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Checked = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccineDate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VaccineDate_HealthCenter_HealthCenterId",
                        column: x => x.HealthCenterId,
                        principalTable: "HealthCenter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VaccineDate_Patient_PatientId1",
                        column: x => x.PatientId1,
                        principalTable: "Patient",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VaccineDate_Vaccine_VaccineId",
                        column: x => x.VaccineId,
                        principalTable: "Vaccine",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ConsultationDate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsultationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HealthCenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsultationDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Checked = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultationDate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsultationDate_Consultation_ConsultationId",
                        column: x => x.ConsultationId,
                        principalTable: "Consultation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ConsultationDate_HealthCenter_HealthCenterId",
                        column: x => x.HealthCenterId,
                        principalTable: "HealthCenter",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ConsultationDate_Patient_PatientId1",
                        column: x => x.PatientId1,
                        principalTable: "Patient",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressUser_UserId",
                table: "AddressUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Administrator_UserId",
                table: "Administrator",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Attendant_UserId",
                table: "Attendant",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_DoctorId",
                table: "Consultation",
                column: "DoctorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_HealthCenterId",
                table: "Consultation",
                column: "HealthCenterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_SpecialityId",
                table: "Consultation",
                column: "SpecialityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ConsultationDate_ConsultationId",
                table: "ConsultationDate",
                column: "ConsultationId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultationDate_HealthCenterId",
                table: "ConsultationDate",
                column: "HealthCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultationDate_PatientId1",
                table: "ConsultationDate",
                column: "PatientId1");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_UserId",
                table: "Doctor",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HealthCenter_AddressId",
                table: "HealthCenter",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCenter_AttendantId",
                table: "HealthCenter",
                column: "AttendantId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCenter_DoctorId",
                table: "HealthCenter",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCenter_ManagerId",
                table: "HealthCenter",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCenter_NurseId",
                table: "HealthCenter",
                column: "NurseId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCenter_PatientId",
                table: "HealthCenter",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCenter_PhoneId",
                table: "HealthCenter",
                column: "PhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Manager_UserId",
                table: "Manager",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MedicalSpeciality_DoctorId",
                table: "MedicalSpeciality",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalSpeciality_HealthCenterId",
                table: "MedicalSpeciality",
                column: "HealthCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Nurse_UserId",
                table: "Nurse",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patient_UserId",
                table: "Patient",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneUser_UserId",
                table: "PhoneUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaccine_HealthCenterId",
                table: "Vaccine",
                column: "HealthCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_VaccineDate_HealthCenterId",
                table: "VaccineDate",
                column: "HealthCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_VaccineDate_PatientId1",
                table: "VaccineDate",
                column: "PatientId1");

            migrationBuilder.CreateIndex(
                name: "IX_VaccineDate_VaccineId",
                table: "VaccineDate",
                column: "VaccineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressUser");

            migrationBuilder.DropTable(
                name: "Administrator");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ConsultationDate");

            migrationBuilder.DropTable(
                name: "PhoneUser");

            migrationBuilder.DropTable(
                name: "VaccineDate");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Consultation");

            migrationBuilder.DropTable(
                name: "Vaccine");

            migrationBuilder.DropTable(
                name: "MedicalSpeciality");

            migrationBuilder.DropTable(
                name: "HealthCenter");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Attendant");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Manager");

            migrationBuilder.DropTable(
                name: "Nurse");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
