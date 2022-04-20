using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreCodeFirst.Migrations
{
    public partial class Nullable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_imoveis_enderecos_sistema_endereco",
                table: "imoveis");

            migrationBuilder.AlterColumn<int>(
                name: "endereco",
                table: "imoveis",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_imoveis_enderecos_sistema_endereco",
                table: "imoveis",
                column: "endereco",
                principalTable: "enderecos_sistema",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_imoveis_enderecos_sistema_endereco",
                table: "imoveis");

            migrationBuilder.AlterColumn<int>(
                name: "endereco",
                table: "imoveis",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_imoveis_enderecos_sistema_endereco",
                table: "imoveis",
                column: "endereco",
                principalTable: "enderecos_sistema",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
