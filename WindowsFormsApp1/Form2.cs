using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class frmVoto : Form
    {
        public frmVoto()
        {
            InitializeComponent();
        }

        private void btnVoltar1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProjeto outroform2 = new frmProjeto();
            outroform2.ShowDialog();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source = localhost; Initial Catalog = proj_ele; Persist Security Info = true;User Id = sa;Password = 123456");
            SqlCommand cmd = con.CreateCommand();
            con.Open();

            if (txtIdpartido.Text == "")
            {
                MessageBox.Show("Preencha o numero do candidato!");
            }

            else
            {
                string Instrucao_voto;
                Instrucao_voto = "Insert into voto (num_partido) values (" + Convert.ToInt32(txtIdpartido.Text) + ");";
                cmd = new SqlCommand(Instrucao_voto, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Voto registrado!");
                txtIdpartido.Text = "";
                pictureBox1.ImageLocation = "";
                lblNmpartido.Text = "";
                lblNmcandidato.Text = "";
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source = localhost; Initial Catalog = proj_ele; Persist Security Info = true;User Id = sa;Password = 123456");
            SqlCommand cmd = con.CreateCommand();
            con.Open();
            SqlCommand sqlfoto = new SqlCommand("Select foto_candidato from candidato where num_partido=" + txtIdpartido.Text + "", con);
            string imagem_candidato = Convert.ToString(sqlfoto.ExecuteScalar());
            pictureBox1.ImageLocation = imagem_candidato;

            SqlCommand sqlnomecand = new SqlCommand("Select nm_candidato from candidato where num_partido=" + txtIdpartido.Text + "", con);
            string nome_candidato = Convert.ToString(sqlnomecand.ExecuteScalar());
            lblNmpartido.Text = nome_candidato;

            SqlCommand sqlnomepart = new SqlCommand("Select nm_partido from candidato where num_partido=" + txtIdpartido.Text + "", con);
            string nome_partido = Convert.ToString(sqlnomepart.ExecuteScalar());
            lblNmcandidato.Text = nome_partido;


        }

        private void frmVoto_Load(object sender, EventArgs e)
        {

        }

        private void btnAnula_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
