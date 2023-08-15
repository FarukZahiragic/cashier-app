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

namespace ElektronskoPlacanje
{
    public partial class Proizvodi : Form
    {

        SqlConnection con = new SqlConnection(Properties.Settings.Default.ElektronskoPlacanjeConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public Proizvodi()
        {
            InitializeComponent();
        }

        private void Proizvodi_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            // spasavanje informacija o proizvodima

            if (txtProNaziv.Text == "")
            {
                MessageBox.Show("Molimo vas unesite naziv proizvoda");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO TblProizvodi (NazivPro, CijenaPro)VALUES('" + txtProNaziv.Text + "', '"+txtCijena.Text+"')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Informacije o proizvodu su spašene. . .");
                    // poslije spasavanja novih proizvoda prikazi nedavno spasene proizvode u gridview-u
                    fillGrid();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void fillGrid() 
        {
            // popuniti datagridview iz datatable-a
            con.Open();
            da = new SqlDataAdapter("select * from TblProizvodi order by NazivPro asc", con);
            con.Close();
            SqlCommandBuilder cd = new SqlCommandBuilder(da);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;    
        }

        int i;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow red = dataGridView1.Rows[i];
            txtProID.Text = red.Cells[0].Value.ToString();
            txtProNaziv.Text = red.Cells[1].Value.ToString();
            txtCijena.Text = red.Cells[2].Value.ToString();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            // Prije azuriranja provjeriti ispravnost

            if (txtProID.Text == "")
            {
                MessageBox.Show("Molimo vas izaberite proizvod koji želite ažurirati.");
            }
            else
            {

                try
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE TblProizvodi SET NazivPro='" + txtProNaziv.Text + "', CijenaPro='"+txtCijena.Text+"' where IDPro='" + txtProID.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Informacije o proizvodu su ažurirane. . .");
                    fillGrid();
                    izbrisiText();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void izbrisiText() {
            txtProID.Text = "";
            txtProNaziv.Text = "";
            txtCijena.Text = "";
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            // Provjeriti da li je proizvod izabran

            if (txtProID.Text == "")
            {
                MessageBox.Show("Molimo vas izaberite proizvod koji želite izbrisati.");
            }
            else
            {

                try
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM TblProizvodi WHERE IDPro='" + txtProID.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Informacije o proizvodu su izbrisane. . .");
                    fillGrid();
                    izbrisiText();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtOcisti_Click(object sender, EventArgs e)
        {
            izbrisiText();
        }
    }
}
