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
    }
}
