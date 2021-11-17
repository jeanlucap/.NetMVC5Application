using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesenvolvedorIO.Business.Core.Data;

namespace DesenvolvedorIO.Business.Models.Fornecedores
{
    public interface IEnderecoRepository: IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid id);
    }
}
