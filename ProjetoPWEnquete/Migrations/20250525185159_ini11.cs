using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoPWEnquete.Migrations
{
    /// <inheritdoc />
    public partial class ini11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Enquetes");

            migrationBuilder.AlterColumn<string>(
                name: "descrição",
                table: "Enquetes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Question",
                table: "Enquetes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Option10Votes",
                table: "Enquetes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Option1Votes",
                table: "Enquetes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Option2Votes",
                table: "Enquetes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Option3Votes",
                table: "Enquetes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Option4Votes",
                table: "Enquetes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Option5Votes",
                table: "Enquetes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Option6Votes",
                table: "Enquetes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Option7Votes",
                table: "Enquetes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Option8Votes",
                table: "Enquetes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Option9Votes",
                table: "Enquetes",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Option10Votes",
                table: "Enquetes");

            migrationBuilder.DropColumn(
                name: "Option1Votes",
                table: "Enquetes");

            migrationBuilder.DropColumn(
                name: "Option2Votes",
                table: "Enquetes");

            migrationBuilder.DropColumn(
                name: "Option3Votes",
                table: "Enquetes");

            migrationBuilder.DropColumn(
                name: "Option4Votes",
                table: "Enquetes");

            migrationBuilder.DropColumn(
                name: "Option5Votes",
                table: "Enquetes");

            migrationBuilder.DropColumn(
                name: "Option6Votes",
                table: "Enquetes");

            migrationBuilder.DropColumn(
                name: "Option7Votes",
                table: "Enquetes");

            migrationBuilder.DropColumn(
                name: "Option8Votes",
                table: "Enquetes");

            migrationBuilder.DropColumn(
                name: "Option9Votes",
                table: "Enquetes");

            migrationBuilder.AlterColumn<string>(
                name: "descrição",
                table: "Enquetes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Question",
                table: "Enquetes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Enquetes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
