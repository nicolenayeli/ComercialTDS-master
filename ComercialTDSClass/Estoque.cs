using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialTDSClass
{
    public class Estoque
    {
        public int ProdutoId { get; set; }
        public decimal Quantidade { get; set; }
        public DateTime DataUltimoMovimento { get; set; }
    }
}
