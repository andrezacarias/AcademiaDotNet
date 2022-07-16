using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaDoMario.Migrations
{
    public partial class Quarta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "StatusVenda",
                table: "Venda",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusVenda",
                table: "Venda");
        }
    }
}
