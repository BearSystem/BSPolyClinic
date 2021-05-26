using Microsoft.EntityFrameworkCore.Migrations;

namespace BSPolyClinic.Infra.Migrations
{
    public partial class PolyClinicV1003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "AspNetRoles");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "AspNetRoles",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "AspNetRoles",
                newName: "Descricao");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "AspNetRoles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
