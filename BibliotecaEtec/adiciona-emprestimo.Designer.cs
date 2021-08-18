
namespace BibliotecaEtec
{
    partial class adiciona_emprestimo
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtLeitor = new System.Windows.Forms.Label();
            this.LbTitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtNome = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtTitulo = new System.Windows.Forms.ComboBox();
            this.TxtEmp = new System.Windows.Forms.DateTimePicker();
            this.TxtDev = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(83)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(583, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 32);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(133)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(180, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 47);
            this.label1.TabIndex = 8;
            this.label1.Text = "Adicionar um empréstimo";
            // 
            // TxtLeitor
            // 
            this.TxtLeitor.AutoSize = true;
            this.TxtLeitor.BackColor = System.Drawing.Color.Transparent;
            this.TxtLeitor.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLeitor.Location = new System.Drawing.Point(70, 192);
            this.TxtLeitor.Name = "TxtLeitor";
            this.TxtLeitor.Size = new System.Drawing.Size(175, 33);
            this.TxtLeitor.TabIndex = 14;
            this.TxtLeitor.Text = "Nome do Leitor:";
            // 
            // LbTitulo
            // 
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LbTitulo.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.Location = new System.Drawing.Point(70, 362);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(77, 33);
            this.LbTitulo.TabIndex = 16;
            this.LbTitulo.Text = "Título:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 33);
            this.label3.TabIndex = 18;
            this.label3.Text = "Data de emprestimo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 33);
            this.label4.TabIndex = 20;
            this.label4.Text = "Data de Devolução:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(83)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(76, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 33);
            this.button1.TabIndex = 23;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.FormattingEnabled = true;
            this.TxtNome.Location = new System.Drawing.Point(76, 234);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(253, 36);
            this.TxtNome.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(83)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(76, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 33);
            this.button2.TabIndex = 25;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitulo.FormattingEnabled = true;
            this.TxtTitulo.Location = new System.Drawing.Point(76, 400);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(253, 36);
            this.TxtTitulo.TabIndex = 24;
            // 
            // TxtEmp
            // 
            this.TxtEmp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmp.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.TxtEmp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtEmp.Location = new System.Drawing.Point(364, 234);
            this.TxtEmp.Name = "TxtEmp";
            this.TxtEmp.Size = new System.Drawing.Size(253, 36);
            this.TxtEmp.TabIndex = 26;
            // 
            // TxtDev
            // 
            this.TxtDev.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDev.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.TxtDev.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtDev.Location = new System.Drawing.Point(364, 400);
            this.TxtDev.Name = "TxtDev";
            this.TxtDev.Size = new System.Drawing.Size(253, 36);
            this.TxtDev.TabIndex = 27;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(83)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(488, 472);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 43);
            this.button3.TabIndex = 58;
            this.button3.Text = "Adicionar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // adiciona_emprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::BibliotecaEtec.Properties.Resources.fundo_geral;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 561);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TxtDev);
            this.Controls.Add(this.TxtEmp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbTitulo);
            this.Controls.Add(this.TxtLeitor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Name = "adiciona_emprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adiciona_emprestimo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TxtLeitor;
        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox TxtNome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox TxtTitulo;
        private System.Windows.Forms.DateTimePicker TxtEmp;
        private System.Windows.Forms.DateTimePicker TxtDev;
        private System.Windows.Forms.Button button3;
    }
}