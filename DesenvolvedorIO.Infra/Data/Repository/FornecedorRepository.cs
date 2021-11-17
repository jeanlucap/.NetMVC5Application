using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesenvolvedorIO.Business.Models.Fornecedores;
using System.Data.Entity;

namespace DesenvolvedorIO.Infra.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(f => f.Endereco)
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutoEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(f => f.Endereco)
                .Include(f => f.Produtos)
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        public Fornecedor Teste()
        {
            return Buscar(f => f.Ativo && f.Documento == "" && f.Nome = "").Result.FirstOrDefault();
        }
    }
}
