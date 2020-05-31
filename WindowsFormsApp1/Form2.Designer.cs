namespace WindowsFormsApp1
{
    partial class frmVoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVoto));
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnAnula = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtIdpartido = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNmcandidato = new System.Windows.Forms.Label();
            this.lblNmpartido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoltar1 = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.Location = new System.Drawing.Point(286, 205);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(94, 41);
            this.btnConfirma.TabIndex = 2;
            this.btnConfirma.Text = "CONFIRMA";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnAnula
            // 
            this.btnAnula.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAnula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnula.Location = new System.Drawing.Point(186, 205);
            this.btnAnula.Name = "btnAnula";
            this.btnAnula.Size = new System.Drawing.Size(94, 41);
            this.btnAnula.TabIndex = 1;
            this.btnAnula.Text = "BRANCO";
            this.btnAnula.UseVisualStyleBackColor = false;
            this.btnAnula.Click += new System.EventHandler(this.btnAnula_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(88, 205);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 41);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtIdpartido
            // 
            this.txtIdpartido.ForeColor = System.Drawing.Color.DarkRed;
            this.txtIdpartido.Location = new System.Drawing.Point(200, 150);
            this.txtIdpartido.Name = "txtIdpartido";
            this.txtIdpartido.Size = new System.Drawing.Size(100, 20);
            this.txtIdpartido.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(88, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblNmcandidato
            // 
            this.lblNmcandidato.AutoSize = true;
            this.lblNmcandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmcandidato.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNmcandidato.Location = new System.Drawing.Point(196, 83);
            this.lblNmcandidato.Name = "lblNmcandidato";
            this.lblNmcandidato.Size = new System.Drawing.Size(110, 16);
            this.lblNmcandidato.TabIndex = 5;
            this.lblNmcandidato.Text = "Nome Candidato";
            // 
            // lblNmpartido
            // 
            this.lblNmpartido.AutoSize = true;
            this.lblNmpartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmpartido.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNmpartido.Location = new System.Drawing.Point(197, 114);
            this.lblNmpartido.Name = "lblNmpartido";
            this.lblNmpartido.Size = new System.Drawing.Size(102, 16);
            this.lblNmpartido.TabIndex = 6;
            this.lblNmpartido.Text = "Numero Partido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(201, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Voto";
            // 
            // btnVoltar1
            // 
            this.btnVoltar1.BackColor = System.Drawing.Color.White;
            this.btnVoltar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar1.ForeColor = System.Drawing.Color.DarkRed;
            this.btnVoltar1.Location = new System.Drawing.Point(3, 3);
            this.btnVoltar1.Name = "btnVoltar1";
            this.btnVoltar1.Size = new System.Drawing.Size(63, 22);
            this.btnVoltar1.TabIndex = 8;
            this.btnVoltar1.Text = "< Voltar";
            this.btnVoltar1.UseVisualStyleBackColor = false;
            this.btnVoltar1.Click += new System.EventHandler(this.btnVoltar1_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnProcurar.Location = new System.Drawing.Point(306, 149);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 21);
            this.btnProcurar.TabIndex = 9;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // frmVoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 305);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.btnVoltar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNmpartido);
            this.Controls.Add(this.lblNmcandidato);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtIdpartido);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.btnAnula);
            this.Controls.Add(this.btnCancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Votação";
            this.Load += new System.EventHandler(this.frmVoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnAnula;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtIdpartido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNmcandidato;
        private System.Windows.Forms.Label lblNmpartido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVoltar1;
        private System.Windows.Forms.Button btnProcurar;
    }
}