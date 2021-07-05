using Microsoft.EntityFrameworkCore.Migrations;

namespace BSPolyClinic.Infra.Migrations
{
    public partial class PolyClinicV10005 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: "1d4f0035-8448-4018-9a30-4d7b1b7b7aa9");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: "3ffe6a94-bda3-4821-aeed-60ddaa2962e7");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: "68377797-8fa8-49d9-a824-29441db5de3d");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: "6b2ee624-e125-4ab8-b866-a51d98aa40c3");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: "a7eb93ff-d311-4359-b73e-1924de699865");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: "b90efb92-b9a4-4c47-a6cf-e72fa01a0784");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Nurses",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Nurses");

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
        }
    }
}
