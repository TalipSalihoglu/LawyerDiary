using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class updateToDosTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "ToDos");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ToDos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ToDos_LawyerId",
                table: "ToDos",
                column: "LawyerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDos_Lawyers_LawyerId",
                table: "ToDos",
                column: "LawyerId",
                principalTable: "Lawyers",
                principalColumn: "LawyerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDos_Lawyers_LawyerId",
                table: "ToDos");

            migrationBuilder.DropIndex(
                name: "IX_ToDos_LawyerId",
                table: "ToDos");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ToDos");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "ToDos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
