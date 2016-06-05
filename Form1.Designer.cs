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
            this.textBoxNomeDaImagem = new System.Windows.Forms.TextBox();
            this.carregarImagemBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbFacesExtraidas = new System.Windows.Forms.PictureBox();
            this.btPre = new System.Windows.Forms.Button();
            this.btPos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFacesExtraidas)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(12, 12);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(703, 371);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.salvarImagem.Location = new System.Drawing.Point(783, 360);
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
            this.comboBoxEscala.Items.AddRange(new object[] {
            "1.1",
            "1.2",
            "1.3",
            "1.4"});
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
            this.comboBoxMinViz.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxMinViz.Location = new System.Drawing.Point(825, 45);
            this.comboBoxMinViz.Name = "comboBoxMinViz";
            this.comboBoxMinViz.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMinViz.TabIndex = 9;
            // 
            // txtFacesIdentificadas
            // 
            this.txtFacesIdentificadas.Location = new System.Drawing.Point(721, 98);
            this.txtFacesIdentificadas.Name = "txtFacesIdentificadas";
            this.txtFacesIdentificadas.ReadOnly = true;
            this.txtFacesIdentificadas.Size = new System.Drawing.Size(153, 20);
            this.txtFacesIdentificadas.TabIndex = 11;
            this.txtFacesIdentificadas.Text = "Numero de faces identificadas";
            this.txtFacesIdentificadas.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // numFacesIdentificadas
            // 
            this.numFacesIdentificadas.Location = new System.Drawing.Point(880, 98);
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
            this.nomeParaSalvar.Location = new System.Drawing.Point(721, 334);
            this.nomeParaSalvar.Name = "nomeParaSalvar";
            this.nomeParaSalvar.Size = new System.Drawing.Size(225, 20);
            this.nomeParaSalvar.TabIndex = 14;
            this.nomeParaSalvar.TextChanged += new System.EventHandler(this.nomeParaSalvar_TextChanged);
            // 
            // textBoxNomeDaImagem
            // 
            this.textBoxNomeDaImagem.Location = new System.Drawing.Point(783, 308);
            this.textBoxNomeDaImagem.Name = "textBoxNomeDaImagem";
            this.textBoxNomeDaImagem.ReadOnly = true;
            this.textBoxNomeDaImagem.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomeDaImagem.TabIndex = 15;
            this.textBoxNomeDaImagem.Text = "Nome da imagem";
            this.textBoxNomeDaImagem.TextChanged += new System.EventHandler(this.textBoxNomeDaImagem_TextChanged);
            // 
            // carregarImagemBtn
            // 
            this.carregarImagemBtn.Location = new System.Drawing.Point(12, 389);
            this.carregarImagemBtn.Name = "carregarImagemBtn";
            this.carregarImagemBtn.Size = new System.Drawing.Size(119, 23);
            this.carregarImagemBtn.TabIndex = 16;
            this.carregarImagemBtn.Text = "Carregar Imagem";
            this.carregarImagemBtn.UseVisualStyleBackColor = true;
            this.carregarImagemBtn.Click += new System.EventHandler(this.carregarImagemBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pbFacesExtraidas
            // 
            this.pbFacesExtraidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFacesExtraidas.Location = new System.Drawing.Point(746, 124);
            this.pbFacesExtraidas.Name = "pbFacesExtraidas";
            this.pbFacesExtraidas.Size = new System.Drawing.Size(185, 141);
            this.pbFacesExtraidas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFacesExtraidas.TabIndex = 17;
            this.pbFacesExtraidas.TabStop = false;
            // 
            // btPre
            // 
            this.btPre.Location = new System.Drawing.Point(746, 271);
            this.btPre.Name = "btPre";
            this.btPre.Size = new System.Drawing.Size(75, 23);
            this.btPre.TabIndex = 18;
            this.btPre.Text = "<";
            this.btPre.UseVisualStyleBackColor = true;
            this.btPre.Click += new System.EventHandler(this.btPre_Click);
            // 
            // btPos
            // 
            this.btPos.Location = new System.Drawing.Point(856, 271);
            this.btPos.Name = "btPos";
            this.btPos.Size = new System.Drawing.Size(75, 23);
            this.btPos.TabIndex = 19;
            this.btPos.Text = ">";
            this.btPos.UseVisualStyleBackColor = true;
            this.btPos.Click += new System.EventHandler(this.btPos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 416);
            this.Controls.Add(this.btPos);
            this.Controls.Add(this.btPre);
            this.Controls.Add(this.pbFacesExtraidas);
            this.Controls.Add(this.carregarImagemBtn);
            this.Controls.Add(this.textBoxNomeDaImagem);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbFacesExtraidas)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxNomeDaImagem;
        private System.Windows.Forms.Button carregarImagemBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbFacesExtraidas;
        private System.Windows.Forms.Button btPre;
        private System.Windows.Forms.Button btPos;
    }
}

