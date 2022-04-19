using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreCodeFirst.Migrations
{
    public partial class AlterandoEnderecoNovoNome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UF",
                table: "enderecos_sistema",
                newName: "uf");

            migrationBuilder.RenameColumn(
                name: "Rua",
                table: "enderecos_sistema",
                newName: "rua");

            migrationBuilder.RenameColumn(
                name: "Referencia",
                table: "enderecos_sistema",
                newName: "referencia");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "enderecos_sistema",
                newName: "numero");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "enderecos_sistema",
                newName: "cidade");

            migrationBuilder.RenameColumn(
                name: "CEP",
                table: "enderecos_sistema",
                newName: "cep");

            migrationBuilder.RenameColumn(
                name: "Bairro",
                table: "enderecos_sistema",
                newName: "bairro");

            migrationBuilder.AlterColumn<string>(
                name: "uf",
                table: "enderecos_sistema",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "rua",
                table: "enderecos_sistema",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "referencia",
                table: "enderecos_sistema",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "numero",
                table: "enderecos_sistema",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "cidade",
                table: "enderecos_sistema",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "bairro",
                table: "enderecos_sistema",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "uf",
                table: "enderecos_sistema",
                newName: "UF");

            migrationBuilder.RenameColumn(
                name: "rua",
                table: "enderecos_sistema",
                newName: "Rua");

            migrationBuilder.RenameColumn(
                name: "referencia",
                table: "enderecos_sistema",
                newName: "Referencia");

            migrationBuilder.RenameColumn(
                name: "numero",
                table: "enderecos_sistema",
                newName: "Numero");

            migrationBuilder.RenameColumn(
                name: "cidade",
                table: "enderecos_sistema",
                newName: "Cidade");

            migrationBuilder.RenameColumn(
                name: "cep",
                table: "enderecos_sistema",
                newName: "CEP");

            migrationBuilder.RenameColumn(
                name: "bairro",
                table: "enderecos_sistema",
                newName: "Bairro");

            migrationBuilder.AlterColumn<string>(
                name: "UF",
                table: "enderecos_sistema",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Rua",
                table: "enderecos_sistema",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Referencia",
                table: "enderecos_sistema",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "enderecos_sistema",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "enderecos_sistema",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "enderecos_sistema",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
