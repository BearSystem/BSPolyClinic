using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BSPolyClinic.Infra.Migrations
{
    public partial class PolyClinicV10006 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: "338bb9a3-f0c6-4b9e-a257-8e35ab9d6e12");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: "3e4412a1-a402-4b76-9ed1-d1443f1c2c53");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: "74fa8119-66d9-46ef-a829-5d77f827a382");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: "b1818bd3-9448-4668-bc6e-cb7d960e540b");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: "c84478f4-cc8b-4173-af1c-7b2ca007c725");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: "d7d89ed3-43de-47df-b976-51af4d1a0125");

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c6594c77-5cc3-4f94-890c-6aa98544a6b8", "d7f2c912-6a72-45df-8879-02474762804b", "Administrador do sistema", "Administrator", "ADMINISTRATOR" },
                    { "2e96bf96-6e74-431c-b228-7d6ae210ae7f", "c0744b9e-249a-4347-b764-6d4d869e7cb0", "Gestor(a)", "Manager", "MANAGER" },
                    { "72311507-ce90-49cb-987d-5581b64e3cb8", "0032091f-d2a5-4fac-97f9-8f416d36521c", "Médico(a)", "Doctor", "DOCTOR" },
                    { "2374b9a3-ebcf-4250-a79c-73b280429306", "d6e9c15a-d1ab-4bda-9c04-61de914b7b80", "Enfermeiro(a)", "Nurse", "NURSE" },
                    { "ce2ddba7-1d3b-4eb5-aad1-9c5344a69190", "bd6e42b1-e2ca-4458-9048-dc58627e3d43", "Atendente", "Attendant", "ATTENDANT" },
                    { "462a7f79-e5dc-4f4c-b8d2-6196a5d4dd87", "c7051a67-8791-4c2f-8b8f-d1e11912d1d5", "Paciente", "Patient", "PATIENT" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: "2374b9a3-ebcf-4250-a79c-73b280429306");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: "2e96bf96-6e74-431c-b228-7d6ae210ae7f");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: "462a7f79-e5dc-4f4c-b8d2-6196a5d4dd87");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: "72311507-ce90-49cb-987d-5581b64e3cb8");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: "c6594c77-5cc3-4f94-890c-6aa98544a6b8");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: "ce2ddba7-1d3b-4eb5-aad1-9c5344a69190");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "74fa8119-66d9-46ef-a829-5d77f827a382", "6581bab2-57eb-420f-a0ab-d8b067898ad3", "Administrador do sistema", "Administrator", "ADMINISTRATOR" },
                    { "c84478f4-cc8b-4173-af1c-7b2ca007c725", "283ee2f7-ec0c-44d1-ab29-5d2783c67f53", "Gestor(a)", "Manager", "MANAGER" },
                    { "338bb9a3-f0c6-4b9e-a257-8e35ab9d6e12", "157b4d00-c4f0-4a47-b702-c6f0ebbe5e7d", "Médico(a)", "Doctor", "DOCTOR" },
                    { "d7d89ed3-43de-47df-b976-51af4d1a0125", "3c02e66a-a93c-4c34-9db7-8aedec6bd532", "Enfermeiro(a)", "Nurse", "NURSE" },
                    { "3e4412a1-a402-4b76-9ed1-d1443f1c2c53", "0c687d09-a9a6-4b96-a418-9918daba30c3", "Atendente", "Attendant", "ATTENDANT" },
                    { "b1818bd3-9448-4668-bc6e-cb7d960e540b", "4a80daa1-2530-4436-86fb-48a8c4587c2c", "Paciente", "Patient", "PATIENT" }
                });
        }
    }
}
