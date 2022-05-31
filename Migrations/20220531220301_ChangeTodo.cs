using Microsoft.EntityFrameworkCore.Migrations;

namespace Api_Teste0001.Migrations
{
    public partial class ChangeTodo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tittle",
                table: "Todos",
                newName: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Todos",
                newName: "Tittle");
        }
    }
}
