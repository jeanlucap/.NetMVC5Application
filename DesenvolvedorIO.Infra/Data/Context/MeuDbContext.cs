using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DesenvolvedorIO.Business.Models.Fornecedores;
using DesenvolvedorIO.Business.Models.Produtos;
using DesenvolvedorIO.Infra.Data.Mappings;

namespace DesenvolvedorIO.Infra.Data.Context
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext() : base(nameOrConnectionString: "DefaultConnection")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p
                .HasColumnType("varchar")
                .HasMaxLength(100));

            modelBuilder.Configurations.Add(new FornecedorConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());
            modelBuilder.Configurations.Add(new ProdutoConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
