using Microsoft.EntityFrameworkCore.Migrations;

namespace GlobalGames.Migrations
{
    public partial class AddChangesToControllerAndHtml : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Budgets",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Budgets",
                newName: "Descricao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Budgets",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Budgets",
                newName: "Description");
        }
    }
}
