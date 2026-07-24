using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Migrations
{
    /// <inheritdoc />
    public partial class mig_category_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "TechStacks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TechStacks_CategoryID",
                table: "TechStacks",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_TechStacks_Categories_CategoryID",
                table: "TechStacks",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TechStacks_Categories_CategoryID",
                table: "TechStacks");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_TechStacks_CategoryID",
                table: "TechStacks");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "TechStacks");
        }
    }
}
