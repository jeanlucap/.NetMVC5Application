using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesenvolvedorIO.Business.Core.Models;
using DesenvolvedorIO.Business.Models.Fornecedores;

namespace DesenvolvedorIO.Business.Models.Produtos
{
    public class Produto : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public Guid FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}
