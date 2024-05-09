using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommanderGQL.Migrations
{
    /// <inheritdoc />
    public partial class AddCommandToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Commands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HowTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommandLine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlateformId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commands_Plateforms_PlateformId",
                        column: x => x.PlateformId,
                        principalTable: "Plateforms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commands_PlateformId",
                table: "Commands",
                column: "PlateformId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commands");
        }
    }
}
