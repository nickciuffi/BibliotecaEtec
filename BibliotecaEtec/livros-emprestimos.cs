﻿using System;
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
    public partial class livros_emprestimos : Form
    {
        public livros_emprestimos()
        {
            InitializeComponent();
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            this.Hide();
            busca_livros bl = new busca_livros();
            bl.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            busca_emprestimos be = new busca_emprestimos();
            be.Show();
        }
    }
}
