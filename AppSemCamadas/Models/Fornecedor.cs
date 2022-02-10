using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSemCamadas.Models
{
    public partial class Fornecedor : Entity
    {
        public string Nome { get; set; }

        public string Documento { get; set; }

        public TipoFornecedor TipoFornec { get; set; }

        public Endereco Endereco { get; set; }

        //[DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        /* EF Relations : lista de produtos
        declaração não precisava ser aqui, 
        via declaração de propriedade o entity entende o relacionamento ' 1 -> muitos ' */
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
