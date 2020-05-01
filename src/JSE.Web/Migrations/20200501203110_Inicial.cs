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
                    Mensagem = table.Column<string>(maxLength: 2000, nullable: false),
                    Email = table.Column<string>(maxLength: 70, nullable: false),
                    Telefone = table.Column<string>(maxLength: 15, nullable: false),
                    ContatoWhatsapp = table.Column<bool>(nullable: false),
                    DataHora = table.Column<DateTime>(nullable: false),
                    Pendente = table.Column<bool>(nullable: false)
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
                    Descricao = table.Column<string>(maxLength: 2000, nullable: false),
                    NomeCliente = table.Column<string>(maxLength: 50, nullable: false),
                    TelefoneCelular = table.Column<string>(maxLength: 18, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Imagem = table.Column<string>(maxLength: 250, nullable: true),
                    NomeArquivo = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    Aprovado = table.Column<bool>(nullable: false)
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
                    TelefoneComercial = table.Column<string>(maxLength: 18, nullable: true),
                    TelefoneCelular = table.Column<string>(maxLength: 18, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    CNPJ = table.Column<string>(maxLength: 50, nullable: false),
                    InscricaoEstadual = table.Column<string>(maxLength: 50, nullable: true),
                    InscricaoMunicipal = table.Column<string>(maxLength: 50, nullable: true),
                    UrlInstagram = table.Column<string>(maxLength: 200, nullable: true),
                    UrlFacebook = table.Column<string>(maxLength: 200, nullable: true),
                    UrlYoutube = table.Column<string>(maxLength: 200, nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    TituloSobreNos = table.Column<string>(maxLength: 40, nullable: true),
                    SubTituloSobreNos = table.Column<string>(maxLength: 40, nullable: true),
                    DescricaoSobreNos = table.Column<string>(maxLength: 3500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estabelecimentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServicoCategorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categoria = table.Column<string>(maxLength: 50, nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicoCategorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeServico = table.Column<string>(maxLength: 50, nullable: false),
                    CategoriaId = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 2500, nullable: false),
                    Duracao = table.Column<string>(maxLength: 8, nullable: true),
                    Imagem = table.Column<string>(maxLength: 400, nullable: true),
                    NomeArquivo = table.Column<string>(maxLength: 50, nullable: true),
                    ExibeIndex = table.Column<bool>(nullable: false),
                    ServicoCategoriaCategoriaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servicos_ServicoCategorias_ServicoCategoriaCategoriaId",
                        column: x => x.ServicoCategoriaCategoriaId,
                        principalTable: "ServicoCategorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_ServicoCategoriaCategoriaId",
                table: "Servicos",
                column: "ServicoCategoriaCategoriaId");
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

            migrationBuilder.DropTable(
                name: "ServicoCategorias");
        }
    }
}
