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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcdpart_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProjeto outroform4 = new frmProjeto();
            outroform4.ShowDialog();
        }

        private void btnCadastrarcand_Click(object sender, EventArgs e)
        {
            if (txtIdpartido.Text == "1" || txtIdpartido.Text == "2" || txtIdpartido.Text == "3" || txtIdpartido.Text == "4")
            {
                SqlConnection con = new SqlConnection("Data source = localhost; Initial Catalog = proj_ele; Persist Security Info = true;User Id = sa;Password = 123456");
                SqlCommand cmd = con.CreateCommand();
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("Select count(num_partido) from candidato", con);
                double Atividade = Convert.ToDouble(sqlCommand.ExecuteScalar());

                SqlCommand cmd1 = con.CreateCommand();
                SqlCommand sqlCommand1 = new SqlCommand("SELECT 1 FROM candidato WHERE num_partido = 1;", con);
                double candidato1 = Convert.ToDouble(sqlCommand1.ExecuteScalar());

                SqlCommand cmd2 = con.CreateCommand();
                SqlCommand sqlCommand2 = new SqlCommand("SELECT 1 FROM candidato WHERE num_partido = 2;", con);
                double candidato2 = Convert.ToDouble(sqlCommand2.ExecuteScalar());

                SqlCommand cmd3 = con.CreateCommand();
                SqlCommand sqlCommand3 = new SqlCommand("SELECT 1 FROM candidato WHERE num_partido = 3;", con);
                double candidato3 = Convert.ToDouble(sqlCommand3.ExecuteScalar());

                SqlCommand cmd4 = con.CreateCommand();
                SqlCommand sqlCommand4 = new SqlCommand("SELECT 1 FROM candidato WHERE num_partido = 4;", con);
                double candidato4 = Convert.ToDouble(sqlCommand4.ExecuteScalar());
                if (txtIdpartido.Text == "")
                {
                    MessageBox.Show("Preencha o numero do partido");
                }
                else if (txtNmpartido.Text == "")
                {
                    MessageBox.Show("Preencha o nome do partido");
                }
                else if (txtNmcandidato.Text == "")
                {
                    MessageBox.Show("Preencha o nome do candidato");
                }

                else if (Atividade >= 4)
                {
                    MessageBox.Show("Já foram 4 candidatos cadastrados!");
                }
                else if (txtIdpartido.Text == "1")
                {
                    if (candidato1 == 1)
                    {
                        MessageBox.Show("Um candidato de partido 1 ja está cadastrado.");
                    }
                    else
                    {
                        string Instrucao_bd;
                        Instrucao_bd = "Insert into candidato (num_partido, nm_partido, nm_candidato, foto_candidato) values (" + txtIdpartido.Text + ", '" + txtNmpartido.Text + "', '" + txtNmcandidato.Text + "', '" + lblNomefoto.Text + "');";
                        cmd = new SqlCommand(Instrucao_bd, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Enviado com sucesso!");
                        pictureBox1.ImageLocation = "";
                        txtIdpartido.Text = "";
                        txtNmcandidato.Text = "";
                        txtNmpartido.Text = "";
                    }
                }
                else if (txtIdpartido.Text == "2")
                {
                    if (candidato2 == 1)
                    {
                        MessageBox.Show("Um candidato de partido 2 ja está cadastrado.");
                    }
                    else
                    {
                        string Instrucao_bd;
                        Instrucao_bd = "Insert into candidato (num_partido, nm_partido, nm_candidato, foto_candidato) values (" + txtIdpartido.Text + ", '" + txtNmpartido.Text + "', '" + txtNmcandidato.Text + "', '" + lblNomefoto.Text + "');";
                        cmd = new SqlCommand(Instrucao_bd, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Enviado com sucesso!");
                        pictureBox1.ImageLocation = "";
                        txtIdpartido.Text = "";
                        txtNmcandidato.Text = "";
                        txtNmpartido.Text = "";
                    }
                }
                else if (txtIdpartido.Text == "3")
                {
                    if (candidato3 == 1)
                    {
                        MessageBox.Show("Um candidato de partido 3 ja está cadastrado.");
                    }
                    else
                    {
                        string Instrucao_bd;
                        Instrucao_bd = "Insert into candidato (num_partido, nm_partido, nm_candidato, foto_candidato) values (" + txtIdpartido.Text + ", '" + txtNmpartido.Text + "', '" + txtNmcandidato.Text + "', '" + lblNomefoto.Text + "');";
                        cmd = new SqlCommand(Instrucao_bd, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Enviado com sucesso!");
                        pictureBox1.ImageLocation = "";
                        txtIdpartido.Text = "";
                        txtNmcandidato.Text = "";
                        txtNmpartido.Text = "";
                    }
                }
                else if (txtIdpartido.Text == "4")
                {
                    if (candidato4 == 1)
                    {
                        MessageBox.Show("Um candidato de partido 4 ja está cadastrado.");
                    }
                    else
                    {
                        string Instrucao_bd;
                        Instrucao_bd = "Insert into candidato (num_partido, nm_partido, nm_candidato, foto_candidato) values (" + txtIdpartido.Text + ", '" + txtNmpartido.Text + "', '" + txtNmcandidato.Text + "', '" + lblNomefoto.Text + "');";
                        cmd = new SqlCommand(Instrucao_bd, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Enviado com sucesso!");
                        pictureBox1.ImageLocation = "";
                        txtIdpartido.Text = "";
                        txtNmcandidato.Text = "";
                        txtNmpartido.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("O numero do partido tem que estar entre 1 e 4");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog arquivo = new OpenFileDialog();
            arquivo.Filter = "png|*.png|jpg|*.jpg";
            if (arquivo.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = arquivo.FileName;
                txtIdpartido.Enabled = true;
                txtNmpartido.Enabled = true;
                txtNmcandidato.Enabled = true;
                lblNomefoto.Text = arquivo.FileName;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
