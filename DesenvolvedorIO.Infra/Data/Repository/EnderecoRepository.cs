using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesenvolvedorIO.Business.Models.Fornecedores;
using System.Data.Entity;

namespace DesenvolvedorIO.Infra.Data.Repository
{
    public class EndereoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await ObterPorId(fornecedorId;
        }
    }
}
