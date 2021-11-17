using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesenvolvedorIO.Business.Core.Models;

namespace DesenvolvedorIO.Business.Models.Fornecedores
{
    public class Endereco : Entity
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Fornecedor Fornecedor { get; set; }
    }
}
