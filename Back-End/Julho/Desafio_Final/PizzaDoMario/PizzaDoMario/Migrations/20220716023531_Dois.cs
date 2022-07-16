using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaDoMario.Migrations
{
    public partial class Dois : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Venda",
                columns: table => new
                {
                    IdVenda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    IdProduto = table.Column<int>(type: "int", nullable: false),
                    valorTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    dataCompra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venda", x => x.IdVenda);
                    table.ForeignKey(
                        name: "FK_Venda_Cadastro Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cadastro Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Venda_CadastroProduto_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "CadastroProduto",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Venda_ClienteId",
                table: "Venda",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Venda_IdProduto",
                table: "Venda",
                column: "IdProduto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Venda");
        }
    }
}
