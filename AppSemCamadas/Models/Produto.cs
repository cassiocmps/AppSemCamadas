using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSemCamadas.Models
{
    public class Produto : Entity
    {
        public Guid FornecedorId { get; set; } // fk do fornecedor

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Imagem { get; set; }

        public decimal Valor { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        /* EF Relations 
         relação ' 1 -> 1 ' 
         apesar da eixtencia do FornecedorId servir para banco de dados entender a relacao
         o EF precisa dessa propriedade de navegação*/
        public Fornecedor Fornecedor { get; set; }
    }
}
