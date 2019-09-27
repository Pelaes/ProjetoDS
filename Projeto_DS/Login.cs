using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_ProjetoDS;
using BLL_ProjetoDS;


namespace UI_ProjetoDS //UI- User Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            try
            {
                loginDTO obj = new loginDTO();
                PessoaDTO pessoa = new PessoaDTO();

                obj.prpUsuario = txtNome.Text;
                obj.prpSenha = txtSenha.Text;

                pessoa = LoginBLL.vldLogin(obj);

                if (pessoa.Nome != "" && pessoa.Ativo.ToLower() == "true")
                {
                    this.Hide();
                    Home telaInicio = new Home(pessoa);
                    telaInicio.ShowDialog();
                    this.Close();
                }
                else
                {
                    throw new Exception("Usuário ou senha inválidos!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
