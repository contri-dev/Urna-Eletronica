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
    public partial class frmApurar : Form
    {
        public frmApurar()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnApurar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source = localhost; Initial Catalog = proj_ele; Persist Security Info = true;User Id = sa;Password = 123456");



            SqlCommand cmd1 = con.CreateCommand();
            con.Open();
            SqlCommand sqlCommand1 = new SqlCommand("Select count(id_voto) from voto where num_partido=(select num_partido from candidato where num_partido = 1)", con);
            string Apurar1 = Convert.ToString(sqlCommand1.ExecuteScalar());
            lblCandidato1.Text = Apurar1;

            SqlCommand cmd2 = con.CreateCommand();
            SqlCommand sqlCommand2 = new SqlCommand("Select count(id_voto) from voto where num_partido=(select num_partido from candidato where num_partido = 2)", con);
            string Apurar2 = Convert.ToString(sqlCommand2.ExecuteScalar());
            lblCandidato2.Text = Apurar2;

            SqlCommand cmd3 = con.CreateCommand();
            SqlCommand sqlCommand3 = new SqlCommand("Select count(id_voto) from voto where num_partido=(select num_partido from candidato where num_partido = 3)", con);
            string Apurar3 = Convert.ToString(sqlCommand3.ExecuteScalar());
            lblCandidato3.Text = Apurar3;

            SqlCommand cmd4 = con.CreateCommand();
            SqlCommand sqlCommand4 = new SqlCommand("Select count(id_voto) from voto where num_partido=(select num_partido from candidato where num_partido = 4)", con);
            string Apurar4 = Convert.ToString(sqlCommand4.ExecuteScalar());
            lblCandidato4.Text = Apurar4;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProjeto outroform2 = new frmProjeto();
            outroform2.ShowDialog();
        }

        private void btnDelregistros_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source = localhost; Initial Catalog = proj_ele; Persist Security Info = true;User Id = sa;Password = 123456");
            SqlCommand cmd = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();
            con.Open();
            string delete_voto;
                    string delete_cand;
                    delete_voto = "delete from voto";
                    delete_cand = "delete from candidato";
                    cmd = new SqlCommand(delete_voto, con);
                    cmd2 = new SqlCommand(delete_cand, con);
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Registros apagados!");


        }

        private void frmApurar_Load(object sender, EventArgs e)
        {

        }
    }
}
