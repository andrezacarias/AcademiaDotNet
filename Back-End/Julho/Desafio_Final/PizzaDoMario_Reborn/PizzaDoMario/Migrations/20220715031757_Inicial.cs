using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaDoMario.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cadastro Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    complemento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadastro Cliente", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "CadastroProduto",
                columns: table => new
                {
                    IdProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeProduto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    preco = table.Column<float>(type: "real", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroProduto", x => x.IdProduto);
                });

            migrationBuilder.CreateTable(
                name: "Venda",
                columns: table => new
                {
                    IdVenda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    valorTotal = table.Column<float>(type: "real", nullable: false),
                    dataCompra = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                });

            migrationBuilder.CreateIndex(
                name: "IX_Venda_ClienteId",
                table: "Venda",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CadastroProduto");

            migrationBuilder.DropTable(
                name: "Venda");

            migrationBuilder.DropTable(
                name: "Cadastro Cliente");
        }
    }
}
