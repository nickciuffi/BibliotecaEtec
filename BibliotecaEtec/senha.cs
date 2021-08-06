using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BibliotecaEtec
{
    
    public partial class Form1 : Form
    {
        string senha_banco;
        int contaclickes = 0;
        public Form1()
        {
            InitializeComponent();
            entrar.Select();
            entrar.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            placeholder();
            
        }

      public void placeholder()
        {
            senha.Text = "Digite a senha aqui!";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void senha_MouseClick(object sender, MouseEventArgs e)
        {
            if (contaclickes == 0)
            {
                senha.Text = "";
            }
            contaclickes++;
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            conexao comb = new conexao();

            comb.sql = "select tb06_senha from tb06_senha_sistema";

            comb.open();

            MySqlDataReader dados = comb.Execsql();

            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    senha_banco = dados["tb06_senha"].ToString();

                }
                comb.close();
            }
            if(senha.Text == senha_banco)
            {
                this.Hide();
                livros_emprestimos le = new livros_emprestimos();
                le.Show();


            }
            else
            {
                MessageBox.Show("Senha incorreta", "Ação",
           MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
       
    }
}
