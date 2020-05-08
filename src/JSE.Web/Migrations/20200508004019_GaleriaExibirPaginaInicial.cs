using Microsoft.EntityFrameworkCore.Migrations;

namespace JSE.Web.Migrations
{
    public partial class GaleriaExibirPaginaInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Exibir",
                table: "Galerias",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Exibir",
                table: "Galerias");
        }
    }
}
