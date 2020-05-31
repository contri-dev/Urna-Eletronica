using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmPerm1 : Form
    {
        public frmPerm1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            if (txtNomeadm.Text == "admin" | txtSenhaadm.Text == "admin")
            {
                frmCadastro novaform = new frmCadastro();
                novaform.Show();
                this.Hide();
                this.Close();
            }

            else
            {
                MessageBox.Show("Nome ou senha errados!");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProjeto outroform2 = new frmProjeto();
            outroform2.ShowDialog();
        }
    }
}
