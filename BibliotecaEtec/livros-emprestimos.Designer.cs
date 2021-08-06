namespace BibliotecaEtec
{
    partial class livros_emprestimos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLivros = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLivros
            // 
            this.btnLivros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(139)))), ((int)(((byte)(55)))));
            this.btnLivros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivros.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLivros.Location = new System.Drawing.Point(249, 272);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(200, 44);
            this.btnLivros.TabIndex = 0;
            this.btnLivros.Text = "Livros";
            this.btnLivros.UseVisualStyleBackColor = false;
            this.btnLivros.Click += new System.EventHandler(this.btnLivros_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(139)))), ((int)(((byte)(55)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(249, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Empréstimos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // livros_emprestimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::BibliotecaEtec.Properties.Resources.fundo_segunda_tela;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLivros);
            this.MaximizeBox = false;
            this.Name = "livros_emprestimos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "livros_emprestimos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.Button button1;
    }
}