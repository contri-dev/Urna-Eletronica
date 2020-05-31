namespace WindowsFormsApp1
{
    partial class frmPerm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerm1));
            this.btnEntrada = new System.Windows.Forms.Button();
            this.txtNomeadm = new System.Windows.Forms.TextBox();
            this.txtSenhaadm = new System.Windows.Forms.TextBox();
            this.lblRestricao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomesu = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEntrada
            // 
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEntrada.Location = new System.Drawing.Point(140, 210);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(179, 26);
            this.btnEntrada.TabIndex = 0;
            this.btnEntrada.Text = "Entrar";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // txtNomeadm
            // 
            this.txtNomeadm.ForeColor = System.Drawing.Color.DarkRed;
            this.txtNomeadm.Location = new System.Drawing.Point(204, 115);
            this.txtNomeadm.Name = "txtNomeadm";
            this.txtNomeadm.Size = new System.Drawing.Size(115, 20);
            this.txtNomeadm.TabIndex = 1;
            this.txtNomeadm.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSenhaadm
            // 
            this.txtSenhaadm.ForeColor = System.Drawing.Color.DarkRed;
            this.txtSenhaadm.Location = new System.Drawing.Point(204, 152);
            this.txtSenhaadm.Name = "txtSenhaadm";
            this.txtSenhaadm.PasswordChar = '*';
            this.txtSenhaadm.Size = new System.Drawing.Size(115, 20);
            this.txtSenhaadm.TabIndex = 2;
            // 
            // lblRestricao
            // 
            this.lblRestricao.AutoSize = true;
            this.lblRestricao.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestricao.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRestricao.Location = new System.Drawing.Point(152, 57);
            this.lblRestricao.Name = "lblRestricao";
            this.lblRestricao.Size = new System.Drawing.Size(169, 26);
            this.lblRestricao.TabIndex = 3;
            this.lblRestricao.Text = "AREA RESTRITA!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(136, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            // 
            // lblNomesu
            // 
            this.lblNomesu.AutoSize = true;
            this.lblNomesu.BackColor = System.Drawing.Color.Transparent;
            this.lblNomesu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomesu.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNomesu.Location = new System.Drawing.Point(136, 115);
            this.lblNomesu.Name = "lblNomesu";
            this.lblNomesu.Size = new System.Drawing.Size(51, 20);
            this.lblNomesu.TabIndex = 5;
            this.lblNomesu.Text = "Nome";
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmPerm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 305);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblNomesu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRestricao);
            this.Controls.Add(this.txtSenhaadm);
            this.Controls.Add(this.txtNomeadm);
            this.Controls.Add(this.btnEntrada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPerm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logar como administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.TextBox txtNomeadm;
        private System.Windows.Forms.TextBox txtSenhaadm;
        private System.Windows.Forms.Label lblRestricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomesu;
        private System.Windows.Forms.Button btnVoltar;
    }
}