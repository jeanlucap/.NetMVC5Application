using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using DesenvolvedorIO.Business.Models.Produtos;


namespace DesenvolvedorIO.Infra.Data.Mappings
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
       public ProdutoConfig()
        {
            HasKey(p => p.Id);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(200);

            Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(1000);

            Property(c => c.Imagem)
                .IsRequired()
                .HasMaxLength(1000);

            HasRequired(p => p.Fornecedor)
                .WithMany(f => f.Produtos)
                .HasForeignKey(p => p.FornecedorId);

            ToTable("Produtos");
        }
    }
}
