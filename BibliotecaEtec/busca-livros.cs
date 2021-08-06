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
    public partial class busca_livros : Form
    {
        string buscaPor;
        int linhaEditada;
       
        public busca_livros()
        {
            InitializeComponent();
            if (!comboBox1.Items.Contains("Buscar por"))
            {
                comboBox1.Items.Add("Buscar por");
                comboBox1.SelectedIndex = 3;

            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            livros_emprestimos le = new livros_emprestimos();
            le.Show();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            buscaLivros();
        }
        private void buscaLivros()
        {
            conexao comb = new conexao();

            
            if(comboBox1.SelectedIndex == 0)
            {
                buscaPor = "tb01_titulo";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                buscaPor = "tb01_editora";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                buscaPor = "tb01_data_de_registro";
            }

            comb.sql = "select * from tb01_livros where " + buscaPor + " like '%" + txtBusca.Text + "%'";
            
            comb.open();

            MySqlDataReader dados = comb.Execsql();

            if (dados.HasRows)
            {
               
                while (dados.Read())
                {
                    colocaTela(int.Parse(dados["tb01_cod_livro"].ToString()), dados["tb01_titulo"].ToString(), dados["tb01_editora"].ToString(), dados["tb01_data_de_registro"].ToString().Substring(0, 10), dados["tb01_disponibilidade"].ToString());

                }
                comb.close();
            }
        }
        private void colocaTela(int cod, string titulo, string editora, string dtRegistro, string disp)
        {
           
            var index = this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[index].Cells[0].Value = cod;
            this.dataGridView1.Rows[index].Cells[1].Value = titulo;
            this.dataGridView1.Rows[index].Cells[2].Value = editora;
            this.dataGridView1.Rows[index].Cells[3].Value = dtRegistro;
            if (disp == "D")
            {
                this.dataGridView1.Rows[index].Cells[4].Value = "Disponível";
            }
            if (disp == "I")
            {
                this.dataGridView1.Rows[index].Cells[4].Value = "Indisponível";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(dataGridView1.Rows[0].Cells[0].Value);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text != "")
            {
                dataGridView1.Rows.Clear();
                buscaLivros();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                int livroId = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());

                DialogResult dialogResult = MessageBox.Show("Você tem certeza que quer apagar esta linha?", "Atenção!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    deletaLinha(livroId);
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

        private void deletaLinha(int livroId)
        {
            conexao comb = new conexao();
            comb.sql = "delete from tb01_livros where tb01_cod_livro = " + livroId;

            comb.open();

            MySqlDataReader dados = comb.Execsql();

            comb.close();
            dataGridView1.Rows.Clear();
            buscaLivros();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {

                editarLinha();
            }
            else
            {
                MessageBox.Show("Você precisa selecionar uma linha primeiro!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editarLinha()
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            linhaEditada = int.Parse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
            conteudoEdit(dataGridView1.Rows[rowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[2].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[3].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[4].Value.ToString());
           
        }

        private void conteudoEdit(string titulo, string editora, string dtCad, string disp)
        {

            editTitulo.Text = titulo;
            editEditora.Text = editora;
            editDtRegistro.Text = dtCad;
            editDisp.Text = disp;
            pnEditar.Visible = true;
            panel1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            editaLivro();

            pnEditar.Visible = false;
            panel1.Enabled = true;
        }

        private void editaLivro()
        {
            DialogResult dialogResult = MessageBox.Show("Você tem certeza que quer editar esta linha?", "Atenção!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string disp = "D";
                DateTime dtReg = DateTime.ParseExact(editDtRegistro.Text.ToString(), "dd/MM/yyyy", null);
                string strgReg = dtReg.ToString("yyyy-MM-dd");

                if (editDisp.Text != "Disponível" && editDisp.Text != "Indisponível")
                {
                    MessageBox.Show("Os únicos valores possíveis para a disponibilidade são: Disponível e Indisponível!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine("viefvi");
                }
                else
                {

                    if (editDisp.Text == "Disponível")
                    {
                        disp = "D";
                    }
                    if (editDisp.Text == "Indisponível")
                    {
                        disp = "I";
                    }

                    conexao comb = new conexao();
                    comb.sql = "UPDATE Tb01_livros SET tb01_livros.tb01_titulo = '" + editTitulo.Text + "', tb01_data_de_registro = '" + strgReg + "', tb01_editora = '" + editEditora.Text + "', tb01_disponibilidade = '" + disp + "' WHERE tb01_cod_livro = " + linhaEditada;

                    comb.open();

                    MySqlDataReader dados = comb.Execsql();

                    MessageBox.Show("Linha editada!", "Tudo deu certo!",
              MessageBoxButtons.OK, MessageBoxIcon.Information);

                    comb.close();
                    dataGridView1.Rows.Clear();
                    buscaLivros();

                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
                
            }
            
        

        private void button6_Click(object sender, EventArgs e)
        {
            pnEditar.Visible = false;
            panel1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            adiciona_livros al = new adiciona_livros();
            al.Show();
        }
    }
}
