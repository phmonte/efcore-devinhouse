using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreCodeFirst.Migrations
{
    public partial class Nullable13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_imoveis_enderecos_sistema_endereco",
                table: "imoveis");

            migrationBuilder.RenameColumn(
                name: "endereco",
                table: "imoveis",
                newName: "EnderecoId");

            migrationBuilder.RenameIndex(
                name: "IX_imoveis_endereco",
                table: "imoveis",
                newName: "IX_imoveis_EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_imoveis_enderecos_sistema_EnderecoId",
                table: "imoveis",
                column: "EnderecoId",
                principalTable: "enderecos_sistema",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_imoveis_enderecos_sistema_EnderecoId",
                table: "imoveis");

            migrationBuilder.RenameColumn(
                name: "EnderecoId",
                table: "imoveis",
                newName: "endereco");

            migrationBuilder.RenameIndex(
                name: "IX_imoveis_EnderecoId",
                table: "imoveis",
                newName: "IX_imoveis_endereco");

            migrationBuilder.AddForeignKey(
                name: "FK_imoveis_enderecos_sistema_endereco",
                table: "imoveis",
                column: "endereco",
                principalTable: "enderecos_sistema",
                principalColumn: "Id");
        }
    }
}
