using Microsoft.EntityFrameworkCore.Migrations;

namespace JSE.Web.Migrations
{
    public partial class imagemDepoimento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imagem",
                table: "Depoimentos",
                maxLength: 250,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Depoimentos");
        }
    }
}
