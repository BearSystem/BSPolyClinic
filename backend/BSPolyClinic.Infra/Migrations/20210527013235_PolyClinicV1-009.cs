using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BSPolyClinic.Infra.Migrations
{
    public partial class PolyClinicV1009 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConsultationDate_HealthCenter_HealthCenterId",
                table: "ConsultationDate");

            migrationBuilder.DropForeignKey(
                name: "FK_HealthCenter_Doctor_DoctorId",
                table: "HealthCenter");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalSpeciality_Doctor_DoctorId",
                table: "MedicalSpeciality");

            migrationBuilder.DropForeignKey(
                name: "FK_VaccineDate_HealthCenter_HealthCenterId",
                table: "VaccineDate");

            migrationBuilder.DropIndex(
                name: "IX_VaccineDate_HealthCenterId",
                table: "VaccineDate");

            migrationBuilder.DropIndex(
                name: "IX_ConsultationDate_HealthCenterId",
                table: "ConsultationDate");

            migrationBuilder.DropColumn(
                name: "HealthCenterId",
                table: "VaccineDate");

            migrationBuilder.DropColumn(
                name: "ConsultationDateId",
                table: "HealthCenter");

            migrationBuilder.DropColumn(
                name: "VaccineDateId",
                table: "HealthCenter");

            migrationBuilder.DropColumn(
                name: "HealthCenterId",
                table: "ConsultationDate");

            migrationBuilder.AddForeignKey(
                name: "FK_HealthCenter_Doctor_DoctorId",
                table: "HealthCenter",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalSpeciality_Doctor_DoctorId",
                table: "MedicalSpeciality",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HealthCenter_Doctor_DoctorId",
                table: "HealthCenter");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalSpeciality_Doctor_DoctorId",
                table: "MedicalSpeciality");

            migrationBuilder.AddColumn<Guid>(
                name: "HealthCenterId",
                table: "VaccineDate",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ConsultationDateId",
                table: "HealthCenter",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "VaccineDateId",
                table: "HealthCenter",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "HealthCenterId",
                table: "ConsultationDate",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VaccineDate_HealthCenterId",
                table: "VaccineDate",
                column: "HealthCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultationDate_HealthCenterId",
                table: "ConsultationDate",
                column: "HealthCenterId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConsultationDate_HealthCenter_HealthCenterId",
                table: "ConsultationDate",
                column: "HealthCenterId",
                principalTable: "HealthCenter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HealthCenter_Doctor_DoctorId",
                table: "HealthCenter",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalSpeciality_Doctor_DoctorId",
                table: "MedicalSpeciality",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VaccineDate_HealthCenter_HealthCenterId",
                table: "VaccineDate",
                column: "HealthCenterId",
                principalTable: "HealthCenter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
