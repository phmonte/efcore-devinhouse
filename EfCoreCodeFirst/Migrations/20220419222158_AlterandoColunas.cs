using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreCodeFirst.Migrations
{
    public partial class AlterandoColunas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "imoveis",
                newName: "titulo");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "imoveis",
                newName: "preco");

            migrationBuilder.RenameColumn(
                name: "Area",
                table: "imoveis",
                newName: "area");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "imoveis",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ValorCondominio",
                table: "imoveis",
                newName: "valor-condominio");

            migrationBuilder.RenameColumn(
                name: "DescricaoLonga",
                table: "imoveis",
                newName: "descricao_longa");

            migrationBuilder.RenameColumn(
                name: "DescricaoCurta",
                table: "imoveis",
                newName: "descricao_curta");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "imoveis",
                newName: "data_criacao");

            migrationBuilder.RenameColumn(
                name: "DataAtualizacao",
                table: "imoveis",
                newName: "data_atualizacao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "titulo",
                table: "imoveis",
                newName: "Titulo");

            migrationBuilder.RenameColumn(
                name: "preco",
                table: "imoveis",
                newName: "Preco");

            migrationBuilder.RenameColumn(
                name: "area",
                table: "imoveis",
                newName: "Area");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "imoveis",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "valor-condominio",
                table: "imoveis",
                newName: "ValorCondominio");

            migrationBuilder.RenameColumn(
                name: "descricao_longa",
                table: "imoveis",
                newName: "DescricaoLonga");

            migrationBuilder.RenameColumn(
                name: "descricao_curta",
                table: "imoveis",
                newName: "DescricaoCurta");

            migrationBuilder.RenameColumn(
                name: "data_criacao",
                table: "imoveis",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "data_atualizacao",
                table: "imoveis",
                newName: "DataAtualizacao");
        }
    }
}
