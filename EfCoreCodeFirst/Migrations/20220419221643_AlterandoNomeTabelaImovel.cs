using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreCodeFirst.Migrations
{
    public partial class AlterandoNomeTabelaImovel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imoveis_Endereco_EnderecoId",
                table: "Imoveis");

            migrationBuilder.DropForeignKey(
                name: "FK_Proprietario_Imoveis_ImovelId",
                table: "Proprietario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Imoveis",
                table: "Imoveis");

            migrationBuilder.RenameTable(
                name: "Imoveis",
                newName: "imoveis");

            migrationBuilder.RenameIndex(
                name: "IX_Imoveis_EnderecoId",
                table: "imoveis",
                newName: "IX_imoveis_EnderecoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_imoveis",
                table: "imoveis",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_imoveis_Endereco_EnderecoId",
                table: "imoveis",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Proprietario_imoveis_ImovelId",
                table: "Proprietario",
                column: "ImovelId",
                principalTable: "imoveis",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_imoveis_Endereco_EnderecoId",
                table: "imoveis");

            migrationBuilder.DropForeignKey(
                name: "FK_Proprietario_imoveis_ImovelId",
                table: "Proprietario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_imoveis",
                table: "imoveis");

            migrationBuilder.RenameTable(
                name: "imoveis",
                newName: "Imoveis");

            migrationBuilder.RenameIndex(
                name: "IX_imoveis_EnderecoId",
                table: "Imoveis",
                newName: "IX_Imoveis_EnderecoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Imoveis",
                table: "Imoveis",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Imoveis_Endereco_EnderecoId",
                table: "Imoveis",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Proprietario_Imoveis_ImovelId",
                table: "Proprietario",
                column: "ImovelId",
                principalTable: "Imoveis",
                principalColumn: "Id");
        }
    }
}
