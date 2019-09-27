using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_ProjetoDS;
using System.Data;
using System.Data.SqlClient;

namespace DAL_ProjetoDS
{
    public class LoginDAL
    {
        public static PessoaDTO vldLogin (loginDTO obj)
        {
            try
            {
                string script = "SELECT * FROM Pessoa WHERE(userName = @login OR email = @login)" + 
                    "AND senha = @senha";
                SqlCommand cm = new SqlCommand(script, Conexao.Conectar());
                //sempre nessa ordem, chamando o metodo de conectar
                cm.Parameters.AddWithValue("@login", obj.prpUsuario);
                cm.Parameters.AddWithValue("@senha", obj.prpSenha);
                //substitui as variaveis na instruçao sql pelos valores digitados pelo usuario

                SqlDataReader dados = cm.ExecuteReader();
                //roda a intruçao sql e atribui resultado no SqlDataReader

                while (dados.Read())
                    //le a proxima linha do resultado da sua instruçao
                {
                    if (dados.HasRows)
                        //se der certo vai aparecer a message de conexao feita
                    {
                        PessoaDTO pessoa = new PessoaDTO();
                        pessoa.idPessoa = int.Parse(dados["idPessoa"].ToString());
                        pessoa.Nome = dados["nome"].ToString();
                        pessoa.Email = dados["email"].ToString();
                        pessoa.UserName = dados["userName"].ToString();
                        pessoa.Senha = dados["senha"].ToString();
                        pessoa.Cargo = dados["cargo"].ToString();
                        pessoa.DataNascimento = dados["dtNascimento"].ToString();
                        pessoa.Sexo = dados["sexo"].ToString();
                        pessoa.TelFixo = dados["telFixo"].ToString();
                        pessoa.TelCelular = dados["telCelular"].ToString();
                        pessoa.Ativo = dados["ativo"].ToString();
                        pessoa.RG = dados["RG"].ToString();
                        pessoa.CPF = dados["CPF"].ToString();
                        return pessoa;
                    }

                }
                throw new Exception("Usuário ou senha inválidos!");
            }
            catch (Exception ex)
            {
                throw new Exception ("Erro de conexão, contate o suporte! " + ex.Message);
            }
            finally //finally acontece independente se acontece o try ou catch
            {
                if(Conexao.Conectar().State != ConnectionState.Closed)
                    //testando o estado da conexao, se é diferente de fechado
                {
                    Conexao.Conectar().Close();
                }
            }
        }  


    }
}
