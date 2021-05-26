using Microsoft.EntityFrameworkCore.Migrations;

namespace BSPolyClinic.Infra.Migrations
{
    public partial class PolyClinicV1002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Patient_UserId",
                table: "Patient");

            migrationBuilder.DropIndex(
                name: "IX_Nurse_UserId",
                table: "Nurse");

            migrationBuilder.DropIndex(
                name: "IX_Doctor_UserId",
                table: "Doctor");

            migrationBuilder.DropIndex(
                name: "IX_Administrator_UserId",
                table: "Administrator");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Nurse",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Doctor",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Administrator",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
                name: "IX_Doctor_UserId",
                table: "Doctor",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Administrator_UserId",
                table: "Administrator",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Patient_UserId",
                table: "Patient");

            migrationBuilder.DropIndex(
                name: "IX_Nurse_UserId",
                table: "Nurse");

            migrationBuilder.DropIndex(
                name: "IX_Doctor_UserId",
                table: "Doctor");

            migrationBuilder.DropIndex(
                name: "IX_Administrator_UserId",
                table: "Administrator");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Nurse",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Doctor",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Administrator",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patient_UserId",
                table: "Patient",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Nurse_UserId",
                table: "Nurse",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_UserId",
                table: "Doctor",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Administrator_UserId",
                table: "Administrator",
                column: "UserId",
                unique: true);
        }
    }
}
