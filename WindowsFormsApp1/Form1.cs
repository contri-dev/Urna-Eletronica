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
    public partial class frmProjeto : Form
    {
        public frmProjeto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPerm1 outroform3 = new frmPerm1();
            outroform3.ShowDialog();
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVoto outroform = new frmVoto();
            outroform.ShowDialog();
        }

        private void btnApurar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmApurar outroform = new frmApurar();
            outroform.ShowDialog();
        }

        private void frmProjeto_Load(object sender, EventArgs e)
        {

        }
    }
}
