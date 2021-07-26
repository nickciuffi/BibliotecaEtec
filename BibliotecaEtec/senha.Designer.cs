namespace BibliotecaEtec
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.senha = new System.Windows.Forms.TextBox();
            this.entrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImage = global::BibliotecaEtec.Properties.Resources.fundo_primeira_tela;
            this.panel1.Location = new System.Drawing.Point(-8, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 0;
            // 
            // senha
            // 
            this.senha.AcceptsTab = true;
            this.senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.ForeColor = System.Drawing.Color.Green;
            this.senha.Location = new System.Drawing.Point(251, 323);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(194, 26);
            this.senha.TabIndex = 1;
            this.senha.Tag = "";
            this.senha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.senha_MouseClick);
            this.senha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // entrar
            // 
            this.entrar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(128)))), ((int)(((byte)(41)))));
            this.entrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrar.Location = new System.Drawing.Point(306, 365);
            this.entrar.Margin = new System.Windows.Forms.Padding(0);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(87, 32);
            this.entrar.TabIndex = 2;
            this.entrar.Text = "Entrar";
            this.entrar.UseVisualStyleBackColor = false;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BibliotecaEtec.Properties.Resources.fundo_primeira_tela;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 561);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Button entrar;
    }
}

