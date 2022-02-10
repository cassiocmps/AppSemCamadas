using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSemCamadas.Models
{
    public class Endereco
    {
        // seguindo o padrão NomeentidadeId o entity entende que essa é a fk correspondente a propriedade de navegação
        public Guid FornecedorId { get; set; } // fk 

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Cep { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        /* EF Relation */
        public Fornecedor Fornecedor { get; set; }
    }
}
