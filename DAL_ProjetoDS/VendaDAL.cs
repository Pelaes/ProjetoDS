using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_ProjetoDS;

namespace DAL_ProjetoDS
{
    public class VendaDAL
    {
        public static ProdutoDTO BuscarProduto(string codBarras)
        {
            try
            {
                string script = "SELECT * FROM Produto WHERE codBarras = @codBarras AND ativo = 'ativo'";
                SqlCommand cm = new SqlCommand(script, Conexao.Conectar());
                //sempre nessa ordem, chamando o metodo de conectar
                cm.Parameters.AddWithValue("@codBarras", codBarras);
                //substitui as variaveis na instruçao sql pelos valores digitados pelo usuario

                SqlDataReader dados = cm.ExecuteReader();
                //roda a intruçao sql e atribui resultado no SqlDataReader

                while (dados.Read())
                //le a proxima linha do resultado da sua instruçao
                {
                    if (dados.HasRows)
                    //se der certo vai aparecer a message de conexao feita
                    {
                        ProdutoDTO produto = new ProdutoDTO();
                        produto.IdProd = int.Parse(dados["idProduto"].ToString());
                        produto.CodBarras = dados["codBarras"].ToString();
                        produto.NomeProd = dados["nome"].ToString();
                        produto.DescProd = dados["descricao"].ToString();
                        produto.PrecoProd = dados["preco"].ToString();
                        produto.EstoqueProd = dados["estoque"].ToString();
                        produto.UnidadeProd = dados["unidade"].ToString();
                        produto.TipoUnidProd = dados["tipo"].ToString();
                        produto.AtivoProd = dados["ativo"].ToString();

                        return produto;
                    }

                }
                throw new Exception("produto não encontrado. Verifique o código!");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de conexão, contate o suporte! " + ex.Message);
            }
            finally //finally acontece independente se acontece o try ou catch
            {
                if (Conexao.Conectar().State != ConnectionState.Closed)
                //testando o estado da conexao, se é diferente de fechado
                {
                    Conexao.Conectar().Close();
                }
            }
        }
    }
}
