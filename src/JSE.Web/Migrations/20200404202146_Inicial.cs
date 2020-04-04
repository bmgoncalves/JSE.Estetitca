using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JSE.Web.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Mensagem = table.Column<string>(maxLength: 2000, nullable: true),
                    Telefone = table.Column<string>(maxLength: 15, nullable: true),
                    ContatoWhatsapp = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Depoimentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(nullable: false),
                    Autor = table.Column<string>(maxLength: 50, nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depoimentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estabelecimentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFantasia = table.Column<string>(maxLength: 50, nullable: false),
                    Endereco = table.Column<string>(maxLength: 50, nullable: false),
                    Bairro = table.Column<string>(maxLength: 20, nullable: false),
                    Cidade = table.Column<string>(maxLength: 20, nullable: false),
                    Complemento = table.Column<string>(maxLength: 20, nullable: true),
                    CEP = table.Column<string>(maxLength: 11, nullable: false),
                    UF = table.Column<string>(maxLength: 2, nullable: false),
                    Pais = table.Column<string>(maxLength: 30, nullable: false),
                    TelefoneComercial = table.Column<string>(maxLength: 15, nullable: true),
                    TelefoneCelular = table.Column<string>(maxLength: 15, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    CNPJ = table.Column<string>(maxLength: 50, nullable: false),
                    UrlInstagram = table.Column<string>(maxLength: 200, nullable: true),
                    UrlFacebook = table.Column<string>(maxLength: 200, nullable: true),
                    UrlYoutube = table.Column<string>(maxLength: 200, nullable: true),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estabelecimentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeServico = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contatos");

            migrationBuilder.DropTable(
                name: "Depoimentos");

            migrationBuilder.DropTable(
                name: "Estabelecimentos");

            migrationBuilder.DropTable(
                name: "Servicos");
        }
    }
}
