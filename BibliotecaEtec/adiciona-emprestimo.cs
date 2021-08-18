using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaEtec
{
    public partial class adiciona_emprestimo : Form
    {
        string codLeitor;
        string codLivro;
        public adiciona_emprestimo()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            busca_livros bl = new busca_livros();
            bl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtNome.Items.Clear();
            buscaNomes();
        }
        private void buscaNomes()
        {
            conexao comb = new conexao();
            comb.sql = "select tb03_nome, tb03_ru from tb03_usuario where tb03_nome like '%" + TxtNome.Text + "%' order by tb03_nome limit 10";

            comb.open();

            MySqlDataReader dados = comb.Execsql();

            if (dados.HasRows)
            {

                while (dados.Read())
                {
                    TxtNome.Items.Add(dados["tb03_nome"].ToString());
                    codLeitor = dados["tb03_ru"].ToString();
                }
                comb.close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtTitulo.Items.Clear();
            buscaTitulos();
        }
        private void buscaTitulos()
        {
            conexao comb = new conexao();
            comb.sql = "select tb01_titulo, tb01_cod_livro from tb01_livros where tb01_titulo like '%" + TxtTitulo.Text + "%' order by tb01_titulo limit 10";

            comb.open();

            MySqlDataReader dados = comb.Execsql();

            if (dados.HasRows)
            {

                while (dados.Read())
                {
                    TxtTitulo.Items.Add(dados["tb01_titulo"].ToString());
                    codLivro = dados["tb01_cod_livro"].ToString();
                }
                comb.close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adicionaEmp(TxtNome.Text, TxtTitulo.Text, TxtEmp.Text, TxtDev.Text);
        }
        private void adicionaEmp(string leitor, string titulo, string dtEmp, string dtDev)
        {
            DateTime dateDev = DateTime.ParseExact(dtDev, "dd/MM/yyyy", null);
            DateTime dateEmp = DateTime.ParseExact(dtEmp, "dd/MM/yyyy", null);
            string strgDev = dateDev.ToString("yyyy-MM-dd");
            string strgEmp = dateEmp.ToString("yyyy-MM-dd");
            conexao comb = new conexao();
            comb.sql = "INSERT INTO `data1_etec`.`tb02_emprestimo` (`tb02_ru`, `tb02_data_de_devolucao_prevista`, `tb02_cod_livro`, `tb02_data_de_emprestimo`) VALUES ('"+ codLeitor +"', '"+ strgDev +"', '"+ codLivro +"', '"+ strgEmp +"');";

            comb.open();

            MySqlDataReader dados = comb.Execsql();

            MessageBox.Show("Emprestimo adicionado", "Tudo deu certo!",
      MessageBoxButtons.OK, MessageBoxIcon.Information);
            MudaDisp("I", codLivro);
            comb.close();
            this.Hide();
            busca_emprestimos be = new busca_emprestimos();
            be.Show();
        }
        public void MudaDisp(string disp, string codLivro)
        {
            conexao comb = new conexao();
            comb.sql = "update tb01_livros set tb01_disponibilidade = '"+ disp +"' where tb01_cod_livro = " + codLivro;

            comb.open();

            MySqlDataReader dados = comb.Execsql();

            comb.close();
        }
    }
}
