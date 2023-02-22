using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentPortal.Migrations
{
    /// <inheritdoc />
    public partial class ageRmvPinName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Parents");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Parents",
                newName: "PLastName");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Parents",
                newName: "PFirstName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PLastName",
                table: "Parents",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "PFirstName",
                table: "Parents",
                newName: "Gender");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
