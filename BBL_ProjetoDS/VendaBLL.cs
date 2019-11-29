using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_ProjetoDS;
using DAL_ProjetoDS;

namespace BLL_ProjetoDS
{
    public class VendaBLL
    {
        public static ProdutoDTO BuscarProduto(string codBarras)
        {
            if (string.IsNullOrWhiteSpace(codBarras))
            {
                throw new Exception("Digite o código barras!");
            }
            try
            {
                Convert.ToInt64(codBarras);
            }
            catch
            {
                throw new Exception("Código de barras deve ser numérico!");
            }
            if (codBarras.Length != 13)
            {
                throw new Exception("Digite 13 numeros!");
            }
            return VendaDAL.BuscarProduto(codBarras);
        }
    }
}
