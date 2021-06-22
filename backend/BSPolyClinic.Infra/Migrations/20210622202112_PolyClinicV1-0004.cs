using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BSPolyClinic.Infra.Migrations
{
    public partial class PolyClinicV10004 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Document_CPF = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Document_RG = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Document_NumberSUS = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                name: "HealthCenters",
                columns: table => new
                {
                    HealthCenterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "VARCHAR(120)", nullable: true),
                    Description = table.Column<string>(type: "VARCHAR(512)", nullable: true),
                    Observation = table.Column<string>(type: "VARCHAR(512)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthCenters", x => x.HealthCenterId);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalSpecialties",
                columns: table => new
                {
                    MedicalSpecialityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "VARCHAR(512)", nullable: true),
                    Active = table.Column<bool>(type: "BIT", nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(512)", nullable: true),
                    Observation = table.Column<string>(type: "VARCHAR(512)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalSpecialties", x => x.MedicalSpecialityId);
                });

            migrationBuilder.CreateTable(
                name: "AddressUsers",
                columns: table => new
                {
                    AddressUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    Street = table.Column<string>(type: "VARCHAR(512)", nullable: true),
                    Number = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    Complement = table.Column<string>(type: "VARCHAR(512)", nullable: true),
                    District = table.Column<string>(type: "VARCHAR(512)", nullable: true),
                    City = table.Column<string>(type: "VARCHAR(512)", nullable: true),
                    State = table.Column<string>(type: "CHAR(2)", nullable: true),
                    Country = table.Column<string>(type: "VARCHAR(512)", nullable: true),
                    ZipCode = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Description = table.Column<string>(type: "VARCHAR(512)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressUsers", x => x.AddressUserId);
                    table.ForeignKey(
                        name: "FK_AddressUsers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Administrators",
                columns: table => new
                {
                    AdministratorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrators", x => x.AdministratorId);
                    table.ForeignKey(
                        name: "FK_Administrators_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "Attendants",
                columns: table => new
                {
                    AttendantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendants", x => x.AttendantId);
                    table.ForeignKey(
                        name: "FK_Attendants_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DoctorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Crm = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DoctorId);
                    table.ForeignKey(
                        name: "FK_Doctors_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    ManagerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.ManagerId);
                    table.ForeignKey(
                        name: "FK_Managers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Nurses",
                columns: table => new
                {
                    NurseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Crm = table.Column<string>(type: "VARCHAR(150)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurses", x => x.NurseId);
                    table.ForeignKey(
                        name: "FK_Nurses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                    table.ForeignKey(
                        name: "FK_Patients_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhoneUser",
                columns: table => new
                {
                    PhoneUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    Number = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Observation = table.Column<string>(type: "VARCHAR(300)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneUser", x => x.PhoneUserId);
                    table.ForeignKey(
                        name: "FK_PhoneUser_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AddressHealthCenters",
                columns: table => new
                {
                    AddressHealthCenterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HealthCenterId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    Street = table.Column<string>(type: "VARCHAR(512)", nullable: true),
                    Number = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    Complement = table.Column<string>(type: "VARCHAR(512)", nullable: true),
                    District = table.Column<string>(type: "VARCHAR(512)", nullable: true),
                    City = table.Column<string>(type: "VARCHAR(512)", nullable: true),
                    State = table.Column<string>(type: "CHAR(2)", nullable: true),
                    Country = table.Column<string>(type: "VARCHAR(512)", nullable: true),
                    ZipCode = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Description = table.Column<string>(type: "VARCHAR(512)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressHealthCenters", x => x.AddressHealthCenterId);
                    table.ForeignKey(
                        name: "FK_AddressHealthCenters_HealthCenters_HealthCenterId",
                        column: x => x.HealthCenterId,
                        principalTable: "HealthCenters",
                        principalColumn: "HealthCenterId");
                });

            migrationBuilder.CreateTable(
                name: "PhoneHealthCenter",
                columns: table => new
                {
                    PhoneHealthCenterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HealthCenterId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    Number = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Observation = table.Column<string>(type: "VARCHAR(300)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneHealthCenter", x => x.PhoneHealthCenterId);
                    table.ForeignKey(
                        name: "FK_PhoneHealthCenter_HealthCenters_HealthCenterId",
                        column: x => x.HealthCenterId,
                        principalTable: "HealthCenters",
                        principalColumn: "HealthCenterId");
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
                        name: "FK_AspNetRoleClaims_Jobs_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Jobs",
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
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_Jobs_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthCenterMedicalSpeciality",
                columns: table => new
                {
                    HealthCenterMedicalSpecialityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HealthCenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HealthCenterId1 = table.Column<int>(type: "int", nullable: true),
                    MedicalSpecialityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedicalSpecialityId1 = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthCenterMedicalSpeciality", x => x.HealthCenterMedicalSpecialityId);
                    table.ForeignKey(
                        name: "FK_HealthCenterMedicalSpeciality_HealthCenters_HealthCenterId1",
                        column: x => x.HealthCenterId1,
                        principalTable: "HealthCenters",
                        principalColumn: "HealthCenterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HealthCenterMedicalSpeciality_MedicalSpecialties_MedicalSpecialityId1",
                        column: x => x.MedicalSpecialityId1,
                        principalTable: "MedicalSpecialties",
                        principalColumn: "MedicalSpecialityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DoctorHealthCenter",
                columns: table => new
                {
                    DoctorHealthCenterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoctorId1 = table.Column<int>(type: "int", nullable: true),
                    HealthCenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HealthCenterId1 = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorHealthCenter", x => x.DoctorHealthCenterId);
                    table.ForeignKey(
                        name: "FK_DoctorHealthCenter_Doctors_DoctorId1",
                        column: x => x.DoctorId1,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DoctorHealthCenter_HealthCenters_HealthCenterId1",
                        column: x => x.HealthCenterId1,
                        principalTable: "HealthCenters",
                        principalColumn: "HealthCenterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DoctorMedicalSpeciality",
                columns: table => new
                {
                    DoctorMedicalSpecialityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoctorId1 = table.Column<int>(type: "int", nullable: true),
                    MedicalSpecialityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedicalSpecialityId1 = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorMedicalSpeciality", x => x.DoctorMedicalSpecialityId);
                    table.ForeignKey(
                        name: "FK_DoctorMedicalSpeciality_Doctors_DoctorId1",
                        column: x => x.DoctorId1,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DoctorMedicalSpeciality_MedicalSpecialties_MedicalSpecialityId1",
                        column: x => x.MedicalSpecialityId1,
                        principalTable: "MedicalSpecialties",
                        principalColumn: "MedicalSpecialityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HealthCenterNurses",
                columns: table => new
                {
                    HealthCenterNurseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HealthCenterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HealthCenterId1 = table.Column<int>(type: "int", nullable: true),
                    NurseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NurseId1 = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthCenterNurses", x => x.HealthCenterNurseId);
                    table.ForeignKey(
                        name: "FK_HealthCenterNurses_HealthCenters_HealthCenterId1",
                        column: x => x.HealthCenterId1,
                        principalTable: "HealthCenters",
                        principalColumn: "HealthCenterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HealthCenterNurses_Nurses_NurseId1",
                        column: x => x.NurseId1,
                        principalTable: "Nurses",
                        principalColumn: "NurseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1d4f0035-8448-4018-9a30-4d7b1b7b7aa9", "4eeafa8a-b946-4660-ac0d-ddfc9a4e8a12", "Administrador do sistema", "Administrator", "ADMINISTRATOR" },
                    { "68377797-8fa8-49d9-a824-29441db5de3d", "36a68435-442e-4c66-bedc-f1f78d52725f", "Gestor(a)", "Manager", "MANAGER" },
                    { "6b2ee624-e125-4ab8-b866-a51d98aa40c3", "70daacf2-2c5e-4806-bdeb-7270b7e82ca8", "Médico(a)", "Doctor", "DOCTOR" },
                    { "a7eb93ff-d311-4359-b73e-1924de699865", "ca7d4c52-61fa-4ac1-9500-0dedf505dc26", "Enfermeiro(a)", "Nurse", "NURSE" },
                    { "b90efb92-b9a4-4c47-a6cf-e72fa01a0784", "d6f630ba-d2a3-479d-a343-aac9d15f1fc6", "Atendente", "Attendant", "ATTENDANT" },
                    { "3ffe6a94-bda3-4821-aeed-60ddaa2962e7", "c32ac403-7b06-446e-9919-34e77d8c20a3", "Paciente", "Patient", "PATIENT" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressHealthCenters_HealthCenterId",
                table: "AddressHealthCenters",
                column: "HealthCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressUsers_UserId",
                table: "AddressUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Administrators_UserId",
                table: "Administrators",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

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
                name: "IX_AspNetUsers_Document_CPF",
                table: "AspNetUsers",
                column: "Document_CPF",
                unique: true,
                filter: "[Document_CPF] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Document_NumberSUS",
                table: "AspNetUsers",
                column: "Document_NumberSUS",
                unique: true,
                filter: "[Document_NumberSUS] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Document_RG",
                table: "AspNetUsers",
                column: "Document_RG",
                unique: true,
                filter: "[Document_RG] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Attendants_UserId",
                table: "Attendants",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorHealthCenter_DoctorId1",
                table: "DoctorHealthCenter",
                column: "DoctorId1");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorHealthCenter_HealthCenterId1",
                table: "DoctorHealthCenter",
                column: "HealthCenterId1");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorMedicalSpeciality_DoctorId1",
                table: "DoctorMedicalSpeciality",
                column: "DoctorId1");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorMedicalSpeciality_MedicalSpecialityId1",
                table: "DoctorMedicalSpeciality",
                column: "MedicalSpecialityId1");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCenterMedicalSpeciality_HealthCenterId1",
                table: "HealthCenterMedicalSpeciality",
                column: "HealthCenterId1");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCenterMedicalSpeciality_MedicalSpecialityId1",
                table: "HealthCenterMedicalSpeciality",
                column: "MedicalSpecialityId1");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCenterNurses_HealthCenterId1",
                table: "HealthCenterNurses",
                column: "HealthCenterId1");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCenterNurses_NurseId1",
                table: "HealthCenterNurses",
                column: "NurseId1");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Jobs",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Managers_UserId",
                table: "Managers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_UserId",
                table: "Nurses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_UserId",
                table: "Patients",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneHealthCenter_HealthCenterId",
                table: "PhoneHealthCenter",
                column: "HealthCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneUser_UserId",
                table: "PhoneUser",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressHealthCenters");

            migrationBuilder.DropTable(
                name: "AddressUsers");

            migrationBuilder.DropTable(
                name: "Administrators");

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
                name: "Attendants");

            migrationBuilder.DropTable(
                name: "DoctorHealthCenter");

            migrationBuilder.DropTable(
                name: "DoctorMedicalSpeciality");

            migrationBuilder.DropTable(
                name: "HealthCenterMedicalSpeciality");

            migrationBuilder.DropTable(
                name: "HealthCenterNurses");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "PhoneHealthCenter");

            migrationBuilder.DropTable(
                name: "PhoneUser");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "MedicalSpecialties");

            migrationBuilder.DropTable(
                name: "Nurses");

            migrationBuilder.DropTable(
                name: "HealthCenters");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
