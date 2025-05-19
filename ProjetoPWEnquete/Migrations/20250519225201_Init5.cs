using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoPWEnquete.Migrations
{
    /// <inheritdoc />
    public partial class Init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Votos");

            migrationBuilder.DropTable(
                name: "OpEnquetes");

            migrationBuilder.AddColumn<string>(
                name: "Options",
                table: "Enquetes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddColumn<string>(
                name: "OptionsJson",
                table: "Enquetes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Options",
                table: "Enquetes");

            migrationBuilder.DropColumn(
                name: "OptionsJson",
                table: "Enquetes");

            migrationBuilder.CreateTable(
                name: "OpEnquetes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    enqueteId = table.Column<int>(type: "int", nullable: false),
                    OptionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PollId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpEnquetes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpEnquetes_Enquetes_enqueteId",
                        column: x => x.enqueteId,
                        principalTable: "Enquetes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Votos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    openquetesId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    openqutesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Votos_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Votos_OpEnquetes_openquetesId",
                        column: x => x.openquetesId,
                        principalTable: "OpEnquetes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OpEnquetes_enqueteId",
                table: "OpEnquetes",
                column: "enqueteId");

            migrationBuilder.CreateIndex(
                name: "IX_Votos_openquetesId",
                table: "Votos",
                column: "openquetesId");

            migrationBuilder.CreateIndex(
                name: "IX_Votos_UserId",
                table: "Votos",
                column: "UserId");
        }
    }
}
