using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaEtec
{
    public partial class adiciona_livros : Form
    {
        public adiciona_livros()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            busca_livros bl = new busca_livros();
            bl.Show();
        }
        private void opcional()
        {
            TxtAssunto2.Text = "(Opcional)";
            TxtAssunto3.Text = "(Opcional)";
            TxtAssunto4.Text = "(Opcional)";
            TxtNotas.Text = "(Opcional)";
            TxtObservacao.Text = "(Opcional)";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(TxtAnoPubli.Text, @"^\d+$") || TxtAnoPubli.Text.Length != 4)
            {
                MessageBox.Show("O ano de publicação precisa ser um ano válido", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (TxtAutor.Text == "" || TxtAnoPubli.Text == "" || TxtAssunto1.Text == "" || TxtAssunto2.Text == "" || TxtAssunto3.Text == "" || TxtAssunto4.Text == "" || TxtCutter.Text == "" || TxtDivisao.Text == "" || TxtEdicao.Text == "" || TxtEditora.Text == "" || TxtExemplar.Text == "" || TxtImpressao.Text == "" || TxtInst.Text == "" || TxtIsbn.Text == "" || TxtLingua.Text == "" || TxtLocal.Text == "" || TxtNotas.Text == "" || TxtObservacao.Text == "" || TxtResp.Text == "" || TxtSerie.Text == "" || TxtTitulo.Text == "" || TxtVolume.Text == "")
            {
                MessageBox.Show("Todos os campos obrigatórios devem ser preenchidos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(!Regex.IsMatch(TxtExemplar.Text, @"^\d+$"))
            {
                MessageBox.Show("O campo de exemplar deve ser preenchido com um número!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                adicionaLivro(TxtAutor.Text, TxtAnoPubli.Text, TxtAssunto1.Text, TxtAssunto2.Text, TxtAssunto3.Text, TxtAssunto4.Text, TxtCutter.Text, TxtDivisao.Text, TxtEdicao.Text, TxtEditora.Text, TxtExemplar.Text, TxtImpressao.Text, TxtInst.Text, TxtIsbn.Text, TxtLingua.Text, TxtLocal.Text, TxtNotas.Text, TxtObservacao.Text, TxtResp.Text, TxtSerie.Text, TxtTitulo.Text, TxtVolume.Text);
            }
        }
        private void adicionaLivro(string autor, string anoPubli, string Assunto1, string Assunto2, string Assunto3, string Assunto4, string cutter, string divisao, string edicao, string editora, string exemplar, string impressao, string inst, string isbn, string lingua, string local, string notas, string obs, string resp, string serie, string titulo, string volume)
        {
            if(Assunto2 == "(Opcional)")
            {
                Assunto2 = "";
            }
            if (Assunto3 == "(Opcional)")
            {
                Assunto3 = "";
            }
            if (Assunto4 == "(Opcional)")
            {
                Assunto4 = "";
            }
            if (notas == "(Opcional)")
            {
                notas = "";
            }
            if (obs == "(Opcional)")
            {
                obs = "";
            }
            conexao comb = new conexao();
            comb.sql = "INSERT INTO `data1_etec`.`tb01_livros` (`tb01_autor`, `tb01_responsavel`, `tb01_instituto_responsavel`, `tb01_titulo`, `tb01_serie_coleção`, `tb01_local_de_publicação`, `tb01_editora`, `tb01_ano_de_pubicação`, `tb01_volume`, `tb01_edição`, `tb01_impressão_tiragem`, `tb01_idioma`, `tb01_isbn`, `tb01_assunto_1`, `tb01_assunto_2`, `tb01_Assunto_3`, `tb01_assunto_4`, `tb01_divisão_por_assunto`, `tb01_cutter`, `tb01_exemplar`, `tb01_data_de_registro`, `tb01_notas`, `tb01_observação`) VALUES ('" + autor + "', '"+ resp +"', '"+ inst +"', '"+ titulo +"', '"+ serie +"', '"+ local +"', '"+ editora +"', '"+ anoPubli +"', '"+ volume +"', '"+ edicao +"', '"+ impressao +"', '"+ lingua +"', '"+ isbn +"', '"+ Assunto1 +"', '"+ Assunto2 + "', '" + Assunto3 + "', '" + Assunto4 + "', '"+ divisao +"', '"+ cutter +"', '"+ exemplar +"',CURDATE() , '"+ notas +"', '"+ obs +"');";

            comb.open();

            MySqlDataReader dados = comb.Execsql();

            MessageBox.Show("Livro adicionado", "Tudo deu certo!",
      MessageBoxButtons.OK, MessageBoxIcon.Information);

            comb.close();
            this.Hide();
            busca_livros bl = new busca_livros();
            bl.Show();
        }

        

        private void adiciona_livros_Load(object sender, EventArgs e)
        {
            opcional();
        }

        private void TxtAssunto2_MouseClick(object sender, MouseEventArgs e)
        {
            if (TxtAssunto2.Text == "(Opcional)")
            {
                TxtAssunto2.Text = "";
            }
        }

        private void TxtAssunto3_MouseClick(object sender, MouseEventArgs e)
        {
            if (TxtAssunto3.Text == "(Opcional)")
            {
                TxtAssunto3.Text = "";
            }
        }

        private void TxtAssunto4_MouseClick(object sender, MouseEventArgs e)
        {
            if (TxtAssunto4.Text == "(Opcional)")
            {
                TxtAssunto4.Text = "";
            }
        }

        private void TxtNotas_MouseClick(object sender, MouseEventArgs e)
        {
            if (TxtNotas.Text == "(Opcional)")
            {
                TxtNotas.Text = "";
            }
        }

        private void TxtObservacao_MouseClick(object sender, MouseEventArgs e)
        {
            if (TxtObservacao.Text == "(Opcional)")
            {
                TxtObservacao.Text = "";
            }
        }
    }
}
