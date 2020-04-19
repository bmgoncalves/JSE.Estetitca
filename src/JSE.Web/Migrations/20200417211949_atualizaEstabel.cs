using Microsoft.EntityFrameworkCore.Migrations;

namespace JSE.Web.Migrations
{
    public partial class atualizaEstabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TelefoneComercial",
                table: "Estabelecimentos",
                maxLength: 18,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TelefoneCelular",
                table: "Estabelecimentos",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AddColumn<string>(
                name: "DescricaoSobreNos",
                table: "Estabelecimentos",
                maxLength: 3500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubTituloSobreNos",
                table: "Estabelecimentos",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TituloSobreNos",
                table: "Estabelecimentos",
                maxLength: 25,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescricaoSobreNos",
                table: "Estabelecimentos");

            migrationBuilder.DropColumn(
                name: "SubTituloSobreNos",
                table: "Estabelecimentos");

            migrationBuilder.DropColumn(
                name: "TituloSobreNos",
                table: "Estabelecimentos");

            migrationBuilder.AlterColumn<string>(
                name: "TelefoneComercial",
                table: "Estabelecimentos",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 18,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TelefoneCelular",
                table: "Estabelecimentos",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 18);
        }
    }
}
