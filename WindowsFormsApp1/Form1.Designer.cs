namespace WindowsFormsApp1
{
    partial class frmProjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjeto));
            this.lblSeleitoral = new System.Windows.Forms.Label();
            this.btnVotar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnApurar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSeleitoral
            // 
            this.lblSeleitoral.AutoSize = true;
            this.lblSeleitoral.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleitoral.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleitoral.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSeleitoral.Location = new System.Drawing.Point(79, 22);
            this.lblSeleitoral.Name = "lblSeleitoral";
            this.lblSeleitoral.Size = new System.Drawing.Size(314, 44);
            this.lblSeleitoral.TabIndex = 0;
            this.lblSeleitoral.Text = "Sistema Eleitoral";
            this.lblSeleitoral.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnVotar
            // 
            this.btnVotar.BackColor = System.Drawing.Color.Transparent;
            this.btnVotar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVotar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVotar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnVotar.Location = new System.Drawing.Point(35, 85);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(404, 61);
            this.btnVotar.TabIndex = 1;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = false;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.White;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCadastrar.Location = new System.Drawing.Point(35, 152);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(404, 61);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar Candidato";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnApurar
            // 
            this.btnApurar.BackColor = System.Drawing.Color.White;
            this.btnApurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApurar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApurar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnApurar.Location = new System.Drawing.Point(35, 219);
            this.btnApurar.Name = "btnApurar";
            this.btnApurar.Size = new System.Drawing.Size(404, 61);
            this.btnApurar.TabIndex = 3;
            this.btnApurar.Text = "Apurar Votos";
            this.btnApurar.UseVisualStyleBackColor = false;
            this.btnApurar.Click += new System.EventHandler(this.btnApurar_Click);
            // 
            // frmProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 305);
            this.Controls.Add(this.btnApurar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.lblSeleitoral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eleições";
            this.Load += new System.EventHandler(this.frmProjeto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleitoral;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnApurar;
    }
}

