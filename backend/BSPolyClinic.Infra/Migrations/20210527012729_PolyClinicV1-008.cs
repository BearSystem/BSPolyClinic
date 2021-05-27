using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BSPolyClinic.Infra.Migrations
{
    public partial class PolyClinicV1008 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Administrator_AspNetUsers_UserId",
                table: "Administrator");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendant_AspNetUsers_UserId",
                table: "Attendant");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultation_Doctor_DoctorId",
                table: "Consultation");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultation_HealthCenter_HealthCenterId",
                table: "Consultation");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultation_MedicalSpeciality_SpecialityId",
                table: "Consultation");

            migrationBuilder.DropForeignKey(
                name: "FK_ConsultationDate_HealthCenter_HealthCenterId",
                table: "ConsultationDate");

            migrationBuilder.DropForeignKey(
                name: "FK_ConsultationDate_Patient_PatientId1",
                table: "ConsultationDate");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_AspNetUsers_UserId",
                table: "Doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthCenter_Attendant_AttendantId",
                table: "HealthCenter");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthCenter_Doctor_DoctorId",
                table: "HealthCenter");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthCenter_Manager_ManagerId",
                table: "HealthCenter");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthCenter_Nurse_NurseId",
                table: "HealthCenter");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthCenter_Patient_PatientId",
                table: "HealthCenter");

            migrationBuilder.DropForeignKey(
                name: "FK_Manager_AspNetUsers_UserId",
                table: "Manager");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalSpeciality_Doctor_DoctorId",
                table: "MedicalSpeciality");

            migrationBuilder.DropForeignKey(
                name: "FK_Nurse_AspNetUsers_UserId",
                table: "Nurse");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_AspNetUsers_UserId",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaccine_HealthCenter_HealthCenterId",
                table: "Vaccine");

            migrationBuilder.DropForeignKey(
                name: "FK_VaccineDate_HealthCenter_HealthCenterId",
                table: "VaccineDate");

            migrationBuilder.DropForeignKey(
                name: "FK_VaccineDate_Patient_PatientId1",
                table: "VaccineDate");

            migrationBuilder.DropForeignKey(
                name: "FK_VaccineDate_Vaccine_VaccineId",
                table: "VaccineDate");

            migrationBuilder.DropIndex(
                name: "IX_VaccineDate_PatientId1",
                table: "VaccineDate");

            migrationBuilder.DropIndex(
                name: "IX_VaccineDate_VaccineId",
                table: "VaccineDate");

            migrationBuilder.DropIndex(
                name: "IX_Patient_UserId",
                table: "Patient");

            migrationBuilder.DropIndex(
                name: "IX_Nurse_UserId",
                table: "Nurse");

            migrationBuilder.DropIndex(
                name: "IX_Manager_UserId",
                table: "Manager");

            migrationBuilder.DropIndex(
                name: "IX_Doctor_UserId",
                table: "Doctor");

            migrationBuilder.DropIndex(
                name: "IX_ConsultationDate_PatientId1",
                table: "ConsultationDate");

            migrationBuilder.DropIndex(
                name: "IX_Consultation_DoctorId",
                table: "Consultation");

            migrationBuilder.DropIndex(
                name: "IX_Consultation_HealthCenterId",
                table: "Consultation");

            migrationBuilder.DropIndex(
                name: "IX_Consultation_SpecialityId",
                table: "Consultation");

            migrationBuilder.DropIndex(
                name: "IX_Attendant_UserId",
                table: "Attendant");

            migrationBuilder.DropIndex(
                name: "IX_Administrator_UserId",
                table: "Administrator");

            migrationBuilder.DropColumn(
                name: "PatientId1",
                table: "VaccineDate");

            migrationBuilder.DropColumn(
                name: "VaccineId",
                table: "VaccineDate");

            migrationBuilder.DropColumn(
                name: "VaccineDateId",
                table: "Vaccine");

            migrationBuilder.DropColumn(
                name: "ConsultationDateId",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "VaccineDateId",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "ConsultationId",
                table: "HealthCenter");

            migrationBuilder.DropColumn(
                name: "ConsultationId",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "PatientId1",
                table: "ConsultationDate");

            migrationBuilder.DropColumn(
                name: "ConsultationDateId",
                table: "Consultation");

            migrationBuilder.DropColumn(
                name: "SpecialityId",
                table: "Consultation");

            migrationBuilder.AlterColumn<Guid>(
                name: "PatientId",
                table: "VaccineDate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "HealthCenterId",
                table: "VaccineDate",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Manager",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<Guid>(
                name: "PatientId",
                table: "ConsultationDate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "HealthCenterId",
                table: "ConsultationDate",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Attendant",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_VaccineDate_PatientId",
                table: "VaccineDate",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_VaccineDate_VaccinesId",
                table: "VaccineDate",
                column: "VaccinesId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_UserId",
                table: "Patient",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Nurse_UserId",
                table: "Nurse",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalSpeciality_ConsultationId",
                table: "MedicalSpeciality",
                column: "ConsultationId");

            migrationBuilder.CreateIndex(
                name: "IX_Manager_UserId",
                table: "Manager",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_UserId",
                table: "Doctor",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultationDate_PatientId",
                table: "ConsultationDate",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_DoctorId",
                table: "Consultation",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultation_HealthCenterId",
                table: "Consultation",
                column: "HealthCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendant_UserId",
                table: "Attendant",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Administrator_UserId",
                table: "Administrator",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Administrator_AspNetUsers_UserId",
                table: "Administrator",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendant_AspNetUsers_UserId",
                table: "Attendant",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultation_Doctor_DoctorId",
                table: "Consultation",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultation_HealthCenter_HealthCenterId",
                table: "Consultation",
                column: "HealthCenterId",
                principalTable: "HealthCenter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConsultationDate_HealthCenter_HealthCenterId",
                table: "ConsultationDate",
                column: "HealthCenterId",
                principalTable: "HealthCenter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ConsultationDate_Patient_PatientId",
                table: "ConsultationDate",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_AspNetUsers_UserId",
                table: "Doctor",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HealthCenter_Attendant_AttendantId",
                table: "HealthCenter",
                column: "AttendantId",
                principalTable: "Attendant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HealthCenter_Doctor_DoctorId",
                table: "HealthCenter",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HealthCenter_Manager_ManagerId",
                table: "HealthCenter",
                column: "ManagerId",
                principalTable: "Manager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HealthCenter_Nurse_NurseId",
                table: "HealthCenter",
                column: "NurseId",
                principalTable: "Nurse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HealthCenter_Patient_PatientId",
                table: "HealthCenter",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Manager_AspNetUsers_UserId",
                table: "Manager",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalSpeciality_Consultation_ConsultationId",
                table: "MedicalSpeciality",
                column: "ConsultationId",
                principalTable: "Consultation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalSpeciality_Doctor_DoctorId",
                table: "MedicalSpeciality",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nurse_AspNetUsers_UserId",
                table: "Nurse",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_AspNetUsers_UserId",
                table: "Patient",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vaccine_HealthCenter_HealthCenterId",
                table: "Vaccine",
                column: "HealthCenterId",
                principalTable: "HealthCenter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VaccineDate_HealthCenter_HealthCenterId",
                table: "VaccineDate",
                column: "HealthCenterId",
                principalTable: "HealthCenter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VaccineDate_Patient_PatientId",
                table: "VaccineDate",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VaccineDate_Vaccine_VaccinesId",
                table: "VaccineDate",
                column: "VaccinesId",
                principalTable: "Vaccine",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Administrator_AspNetUsers_UserId",
                table: "Administrator");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendant_AspNetUsers_UserId",
                table: "Attendant");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultation_Doctor_DoctorId",
                table: "Consultation");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultation_HealthCenter_HealthCenterId",
                table: "Consultation");

            migrationBuilder.DropForeignKey(
                name: "FK_ConsultationDate_HealthCenter_HealthCenterId",
                table: "ConsultationDate");

            migrationBuilder.DropForeignKey(
                name: "FK_ConsultationDate_Patient_PatientId",
                table: "ConsultationDate");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_AspNetUsers_UserId",
                table: "Doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthCenter_Attendant_AttendantId",
                table: "HealthCenter");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthCenter_Doctor_DoctorId",
                table: "HealthCenter");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthCenter_Manager_ManagerId",
                table: "HealthCenter");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthCenter_Nurse_NurseId",
                table: "HealthCenter");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthCenter_Patient_PatientId",
                table: "HealthCenter");

            migrationBuilder.DropForeignKey(
                name: "FK_Manager_AspNetUsers_UserId",
                table: "Manager");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalSpeciality_Consultation_ConsultationId",
                table: "MedicalSpeciality");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalSpeciality_Doctor_DoctorId",
                table: "MedicalSpeciality");

            migrationBuilder.DropForeignKey(
                name: "FK_Nurse_AspNetUsers_UserId",
                table: "Nurse");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_AspNetUsers_UserId",
                table: "Patient");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaccine_HealthCenter_HealthCenterId",
                table: "Vaccine");

            migrationBuilder.DropForeignKey(
                name: "FK_VaccineDate_HealthCenter_HealthCenterId",
                table: "VaccineDate");

            migrationBuilder.DropForeignKey(
                name: "FK_VaccineDate_Patient_PatientId",
                table: "VaccineDate");

            migrationBuilder.DropForeignKey(
                name: "FK_VaccineDate_Vaccine_VaccinesId",
                table: "VaccineDate");

            migrationBuilder.DropIndex(
                name: "IX_VaccineDate_PatientId",
                table: "VaccineDate");

            migrationBuilder.DropIndex(
                name: "IX_VaccineDate_VaccinesId",
                table: "VaccineDate");

            migrationBuilder.DropIndex(
                name: "IX_Patient_UserId",
                table: "Patient");

            migrationBuilder.DropIndex(
                name: "IX_Nurse_UserId",
                table: "Nurse");

            migrationBuilder.DropIndex(
                name: "IX_MedicalSpeciality_ConsultationId",
                table: "MedicalSpeciality");

            migrationBuilder.DropIndex(
                name: "IX_Manager_UserId",
                table: "Manager");

            migrationBuilder.DropIndex(
                name: "IX_Doctor_UserId",
                table: "Doctor");

            migrationBuilder.DropIndex(
                name: "IX_ConsultationDate_PatientId",
                table: "ConsultationDate");

            migrationBuilder.DropIndex(
                name: "IX_Consultation_DoctorId",
                table: "Consultation");

            migrationBuilder.DropIndex(
                name: "IX_Consultation_HealthCenterId",
                table: "Consultation");

            migrationBuilder.DropIndex(
                name: "IX_Attendant_UserId",
                table: "Attendant");

            migrationBuilder.DropIndex(
                name: "IX_Administrator_UserId",
                table: "Administrator");

            migrationBuilder.AlterColumn<string>(
                name: "PatientId",
                table: "VaccineDate",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "HealthCenterId",
                table: "VaccineDate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PatientId1",
                table: "VaccineDate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "VaccineId",
                table: "VaccineDate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "VaccineDateId",
                table: "Vaccine",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ConsultationDateId",
                table: "Patient",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "VaccineDateId",
                table: "Patient",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Manager",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ConsultationId",
                table: "HealthCenter",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ConsultationId",
                table: "Doctor",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "PatientId",
                table: "ConsultationDate",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "HealthCenterId",
                table: "ConsultationDate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PatientId1",
                table: "ConsultationDate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ConsultationDateId",
                table: "Consultation",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SpecialityId",
                table: "Consultation",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Attendant",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VaccineDate_PatientId1",
                table: "VaccineDate",
                column: "PatientId1");

            migrationBuilder.CreateIndex(
                name: "IX_VaccineDate_VaccineId",
                table: "VaccineDate",
                column: "VaccineId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_UserId",
                table: "Patient",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Nurse_UserId",
                table: "Nurse",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Manager_UserId",
                table: "Manager",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_UserId",
                table: "Doctor",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultationDate_PatientId1",
                table: "ConsultationDate",
                column: "PatientId1");

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
                name: "IX_Attendant_UserId",
                table: "Attendant",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Administrator_UserId",
                table: "Administrator",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Administrator_AspNetUsers_UserId",
                table: "Administrator",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendant_AspNetUsers_UserId",
                table: "Attendant",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultation_Doctor_DoctorId",
                table: "Consultation",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultation_HealthCenter_HealthCenterId",
                table: "Consultation",
                column: "HealthCenterId",
                principalTable: "HealthCenter",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultation_MedicalSpeciality_SpecialityId",
                table: "Consultation",
                column: "SpecialityId",
                principalTable: "MedicalSpeciality",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ConsultationDate_HealthCenter_HealthCenterId",
                table: "ConsultationDate",
                column: "HealthCenterId",
                principalTable: "HealthCenter",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ConsultationDate_Patient_PatientId1",
                table: "ConsultationDate",
                column: "PatientId1",
                principalTable: "Patient",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_AspNetUsers_UserId",
                table: "Doctor",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HealthCenter_Attendant_AttendantId",
                table: "HealthCenter",
                column: "AttendantId",
                principalTable: "Attendant",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HealthCenter_Doctor_DoctorId",
                table: "HealthCenter",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HealthCenter_Manager_ManagerId",
                table: "HealthCenter",
                column: "ManagerId",
                principalTable: "Manager",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HealthCenter_Nurse_NurseId",
                table: "HealthCenter",
                column: "NurseId",
                principalTable: "Nurse",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HealthCenter_Patient_PatientId",
                table: "HealthCenter",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Manager_AspNetUsers_UserId",
                table: "Manager",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalSpeciality_Doctor_DoctorId",
                table: "MedicalSpeciality",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Nurse_AspNetUsers_UserId",
                table: "Nurse",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_AspNetUsers_UserId",
                table: "Patient",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vaccine_HealthCenter_HealthCenterId",
                table: "Vaccine",
                column: "HealthCenterId",
                principalTable: "HealthCenter",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VaccineDate_HealthCenter_HealthCenterId",
                table: "VaccineDate",
                column: "HealthCenterId",
                principalTable: "HealthCenter",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VaccineDate_Patient_PatientId1",
                table: "VaccineDate",
                column: "PatientId1",
                principalTable: "Patient",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VaccineDate_Vaccine_VaccineId",
                table: "VaccineDate",
                column: "VaccineId",
                principalTable: "Vaccine",
                principalColumn: "Id");
        }
    }
}
