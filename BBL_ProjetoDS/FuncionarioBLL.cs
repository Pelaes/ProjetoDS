using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_ProjetoDS;
using DAL_ProjetoDS;

namespace BLL_ProjetoDS
{
    public class FuncionarioBLL
    {
        public static string CadFuncionario(PessoaDTO obj)
        {
            if (string.IsNullOrWhiteSpace(obj.Nome))
            {
                throw new Exception("Campo Nome Vazio!");
            }
            if (string.IsNullOrWhiteSpace(obj.CPF))
            {
                throw new Exception("Campo CPF Vazio");
            }
            if (obj.CPF.Length != 11)
            {
                throw new Exception("Campo CPF precisa conter 11 caracteres!");
            }
            try
            {
                Int64.Parse(obj.CPF);
            }
            catch
            {
                throw new Exception("CPF deve ser numérico!");
            }
            if (string.IsNullOrWhiteSpace(obj.RG))
            {
                throw new Exception("Digite o numero dp RG!");
            }
            try
            {
                Convert.ToDateTime(obj.DataNascimento);
            }
            catch
            {
                throw new Exception("Digite uma data no formato dd/mm/aaaa!");
            }
            DateTime dataAtual = DateTime.Today;
            if(Convert.ToDateTime(obj.DataNascimento) > dataAtual)
            {
                throw new Exception("Data de nascimento deve ser menor que data atual!");
            }
            if(obj.TelFixo != "")
            {
                if(obj.TelFixo.Length < 10)
                {
                    throw new Exception("Numero de telefone fixo inválido!");
                }
            }
            if (string.IsNullOrWhiteSpace(obj.TelCelular))
            {
                throw new Exception("Preencha o número do seu telefone celular!");
            }
            if (obj.TelCelular.Length < 11)
            {
                throw new Exception("Numero de telefone celular inválido!");
            }
            if (string.IsNullOrWhiteSpace(obj.Cargo))
            {
                throw new Exception("Selecione o cargo do funcionário!");
            }
            if (string.IsNullOrWhiteSpace(obj.Endereco))
            {
                throw new Exception("Digite seu endereço!");
            }
            if (string.IsNullOrWhiteSpace(obj.Numero))
            {
                throw new Exception("Digite o número do imóvel!");
            }
            if (string.IsNullOrWhiteSpace(obj.Bairro))
            {
                throw new Exception("Digite o bairro!");
            }
            if (string.IsNullOrWhiteSpace(obj.Cidade))
            {
                throw new Exception("Digite a cidade!");
            }
            if (string.IsNullOrWhiteSpace(obj.Estado))
            {
                throw new Exception("Selecione o estado!");
            }
            if (string.IsNullOrWhiteSpace(obj.CEP))
            {
                throw new Exception("Preencha o número do CEP!");
            }
            if (obj.CEP.Length < 8)
            {
                throw new Exception("Numero de CEP inválido!");
            }
            if (string.IsNullOrWhiteSpace(obj.Sexo))
            {
                throw new Exception("Selecione o sexo do funcionário!");
            }
            if (string.IsNullOrWhiteSpace(obj.Ativo))
            {
                throw new Exception("Selecione o status do funcionário!");
            }
            obj.Email = "";
            obj.Senha = "";
            obj.UserName = "";
            return FuncionarioDAL.CadFuncionario(obj);
        }
    }
}
