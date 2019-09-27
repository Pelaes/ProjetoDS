using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
//importando a biblioteca de classe do banco de dados

namespace DAL_ProjetoDS
{
    class Conexao
    {  //vai ser usada para conectar todos acessados pelo DAL
        public static SqlConnection Conectar()
            
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjetoDS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //pegar o caminho na propriedade  do Banco
                conn.Open();
                return conn;
            }
            catch 
            {
                throw new Exception("Não foi possivel conectar. Tente novamente !");
            }
        }

    }
}
