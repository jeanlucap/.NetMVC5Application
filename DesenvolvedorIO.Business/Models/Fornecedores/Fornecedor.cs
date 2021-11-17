using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesenvolvedorIO.Business.Core.Models;
using DesenvolvedorIO.Business.Models.Produtos;
using DesenvolvedorIO.Business.Models.Fornecedores.Validations;

namespace DesenvolvedorIO.Business.Models.Fornecedores
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        public ICollection<Produto> Produtos { get; set; }

        public bool Validacao()
        {
            var validacao = new FornecedorValidation();
            var resultado = validacao.Validate(this);

            return resultado.IsValid;
        }
}