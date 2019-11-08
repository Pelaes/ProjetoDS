using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_ProjetoDS;
using DAL_ProjetoDS;

namespace BLL_ProjetoDS
{
    public class ProdutoBLL
    {
        public static string CadProduto(ProdutoDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.CodBarras))
            {
                throw new Exception("Campo código de barras vazio");
            }
            try
            {
                Convert.ToInt64(obj.CodBarras);
            }
            catch
            {
                throw new Exception("Código de barras deve ser numérico!");
            }
            if (obj.CodBarras.Length != 13)
            {
                throw new Exception("Código de barras deve ter 13 digitos!");
            }
            if (string.IsNullOrWhiteSpace(obj.NomeProd))
            {
                throw new Exception("Campo nome vazio");
            }
            if (string.IsNullOrWhiteSpace(obj.DescProd))
            {
                throw new Exception("Campo descrição vazio");
            }
            if (string.IsNullOrWhiteSpace(obj.PrecoProd))
            {
                throw new Exception("Campo preço vazio");
            }
            try
            {
                Convert.ToDouble(obj.PrecoProd);
            }
            catch
            {
                throw new Exception("Preço deve ser numérico!");
            }
            if (string.IsNullOrWhiteSpace(obj.EstoqueProd))
            {
                throw new Exception("Campo estoque vazio");
            }
            try
            {
                Convert.ToInt32(obj.EstoqueProd);
            }
            catch
            {
                throw new Exception("Estoque deve ser numérico!");
            }
            if (string.IsNullOrWhiteSpace(obj.AtivoProd))
            {
                throw new Exception("Selecione se o produto está ativo ou inativo!");
            }

            return ProdutoDAL.CadProduto(obj);
        }

        public static ProdutoDTO BuscarProduto (string codBarras)
        {
            if (string.IsNullOrWhiteSpace(codBarras))
            {
                throw new Exception("Digite o código de barras do produto!");
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
                throw new Exception("Código de barras deve ter 13 digitos!");
            }
            return ProdutoDAL.BuscarProduto(codBarras);
        }
    }
}
