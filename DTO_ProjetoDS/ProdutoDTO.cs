using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_ProjetoDS
{
    public class ProdutoDTO
    {
        public int IdProd { get; set; }
        public string CodBarras { get; set; }
        public string NomeProd { get; set; }
        public string DescProd { get; set; }
        public string PrecoProd { get; set; }
        public string EstoqueProd { get; set; }
        public string UnidadeProd { get; set; }
        public string TipoUnidProd { get; set; }
        public string AtivoProd { get; set; }
    }
}
