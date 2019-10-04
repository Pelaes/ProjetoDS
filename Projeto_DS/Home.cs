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

namespace UI_ProjetoDS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            TimeSpan tarde = new TimeSpan(12, 0, 0);
            TimeSpan noite = new TimeSpan(18, 0, 0);
            TimeSpan HoraAtual = DateTime.Now.TimeOfDay;
            if (HoraAtual < tarde)
            {
                label1.Text = "Tenha um ótimo dia!";
            }
            else if (HoraAtual < noite)
            {
                label1.Text = "Que sua tarde seja excelente!";
            }
            else
            {
                label1.Text = "Muito boa noite!";
            }

            string Cargo = "Funcionario";

            if (Cargo == "Funcionario")
            {
                this.tabControl1.TabPages.Remove(tabPage3);
                this.tabControl1.TabPages.Remove(tabPage4);
                this.tabControl1.TabPages.Remove(tabPage5);
                this.tabControl1.TabPages.Remove(tabPage6);
                this.tabControl1.TabPages.Remove(tabPage7);
            }
        }

        public Home (PessoaDTO pessoa)
        {
            InitializeComponent();
            TimeSpan tarde = new TimeSpan(12, 0, 0);
            TimeSpan noite = new TimeSpan(18, 0, 0);
            TimeSpan HoraAtual = DateTime.Now.TimeOfDay;
            if (HoraAtual < tarde)
            {
                label1.Text = "Tenha um ótimo dia!";
            }
            else if (HoraAtual < noite)
            {
                label1.Text = "Que sua tarde seja excelente!";
            }
            else
            {
                label1.Text = "Muito boa noite!";
            }

            label3.Text = pessoa.Nome;
           
            if(pessoa.Cargo == "Funcionario")
            {
                this.tabControl1.TabPages.Remove(tabPage3);
                this.tabControl1.TabPages.Remove(tabPage4);
                this.tabControl1.TabPages.Remove(tabPage5);
                this.tabControl1.TabPages.Remove(tabPage6);
                this.tabControl1.TabPages.Remove(tabPage7);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PessoaDTO obj = new PessoaDTO();
                obj.Nome = textBox1.Text;
                obj.CPF = maskedTextBox1.Text;
                obj.RG = textBox3.Text;
                obj.DataNascimento = maskedTextBox2.Text;
                obj.TelFixo = maskedTextBox4.Text;
                obj.TelCelular = maskedTextBox5.Text;
                obj.Cargo = comboBox1.Text;
                obj.Endereco = textBox2.Text;
                obj.Numero = textBox5.Text;
                obj.Bairro = textBox4.Text;
                obj.Cidade = textBox6.Text;
                obj.Estado = comboBox2.Text;
                obj.CEP = maskedTextBox3.Text;
                if (radioButton1.Checked == true)
                {
                    obj.Sexo = radioButton1.Text;
                }
                if (radioButton2.Checked == true)
                {
                    obj.Sexo = radioButton2.Text;
                }
                if (radioButton3.Checked == true)
                {
                    obj.Sexo = radioButton3.Text;
                }
                if (radioButton4.Checked == true)
                {
                    obj.Ativo = radioButton4.Text;
                }
                if (radioButton5.Checked == true)
                {
                    obj.Ativo = radioButton5.Text;
                }
                FuncionarioBLL.CadFuncionario(obj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
