using JSE.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Infrastructure.Internal;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace JSE.Web.Data
{
    public class JSEContext : DbContext
    {
        private string _connectionString;

        public JSEContext()
        {

        }
        public JSEContext(DbContextOptions<JSEContext> options) : base(options)
        {

        }

        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Depoimento> Depoimentos { get; set; }
        public DbSet<Estabelecimento> Estabelecimentos { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<ServicoCategoria> ServicoCategorias { get; set; }
        public DbSet<Galeria> Galerias { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Servico>().Ignore(s => s.File); //Ignorar propriedade

            //modelBuilder.Entity<Servico>().HasOne(s => s.id)
            //    .HasOne(p => p.CategoriaId)
            //    .WithMany(b => b.Id)
            //    .HasForeignKey(p => p.BlogId)
            //    .HasConstraintName("ForeignKey_Post_Blog");
        }


        public void ResourceDbContext(DbContextOptions<JSEContext> options)
        {
            _connectionString = ((SqlServerOptionsExtension)options.Extensions.First()).ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

        }
    }
}
