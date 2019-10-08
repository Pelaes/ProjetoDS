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
    public class FuncionarioDAL
    {
        public static string CadFuncionario(PessoaDTO obj)
        {
            try
            {
                string script = "INSERT INTO tb_funcionario (nome, rg, cpf, ctps, endereco, tel_fixo, tel_celular, tipo, foto, usuario, senha) " +
                                "VALUES (@nome, @rg, @cpf, @ctps, @end, @fixo, @cel, @tipo, @foto, @user, @ pass)";
                SqlCommand cm = new SqlCommand(script, Conexao.Conectar());

                cm.Parameters.AddWithValue("@nome", obj.Nome);
                cm.Parameters.AddWithValue("@nome", obj.RG);

                cm.ExecuteNonQuery();

                return ("Funcionário cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (Conexao.Conectar().State != ConnectionState.Closed)
                {
                    Conexao.Conectar().Close();
                }
            }
        }
    }
}
