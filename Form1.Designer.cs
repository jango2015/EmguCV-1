namespace EmguCV
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.iniciarBT = new System.Windows.Forms.Button();
            this.salvarImagem = new System.Windows.Forms.Button();
            this.comboBoxEscala = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBoxMinViz = new System.Windows.Forms.ComboBox();
            this.txtFacesIdentificadas = new System.Windows.Forms.TextBox();
            this.numFacesIdentificadas = new System.Windows.Forms.TextBox();
            this.textBoxMinJanela = new System.Windows.Forms.TextBox();
            this.nomeParaSalvar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(12, 12);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(703, 371);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            this.imageBox1.Click += new System.EventHandler(this.imageBox1_Click);
            // 
            // iniciarBT
            // 
            this.iniciarBT.Location = new System.Drawing.Point(593, 389);
            this.iniciarBT.Name = "iniciarBT";
            this.iniciarBT.Size = new System.Drawing.Size(122, 23);
            this.iniciarBT.TabIndex = 3;
            this.iniciarBT.Text = "Iniciar captura de tela";
            this.iniciarBT.UseVisualStyleBackColor = true;
            this.iniciarBT.Click += new System.EventHandler(this.iniciarBT_Click);
            // 
            // salvarImagem
            // 
            this.salvarImagem.Location = new System.Drawing.Point(12, 389);
            this.salvarImagem.Name = "salvarImagem";
            this.salvarImagem.Size = new System.Drawing.Size(91, 23);
            this.salvarImagem.TabIndex = 4;
            this.salvarImagem.Text = "Salvar Imagem";
            this.salvarImagem.UseVisualStyleBackColor = true;
            this.salvarImagem.Click += new System.EventHandler(this.salvarImagem_Click);
            // 
            // comboBoxEscala
            // 
            this.comboBoxEscala.FormattingEnabled = true;
            this.comboBoxEscala.Location = new System.Drawing.Point(825, 18);
            this.comboBoxEscala.Name = "comboBoxEscala";
            this.comboBoxEscala.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEscala.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(721, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Taxa de escala";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(721, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Minimo de vizinhos";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(721, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(153, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Min pixels para checar";
            // 
            // comboBoxMinViz
            // 
            this.comboBoxMinViz.FormattingEnabled = true;
            this.comboBoxMinViz.Location = new System.Drawing.Point(825, 45);
            this.comboBoxMinViz.Name = "comboBoxMinViz";
            this.comboBoxMinViz.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMinViz.TabIndex = 9;
            // 
            // txtFacesIdentificadas
            // 
            this.txtFacesIdentificadas.Location = new System.Drawing.Point(721, 222);
            this.txtFacesIdentificadas.Name = "txtFacesIdentificadas";
            this.txtFacesIdentificadas.ReadOnly = true;
            this.txtFacesIdentificadas.Size = new System.Drawing.Size(153, 20);
            this.txtFacesIdentificadas.TabIndex = 11;
            this.txtFacesIdentificadas.Text = "Numero de faces identificadas";
            this.txtFacesIdentificadas.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // numFacesIdentificadas
            // 
            this.numFacesIdentificadas.Location = new System.Drawing.Point(880, 222);
            this.numFacesIdentificadas.Name = "numFacesIdentificadas";
            this.numFacesIdentificadas.Size = new System.Drawing.Size(66, 20);
            this.numFacesIdentificadas.TabIndex = 12;
            // 
            // textBoxMinJanela
            // 
            this.textBoxMinJanela.Location = new System.Drawing.Point(880, 72);
            this.textBoxMinJanela.Name = "textBoxMinJanela";
            this.textBoxMinJanela.Size = new System.Drawing.Size(66, 20);
            this.textBoxMinJanela.TabIndex = 13;
            this.textBoxMinJanela.Text = "25";
            // 
            // nomeParaSalvar
            // 
            this.nomeParaSalvar.Location = new System.Drawing.Point(721, 297);
            this.nomeParaSalvar.Name = "nomeParaSalvar";
            this.nomeParaSalvar.Size = new System.Drawing.Size(225, 20);
            this.nomeParaSalvar.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 416);
            this.Controls.Add(this.nomeParaSalvar);
            this.Controls.Add(this.textBoxMinJanela);
            this.Controls.Add(this.numFacesIdentificadas);
            this.Controls.Add(this.txtFacesIdentificadas);
            this.Controls.Add(this.comboBoxMinViz);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxEscala);
            this.Controls.Add(this.salvarImagem);
            this.Controls.Add(this.iniciarBT);
            this.Controls.Add(this.imageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button iniciarBT;
        private System.Windows.Forms.Button salvarImagem;
        private System.Windows.Forms.ComboBox comboBoxEscala;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBoxMinViz;
        private System.Windows.Forms.TextBox txtFacesIdentificadas;
        private System.Windows.Forms.TextBox numFacesIdentificadas;
        private System.Windows.Forms.TextBox textBoxMinJanela;
        private System.Windows.Forms.TextBox nomeParaSalvar;
    }
}

