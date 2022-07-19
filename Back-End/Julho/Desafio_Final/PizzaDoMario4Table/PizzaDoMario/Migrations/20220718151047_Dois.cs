using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaDoMario.Migrations
{
    public partial class Dois : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemVenda_Cadastro Cliente_CadastroClienteIdCliente",
                table: "ItemVenda");

            migrationBuilder.RenameColumn(
                name: "CadastroClienteIdCliente",
                table: "ItemVenda",
                newName: "IdCliente");

            migrationBuilder.RenameIndex(
                name: "IX_ItemVenda_CadastroClienteIdCliente",
                table: "ItemVenda",
                newName: "IX_ItemVenda_IdCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemVenda_Cadastro Cliente_IdCliente",
                table: "ItemVenda",
                column: "IdCliente",
                principalTable: "Cadastro Cliente",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemVenda_Cadastro Cliente_IdCliente",
                table: "ItemVenda");

            migrationBuilder.RenameColumn(
                name: "IdCliente",
                table: "ItemVenda",
                newName: "CadastroClienteIdCliente");

            migrationBuilder.RenameIndex(
                name: "IX_ItemVenda_IdCliente",
                table: "ItemVenda",
                newName: "IX_ItemVenda_CadastroClienteIdCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemVenda_Cadastro Cliente_CadastroClienteIdCliente",
                table: "ItemVenda",
                column: "CadastroClienteIdCliente",
                principalTable: "Cadastro Cliente",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
