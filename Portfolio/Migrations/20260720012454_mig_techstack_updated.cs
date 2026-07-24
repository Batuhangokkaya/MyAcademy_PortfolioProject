using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Migrations
{
    /// <inheritdoc />
    public partial class mig_techstack_updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TechStacks_Categories_CategoryID",
                table: "TechStacks");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "TechStacks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TechStacks_Categories_CategoryID",
                table: "TechStacks",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TechStacks_Categories_CategoryID",
                table: "TechStacks");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "TechStacks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TechStacks_Categories_CategoryID",
                table: "TechStacks",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID");
        }
    }
}
