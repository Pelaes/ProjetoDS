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
            return "abc";
        }
    }
}
