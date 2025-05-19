using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoPWEnquete.Migrations
{
    /// <inheritdoc />
    public partial class Init6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Options",
                table: "Enquetes");

            migrationBuilder.DropColumn(
                name: "OptionsJson",
                table: "Enquetes");

            migrationBuilder.AddColumn<string>(
                name: "Option1",
                table: "Enquetes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Option10",
                table: "Enquetes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Option2",
                table: "Enquetes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Option3",
                table: "Enquetes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Option4",
                table: "Enquetes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Option5",
                table: "Enquetes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Option6",
                table: "Enquetes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Option7",
                table: "Enquetes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Option8",
                table: "Enquetes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Option9",
                table: "Enquetes",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Option1",
                table: "Enquetes");

            migrationBuilder.DropColumn(
                name: "Option10",
                table: "Enquetes");

            migrationBuilder.DropColumn(
                name: "Option2",
                table: "Enquetes");

            migrationBuilder.DropColumn(
                name: "Option3",
                table: "Enquetes");

            migrationBuilder.DropColumn(
                name: "Option4",
                table: "Enquetes");

            migrationBuilder.DropColumn(
                name: "Option5",
                table: "Enquetes");

            migrationBuilder.DropColumn(
                name: "Option6",
                table: "Enquetes");

            migrationBuilder.DropColumn(
                name: "Option7",
                table: "Enquetes");

            migrationBuilder.DropColumn(
                name: "Option8",
                table: "Enquetes");

            migrationBuilder.DropColumn(
                name: "Option9",
                table: "Enquetes");

            migrationBuilder.AddColumn<string>(
                name: "Options",
                table: "Enquetes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OptionsJson",
                table: "Enquetes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
