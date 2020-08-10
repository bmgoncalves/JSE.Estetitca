using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JSE.Web.Migrations
{
    public partial class InicialSite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Galerias",
                columns: table => new
                {
                    GaleriaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ServicoId = table.Column<int>(nullable: false),
                    NomeCliente = table.Column<string>(maxLength: 50, nullable: true),
                    Imagem = table.Column<string>(maxLength: 1000, nullable: true),
                    NomeArquivo = table.Column<string>(maxLength: 200, nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    Exibir = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galerias", x => x.GaleriaId);
                    table.ForeignKey(
                        name: "FK_Galerias_Servicos_ServicoId",
                        column: x => x.ServicoId,
                        principalTable: "Servicos",
                        principalColumn: "ServicoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Galerias_ServicoId",
                table: "Galerias",
                column: "ServicoId");

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Galerias");
        }
    }
}
