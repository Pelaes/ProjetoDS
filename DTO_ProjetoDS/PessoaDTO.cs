using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_ProjetoDS
{
    public class PessoaDTO
    {
        public int idPessoa { get; set; }
        public string Nome { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Cargo { get; set; }
        public string DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Ativo { get; set; }
        public string TelFixo { get; set; }
        public string TelCelular { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
    }
}
