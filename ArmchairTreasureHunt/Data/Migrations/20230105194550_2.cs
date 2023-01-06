using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArmchairTreasureHunt.Data.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Notebook3",
                newName: "Password1");

            migrationBuilder.RenameColumn(
                name: "Passcode",
                table: "Notebook3",
                newName: "Password2");

            migrationBuilder.RenameColumn(
                name: "Passcode",
                table: "Notebook2",
                newName: "Password2");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Notebook1",
                newName: "Password1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password2",
                table: "Notebook3",
                newName: "Passcode");

            migrationBuilder.RenameColumn(
                name: "Password1",
                table: "Notebook3",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Password2",
                table: "Notebook2",
                newName: "Passcode");

            migrationBuilder.RenameColumn(
                name: "Password1",
                table: "Notebook1",
                newName: "Password");
        }
    }
}
