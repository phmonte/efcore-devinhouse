using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreCodeFirst.Migrations
{
    public partial class AlterandoEndereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contato_Proprietario_ProprietarioId",
                table: "Contato");

            migrationBuilder.DropForeignKey(
                name: "FK_imoveis_Endereco_EnderecoId",
                table: "imoveis");

            migrationBuilder.DropForeignKey(
                name: "FK_Proprietario_imoveis_ImovelId",
                table: "Proprietario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Proprietario",
                table: "Proprietario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contato",
                table: "Contato");

            migrationBuilder.RenameTable(
                name: "Proprietario",
                newName: "Proprietarios");

            migrationBuilder.RenameTable(
                name: "Endereco",
                newName: "enderecos_sistema");

            migrationBuilder.RenameTable(
                name: "Contato",
                newName: "Contatos");

            migrationBuilder.RenameIndex(
                name: "IX_Proprietario_ImovelId",
                table: "Proprietarios",
                newName: "IX_Proprietarios_ImovelId");

            migrationBuilder.RenameIndex(
                name: "IX_Contato_ProprietarioId",
                table: "Contatos",
                newName: "IX_Contatos_ProprietarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Proprietarios",
                table: "Proprietarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_enderecos_sistema",
                table: "enderecos_sistema",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contatos",
                table: "Contatos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contatos_Proprietarios_ProprietarioId",
                table: "Contatos",
                column: "ProprietarioId",
                principalTable: "Proprietarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_imoveis_enderecos_sistema_EnderecoId",
                table: "imoveis",
                column: "EnderecoId",
                principalTable: "enderecos_sistema",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Proprietarios_imoveis_ImovelId",
                table: "Proprietarios",
                column: "ImovelId",
                principalTable: "imoveis",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contatos_Proprietarios_ProprietarioId",
                table: "Contatos");

            migrationBuilder.DropForeignKey(
                name: "FK_imoveis_enderecos_sistema_EnderecoId",
                table: "imoveis");

            migrationBuilder.DropForeignKey(
                name: "FK_Proprietarios_imoveis_ImovelId",
                table: "Proprietarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Proprietarios",
                table: "Proprietarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_enderecos_sistema",
                table: "enderecos_sistema");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contatos",
                table: "Contatos");

            migrationBuilder.RenameTable(
                name: "Proprietarios",
                newName: "Proprietario");

            migrationBuilder.RenameTable(
                name: "enderecos_sistema",
                newName: "Endereco");

            migrationBuilder.RenameTable(
                name: "Contatos",
                newName: "Contato");

            migrationBuilder.RenameIndex(
                name: "IX_Proprietarios_ImovelId",
                table: "Proprietario",
                newName: "IX_Proprietario_ImovelId");

            migrationBuilder.RenameIndex(
                name: "IX_Contatos_ProprietarioId",
                table: "Contato",
                newName: "IX_Contato_ProprietarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Proprietario",
                table: "Proprietario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contato",
                table: "Contato",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contato_Proprietario_ProprietarioId",
                table: "Contato",
                column: "ProprietarioId",
                principalTable: "Proprietario",
                principalColumn: "Id");

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
                principalColumn: "id");
        }
    }
}
