using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaDoMario.Migrations
{
    public partial class Nova : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venda_CadastroProduto_CadastroProdutoIdProduto",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Venda_CadastroProdutoIdProduto",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "CadastroProdutoIdProduto",
                table: "Venda");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CadastroProdutoIdProduto",
                table: "Venda",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Venda_CadastroProdutoIdProduto",
                table: "Venda",
                column: "CadastroProdutoIdProduto");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_CadastroProduto_CadastroProdutoIdProduto",
                table: "Venda",
                column: "CadastroProdutoIdProduto",
                principalTable: "CadastroProduto",
                principalColumn: "IdProduto",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
