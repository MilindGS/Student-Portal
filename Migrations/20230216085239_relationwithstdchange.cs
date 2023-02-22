using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentPortal.Migrations
{
    /// <inheritdoc />
    public partial class relationwithstdchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RelationWithStudent",
                table: "Parents");

            migrationBuilder.AddColumn<string>(
                name: "RelationWithStudent",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RelationWithStudent",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "RelationWithStudent",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
