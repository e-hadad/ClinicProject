using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class onetomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "ListPatient");

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "ListPatient",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "city",
                table: "ListPatient");

            migrationBuilder.AddColumn<double>(
                name: "age",
                table: "ListPatient",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
