using Microsoft.EntityFrameworkCore.Migrations;

namespace BSPolyClinic.Infra.Migrations
{
    public partial class PolyClinicV10002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "Jobs");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Jobs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jobs",
                table: "Jobs",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c4455a64-f370-42da-98b9-63e25e0f57b4", "740b26fc-639f-4c53-88bc-0a40c811a37c", "Administrador do sistema", "Administrator", "ADMINISTRATOR" },
                    { "614fab4d-aae8-41b8-8205-3a10867f4783", "64cf6680-506e-40fa-923b-cdf11b5f514d", "Gestor(a)", "Manager", "MANAGER" },
                    { "a911c6d8-4318-48e1-8413-51feb34d2aae", "51c5533b-46d9-4164-85f0-13db6a938e77", "Médico(a)", "Doctor", "DOCTOR" },
                    { "6aaf1cf8-d885-46bc-98f6-e888624f2775", "90b2358f-9dc6-45ed-80e0-7716b9f7de44", "Enfermeiro(a)", "Nurse", "NURSE" },
                    { "07e3e59c-71a1-4a82-b876-6594f2feba55", "7086759b-043f-418d-aeb9-8d762a300b68", "Atendente", "Attendant", "ATTENDANT" },
                    { "e5bbce29-fda0-49ab-9dac-8a3c14cd026d", "c5393411-b14a-4915-9b5d-d2b61f0d46f9", "Paciente", "Patient", "PATIENT" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_Jobs_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_Jobs_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_Jobs_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_Jobs_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jobs",
                table: "Jobs");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: "07e3e59c-71a1-4a82-b876-6594f2feba55");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: "614fab4d-aae8-41b8-8205-3a10867f4783");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: "6aaf1cf8-d885-46bc-98f6-e888624f2775");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: "a911c6d8-4318-48e1-8413-51feb34d2aae");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: "c4455a64-f370-42da-98b9-63e25e0f57b4");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: "e5bbce29-fda0-49ab-9dac-8a3c14cd026d");

            migrationBuilder.RenameTable(
                name: "Jobs",
                newName: "AspNetRoles");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
