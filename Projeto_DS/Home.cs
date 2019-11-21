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
            button5.Enabled = false;
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
                string mensagem = FuncionarioBLL.CadFuncionario(obj);
                MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Clear();
                maskedTextBox1.Clear();
                textBox3.Clear();
                maskedTextBox2.Clear();
                maskedTextBox4.Clear();
                maskedTextBox5.Clear();
                comboBox1.SelectedIndex = -1;
                textBox2.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                comboBox2.SelectedIndex = -1;
                maskedTextBox3.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            maskedTextBox1.Clear();
            textBox3.Clear();
            maskedTextBox2.Clear();
            maskedTextBox4.Clear();
            maskedTextBox5.Clear();
            comboBox1.SelectedIndex = -1;
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox2.SelectedIndex = -1;
            maskedTextBox3.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                string codBarras = textBox14.Text;
                ProdutoDTO obj = new ProdutoDTO();
                obj = ProdutoBLL.BuscarProduto(codBarras);
                textBox19.Text = obj.IdProd.ToString();
                textBox14.Text = obj.CodBarras;
                textBox15.Text = obj.NomeProd;
                textBox8.Text = obj.DescProd;
                textBox16.Text = obj.PrecoProd;
                textBox17.Text = obj.EstoqueProd;
                textBox18.Text = obj.UnidadeProd;
                comboBox4.Text = obj.TipoUnidProd;
                if(obj.AtivoProd.ToLower() == "ativo")
                {
                    radioButton9.Checked = true;
                }
                if (obj.AtivoProd.ToLower() == "inativo")
                {
                    radioButton8.Checked = true;
                }
                button5.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoDTO obj = new ProdutoDTO();
                obj.CodBarras = textBox9.Text;
                obj.NomeProd = textBox10.Text;
                obj.DescProd = textBox7.Text;
                obj.PrecoProd = textBox11.Text;
                obj.EstoqueProd = textBox12.Text;
                obj.UnidadeProd = textBox13.Text;
                obj.TipoUnidProd = comboBox3.Text;
                if (radioButton6.Checked == true)
                {
                    obj.AtivoProd = radioButton6.Text;
                }
                if (radioButton7.Checked == true)
                {
                    obj.AtivoProd = radioButton7.Text;
                }
                obj.AcaoProd = "cadastro";
                string mensagem = ProdutoBLL.CadProduto(obj);
                MessageBox.Show(mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox9.Clear();
                textBox10.Clear();
                textBox7.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                comboBox3.SelectedIndex = -1;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                textBox9.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoDTO obj = new ProdutoDTO();
                obj.IdProd = int.Parse(textBox19.Text);
                //MessageBox.Show(obj.IdProd.ToString());
                obj.CodBarras = textBox14.Text;
                obj.NomeProd = textBox15.Text;
                obj.DescProd = textBox8.Text;
                obj.PrecoProd = textBox16.Text;
                obj.EstoqueProd = textBox17.Text;
                obj.UnidadeProd = textBox18.Text;
                obj.TipoUnidProd = comboBox4.Text;
                if (radioButton9.Checked == true)
                {
                    obj.AtivoProd = radioButton9.Text;
                }
                if (radioButton8.Checked == true)
                {
                    obj.AtivoProd = radioButton8.Text;
                }
                obj.AcaoProd = "alteracao";
                string mensagem = ProdutoBLL.CadProduto(obj);
                MessageBox.Show(mensagem, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox14.Clear();
                textBox19.Clear();
                textBox15.Clear();
                textBox8.Clear();
                textBox16.Clear();
                textBox17.Clear();
                textBox18.Clear();
                comboBox4.SelectedIndex = -1;
                radioButton8.Checked = false;
                radioButton9.Checked = false;
                textBox14.Focus();
                button5.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
