namespace WindowsFormsApp1
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.lblcdpart = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdpartido = new System.Windows.Forms.TextBox();
            this.txtNmpartido = new System.Windows.Forms.TextBox();
            this.txtNmcandidato = new System.Windows.Forms.TextBox();
            this.btnCadastrarcand = new System.Windows.Forms.Button();
            this.btnVoltar2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.lblNomefoto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcdpart
            // 
            this.lblcdpart.AutoSize = true;
            this.lblcdpart.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcdpart.ForeColor = System.Drawing.Color.DarkRed;
            this.lblcdpart.Location = new System.Drawing.Point(9, 211);
            this.lblcdpart.Name = "lblcdpart";
            this.lblcdpart.Size = new System.Drawing.Size(99, 16);
            this.lblcdpart.TabIndex = 0;
            this.lblcdpart.Text = "Número Partido:";
            this.lblcdpart.Click += new System.EventHandler(this.lblcdpart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(9, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Partido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(9, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome Candidato:";
            // 
            // txtIdpartido
            // 
            this.txtIdpartido.Enabled = false;
            this.txtIdpartido.ForeColor = System.Drawing.Color.DarkRed;
            this.txtIdpartido.Location = new System.Drawing.Point(117, 209);
            this.txtIdpartido.Name = "txtIdpartido";
            this.txtIdpartido.Size = new System.Drawing.Size(31, 20);
            this.txtIdpartido.TabIndex = 3;
            // 
            // txtNmpartido
            // 
            this.txtNmpartido.Enabled = false;
            this.txtNmpartido.ForeColor = System.Drawing.Color.DarkRed;
            this.txtNmpartido.Location = new System.Drawing.Point(117, 244);
            this.txtNmpartido.Name = "txtNmpartido";
            this.txtNmpartido.Size = new System.Drawing.Size(153, 20);
            this.txtNmpartido.TabIndex = 4;
            this.txtNmpartido.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNmcandidato
            // 
            this.txtNmcandidato.Enabled = false;
            this.txtNmcandidato.ForeColor = System.Drawing.Color.DarkRed;
            this.txtNmcandidato.Location = new System.Drawing.Point(117, 279);
            this.txtNmcandidato.Name = "txtNmcandidato";
            this.txtNmcandidato.Size = new System.Drawing.Size(135, 20);
            this.txtNmcandidato.TabIndex = 5;
            // 
            // btnCadastrarcand
            // 
            this.btnCadastrarcand.BackColor = System.Drawing.Color.White;
            this.btnCadastrarcand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarcand.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCadastrarcand.Location = new System.Drawing.Point(315, 275);
            this.btnCadastrarcand.Name = "btnCadastrarcand";
            this.btnCadastrarcand.Size = new System.Drawing.Size(127, 26);
            this.btnCadastrarcand.TabIndex = 6;
            this.btnCadastrarcand.Text = "Cadastrar Candidato";
            this.btnCadastrarcand.UseVisualStyleBackColor = false;
            this.btnCadastrarcand.Click += new System.EventHandler(this.btnCadastrarcand_Click);
            // 
            // btnVoltar2
            // 
            this.btnVoltar2.BackColor = System.Drawing.Color.White;
            this.btnVoltar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar2.ForeColor = System.Drawing.Color.DarkRed;
            this.btnVoltar2.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar2.Name = "btnVoltar2";
            this.btnVoltar2.Size = new System.Drawing.Size(62, 22);
            this.btnVoltar2.TabIndex = 7;
            this.btnVoltar2.Text = "< Voltar";
            this.btnVoltar2.UseVisualStyleBackColor = false;
            this.btnVoltar2.Click += new System.EventHandler(this.btnVoltar2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(131, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cadastro do Candidato";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.BackColor = System.Drawing.Color.White;
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoto.ForeColor = System.Drawing.Color.DarkRed;
            this.btnFoto.Location = new System.Drawing.Point(136, 134);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(116, 37);
            this.btnFoto.TabIndex = 10;
            this.btnFoto.Text = "Carregar Foto";
            this.btnFoto.UseVisualStyleBackColor = false;
            this.btnFoto.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNomefoto
            // 
            this.lblNomefoto.AutoSize = true;
            this.lblNomefoto.Location = new System.Drawing.Point(133, 80);
            this.lblNomefoto.Name = "lblNomefoto";
            this.lblNomefoto.Size = new System.Drawing.Size(0, 13);
            this.lblNomefoto.TabIndex = 11;
            this.lblNomefoto.Visible = false;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 305);
            this.Controls.Add(this.lblNomefoto);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar2);
            this.Controls.Add(this.btnCadastrarcand);
            this.Controls.Add(this.txtNmcandidato);
            this.Controls.Add(this.txtNmpartido);
            this.Controls.Add(this.txtIdpartido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblcdpart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Candidato";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcdpart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdpartido;
        private System.Windows.Forms.TextBox txtNmpartido;
        private System.Windows.Forms.TextBox txtNmcandidato;
        private System.Windows.Forms.Button btnCadastrarcand;
        private System.Windows.Forms.Button btnVoltar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Label lblNomefoto;
    }
}