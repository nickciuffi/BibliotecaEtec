using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaEtec
{
    public partial class busca_emprestimos : Form
    {
        int linhaEditada;
        string testaLivro;
        string testaLeitor;
        int tituloEditado = 0;
        int leitorEditado = 0;
        string codLivroEdit;
        string codLeitorEdit;
        string varBusca;
        public busca_emprestimos()
        {
            InitializeComponent();
            if (!comboBox1.Items.Contains("Buscar por"))
            {
                comboBox1.Items.Add("Buscar por");
                comboBox1.SelectedIndex = 4;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            livros_emprestimos le = new livros_emprestimos();
            le.Show();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            buscaPor();
        }

        private void buscaPor()
        {
            conexao comb = new conexao();


            if (comboBox1.SelectedIndex == 0)
            {
                buscaEmprestimo("tb01_livros.tb01_titulo");
            }
            if (comboBox1.SelectedIndex == 1)
            {
                buscaEmprestimo("tb03_usuario.tb03_nome");
            }
            if (comboBox1.SelectedIndex == 2)
            {
                buscaEmprestimo("tb02_emprestimo.tb02_data_de_emprestimo");
            }
            if (comboBox1.SelectedIndex == 3)
            {
                buscaEmprestimo("tb02_emprestimo.tb02_data_de_devolucao_prevista");
            }
        }

            private void buscaEmprestimo(string buscaPor) {
           
            conexao comb = new conexao();
            comb.sql = "select tb01_livros.tb01_titulo, tb02_emprestimo.tb02_data_de_devolucao_prevista, tb02_emprestimo.tb02_data_de_emprestimo, tb02_emprestimo.tb02_cod_emprestimo, tb02_emprestimo.tb02_cod_emprestimo, tb03_usuario.tb03_nome from tb02_emprestimo inner join tb01_livros on tb02_emprestimo.tb02_cod_livro = tb01_livros.tb01_cod_livro INNER JOIN tb03_usuario ON tb03_usuario.tb03_ru = tb02_emprestimo.tb02_ru where " + buscaPor +" LIKE '%" + txtBusca.Text +  "%'";

            comb.open();

            MySqlDataReader dados = comb.Execsql();

            if (dados.HasRows)
            {

                while (dados.Read())
                {
                    colocaTela(int.Parse(dados["tb02_cod_emprestimo"].ToString()), dados["tb01_titulo"].ToString(), dados["tb03_nome"].ToString(), dados["tb02_data_de_emprestimo"].ToString().Substring(0, 10), dados["tb02_data_de_devolucao_prevista"].ToString().Substring(0, 10));

                }
                comb.close();
            }
        }
        private void colocaTela(int cod, string titulo, string leitor, string dtEmprestimo, string dtDevolucao)
        {

            var index = this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[index].Cells[0].Value = cod;
            this.dataGridView1.Rows[index].Cells[1].Value = titulo;
            this.dataGridView1.Rows[index].Cells[2].Value = leitor;
            this.dataGridView1.Rows[index].Cells[3].Value = dtEmprestimo;
            this.dataGridView1.Rows[index].Cells[4].Value = dtDevolucao;

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            if (comboBox1.Items.Contains("Buscar por"))
                comboBox1.Items.Remove("Buscar por");
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                if (!comboBox1.Items.Contains("Buscar por"))
                {
                    comboBox1.Items.Add("Buscar por");
                    comboBox1.SelectedIndex = 3;

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                int empId = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());

                DialogResult dialogResult = MessageBox.Show("Você tem certeza que quer apagar esta linha?", "Atenção!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    deletaLinha(empId);
                    MessageBox.Show("Linha excluida!", "Tudo deu certo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("Você precisa selecionar uma linha primeiro!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount > 0)
            {

                editarLinha();
            }
             else
            {
                MessageBox.Show("Você precisa selecionar uma linha primeiro!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void deletaLinha(int empId)
        {
            conexao comb = new conexao();
            comb.sql = "delete from tb02_emprestimo where tb02_cod_emprestimo = " + empId;

            comb.open();

            MySqlDataReader dados = comb.Execsql();

            comb.close();

        }
        private void editarLinha()
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            linhaEditada = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
            testaLivro = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            testaLeitor = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            conteudoEdit(dataGridView1.Rows[rowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[2].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[3].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[4].Value.ToString());
            BuscaIdsLinha(linhaEditada);
        }
        private void conteudoEdit(string titulo, string nome, string dtEmp, string dtDev)
        {

            editTitulo.Text = titulo;
            editLeitor.Text = nome;
            editDtEmprestimo.Text = dtEmp;
            editDtDevolucao.Text = dtDev;
            pnEditar.Visible = true;
            panel1.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pnEditar.Visible = false;
            panel1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            editaEmp();
           
            pnEditar.Visible = false;
            panel1.Enabled = true;
           
        }
        private void editaEmp()
        {
            DialogResult dialogResult = MessageBox.Show("Você tem certeza que quer editar esta linha?", "Atenção!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
               
                DateTime dtDev = DateTime.ParseExact(editDtDevolucao.Text.ToString(), "dd/MM/yyyy",null);
                DateTime dtEmp = DateTime.ParseExact(editDtEmprestimo.Text.ToString(), "dd/MM/yyyy",null);
                string strgDev = dtDev.ToString("yyyy-MM-dd");
                string strgEmp = dtEmp.ToString("yyyy-MM-dd");
                conexao comb = new conexao();
                comb.sql = "UPDATE Tb02_emprestimo SET tb02_emprestimo.tb02_data_de_devolucao_prevista = '" + strgDev + "', tb02_emprestimo.tb02_data_de_emprestimo = '" + strgEmp + "', tb02_emprestimo.tb02_cod_livro = '" + codLivroEdit + "', tb02_emprestimo.tb02_ru = '" + codLeitorEdit + "' WHERE tb02_emprestimo.tb02_cod_emprestimo = " + linhaEditada;

                comb.open();

                MySqlDataReader dados = comb.Execsql();

                    MessageBox.Show("Linha editada!", "Tudo deu certo!",
              MessageBoxButtons.OK, MessageBoxIcon.Information);

                    comb.close();
                

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
       

        private void editLeitor_Enter(object sender, EventArgs e)
        {

        }


        private void editTitulo_Enter(object sender, EventArgs e)
        {

        }
        private void buscaNomes()
        {
            conexao comb = new conexao();
            comb.sql = "select tb03_nome, tb03_ru from tb03_usuario where tb03_nome like '%" + editLeitor.Text + "%' order by tb03_nome limit 10";

            comb.open();

            MySqlDataReader dados = comb.Execsql();

            if (dados.HasRows)
            {

                while (dados.Read())
                {
                    editLeitor.Items.Add(dados["tb03_nome"].ToString());
                    codLeitorEdit = dados["tb03_ru"].ToString();
                }
                comb.close();

            }
        }
        private void buscaTitulos()
        {
            conexao comb = new conexao();
            comb.sql = "select tb01_titulo, tb01_cod_livro from tb01_livros where tb01_titulo like '%" + editTitulo.Text + "%' order by tb01_titulo limit 10";

            comb.open();

            MySqlDataReader dados = comb.Execsql();

            if (dados.HasRows)
            {

                while (dados.Read())
                {
                    editTitulo.Items.Add(dados["tb01_titulo"].ToString());
                    codLivroEdit = dados["tb01_cod_livro"].ToString();
                }
                comb.close();
              
            }
        }
       

        private void editDtDevolucao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            editTitulo.Items.Clear();
            buscaTitulos();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            editLeitor.Items.Clear();
            buscaNomes();
        }

        private void editTitulo_Enter_1(object sender, EventArgs e)
        {
            if (tituloEditado == 0)
            {
                editTitulo.Text = "";
            }
            tituloEditado++;
           
        }

        private void editLeitor_Enter_1(object sender, EventArgs e)
        {
            if (leitorEditado == 0)
            {
                editLeitor.Text = "";
            }
            tituloEditado++;
        }
        private void BuscaIdsLinha(int id)
        {

            conexao comb = new conexao();
            comb.sql = "select tb02_cod_livro, tb02_ru from tb02_emprestimo where tb02_cod_emprestimo = " + id;

            comb.open();

            MySqlDataReader dados = comb.Execsql();

            if (dados.HasRows)
            {

                while (dados.Read())
                {
                    codLivroEdit = dados["tb02_cod_livro"].ToString();
                    codLeitorEdit = dados["tb02_ru"].ToString();
                }
                comb.close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            adiciona_emprestimo ae = new adiciona_emprestimo();
            ae.Show();
        }
    }
}
