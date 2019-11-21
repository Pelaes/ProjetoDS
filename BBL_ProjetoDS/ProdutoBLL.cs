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
            if (obj.AcaoProd == "cadastro")
            {
                bool retorno = ProdutoDAL.ValidarCodBarras(obj.CodBarras);
                if (retorno == true)
                {
                    throw new Exception("Código de barras já esta em uso!");
                }
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
            if (string.IsNullOrWhiteSpace(obj.UnidadeProd))
            {
                throw new Exception("Campo unidade vazio");
            }
            try
            {
                Convert.ToInt32(obj.UnidadeProd);
            }
            catch
            {
                throw new Exception("Estoque deve ser numérico!");
            }
            if (string.IsNullOrWhiteSpace(obj.TipoUnidProd))
            {
                throw new Exception("Campo tipo vazio");
            }
            if (string.IsNullOrWhiteSpace(obj.AtivoProd))
            {
                throw new Exception("Selecione se o produto está ativo ou inativo!");
            }

            switch (obj.AcaoProd)
            {
                case "cadastro":
                    return ProdutoDAL.CadProduto(obj);
                    //break;
                case "alteracao":
                    return ProdutoDAL.AlterarProduto(obj);
                default:
                    throw new Exception("algo errado aconteceu!");
            }
            
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
