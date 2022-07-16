using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaDoMario.Migrations
{
    public partial class Um : Migration
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
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cadastro Cliente");

            migrationBuilder.DropTable(
                name: "CadastroProduto");
        }
    }
}
