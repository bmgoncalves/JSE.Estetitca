using Microsoft.EntityFrameworkCore.Migrations;

namespace JSE.Web.Migrations
{
    public partial class GaleriaXServico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Galerias_ServicoId",
                table: "Galerias",
                column: "ServicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Galerias_Servicos_ServicoId",
                table: "Galerias",
                column: "ServicoId",
                principalTable: "Servicos",
                principalColumn: "ServicoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Galerias_Servicos_ServicoId",
                table: "Galerias");

            migrationBuilder.DropIndex(
                name: "IX_Galerias_ServicoId",
                table: "Galerias");
        }
    }
}
