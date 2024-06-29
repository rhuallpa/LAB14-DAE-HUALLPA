using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab13_6C24B_DAEA.Migrations
{
    /// <inheritdoc />
    public partial class v2_crearbasededatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "Grades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Courses");
        }
    }
}
