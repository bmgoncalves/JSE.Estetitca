using Microsoft.EntityFrameworkCore.Migrations;

namespace JSE.Web.Migrations
{
    public partial class atualizaEstabel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InscricaoEstadual",
                table: "Estabelecimentos",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InscricaoMunicipal",
                table: "Estabelecimentos",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InscricaoEstadual",
                table: "Estabelecimentos");

            migrationBuilder.DropColumn(
                name: "InscricaoMunicipal",
                table: "Estabelecimentos");
        }
    }
}
