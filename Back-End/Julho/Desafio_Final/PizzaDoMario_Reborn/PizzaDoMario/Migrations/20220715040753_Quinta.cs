using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaDoMario.Migrations
{
    public partial class Quinta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusVenda",
                table: "Venda");

            migrationBuilder.AddColumn<int>(
                name: "StatusPedido",
                table: "Venda",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusPedido",
                table: "Venda");

            migrationBuilder.AddColumn<bool>(
                name: "StatusVenda",
                table: "Venda",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
