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
    public partial class AzurirajRacun : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.ElektronskoPlacanjeConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public AzurirajRacun()
        {
            InitializeComponent();
        }

        private void AzurirajRacun_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from TblPodaciReda where BrRačuna like ('"+txtBrRacuna.Text+"%' )";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            // Popuni naziv proizvoda

            cmbProizvodi.Select();

            cmbProizvodi.Items.Clear(); // ciscenje combobox-a prije ucitavanja forme
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select NazivPro from TblProizvodi order by NazivPro asc";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbProizvodi.Items.Add(dr["NazivPro"].ToString());
            }
            con.Close();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }

        private void txtCijena_Leave(object sender, EventArgs e)
        {
            IzracunajIznos();
        }

        public void IzracunajIznos()
        {
            double a1, b1, i;
            double.TryParse(txtCijena.Text, out a1);
            double.TryParse(txtKol.Text, out b1);
            i = a1 * b1;
            if (i > 0)
            {
                txtIznos.Text = i.ToString("C").Remove(0, 1);
            }
        }

        private void txtKol_Leave(object sender, EventArgs e)
        {
            IzracunajIznos();
        }

        private void UcitajSerijskiBr() 
        {
            int i = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[0].Value = i;
                i++;
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UcitajSerijskiBr();
        }

        int i;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow red = dataGridView1.Rows[1];
            txtIzbrisiAzuriranje.Text = red.Cells[0].Value.ToString();
            cmbProizvodi.Text = red.Cells[1].Value.ToString();
            txtCijena.Text = red.Cells[2].Value.ToString();
            txtKol.Text = red.Cells[3].Value.ToString();
            txtIznos.Text = red.Cells[4].Value.ToString();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow red in dataGridView1.SelectedRows)
            {
                if (!red.IsNewRow) dataGridView1.Rows.Remove(red);

                UcitajSerijskiBr();
            }
            ocistiText();
            gridUkupno();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            // Ako je txtIzbrisiAzuriranje text box prazan onda dodaj novi red uostalom azuriraj izabrani red

            if (txtIzbrisiAzuriranje.Text == "")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
                }
                DataTable dt = dataGridView1.DataSource as DataTable;

                DataRow red1 = dt.NewRow();
                red1[1] = cmbProizvodi.Text.ToString();
                red1[2] = txtCijena.Text.ToString();
                red1[3] = txtKol.Text.ToString();
                red1[4] = txtIznos.Text.ToString();
                red1[5] = txtBrRacuna.Text.ToString();

                cmbProizvodi.Focus();
                dt.Rows.Add(red1);
            }
            else 
            {
                DataGridViewRow red = dataGridView1.Rows[i];
                red.Cells[1].Value = cmbProizvodi.Text;
                red.Cells[2].Value = txtCijena.Text;
                red.Cells[3].Value = txtKol.Text;
                red.Cells[4].Value = txtIznos.Text;
                red.Cells[5].Value = txtBrRacuna.Text;
            }

            ocistiText();
            gridUkupno();
        }

        public void ocistiText() 
        {
            cmbProizvodi.Text = "";
            txtCijena.Text = "";
            txtKol.Text = "";
            txtIznos.Text = "";
            txtIzbrisiAzuriranje.Text = "";
        }

        public void IzracunajPopust()
        {
            double a2, b2, i;
            double.TryParse(txtUkupanRacun.Text, out a2);
            double.TryParse(txtIznosPopusta.Text, out b2);
            i = a2 - b2; // Ukupan racun - iznos popusta
            if (i > 0)
            {
                txtZaPlatiti.Text = i.ToString("C").Remove(0, 1);
            }
        }

        public void gridUkupno()
        {
            double suma = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                suma += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }

            txtUkupanRacun.Text = suma.ToString();
        }

        private void txtUkupanRacun_TextChanged(object sender, EventArgs e)
        {
            IzracunajPopust();
        }

        private void BtnSpasi_Click(object sender, EventArgs e)
        {
            // Prvo izbrisati podatke sa starog racunu iz podataka reda
            try
            {
                con.Open();
                cmd = new SqlCommand("Delete from TblPodaciReda where BrRačuna='"+txtBrRacuna.Text+"'", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            // Sada spasiti azurirane podatke racuna
            try
            {
                
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    SqlCommand cmd1 = new SqlCommand("Insert into TblPodaciReda (SrBr, NazivProizvoda, Cijena, Kol, Iznos, BrRačuna, Datum) values ('" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "', '" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "', '" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "', '" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "', '" + dataGridView1.Rows[i].Cells[4].Value.ToString() + "', '" + dataGridView1.Rows[i].Cells[5].Value.ToString() + "', '" + dataGridView1.Rows[i].Cells[6].Value.ToString() + "')", con);
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    con.Close();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            // Sada azurirati ukupan iznos racuna, popust i ukupno za platiti

            try
            {
                con.Open();
                cmd = new SqlCommand("Update TblPodaciZaglavlja set DatumRačuna='" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "', " + 
                    " IznosRačuna= '" + txtUkupanRacun.Text + "', IznosPop= '" + txtIznosPopusta.Text + "', " + 
                    " UkupnoZaPlatiti= '" + txtZaPlatiti.Text + "' where BrRačuna='"+txtBrRacuna.Text+"'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Račun je ažuriran.");

                Class1.strInv = txtBrRacuna.Text;

                this.Hide();
                StampajRacun sr = new StampajRacun();
                sr.Show();
                this.Close();

                txtUkupanRacun.Text = "";
                txtIznosPopusta.Text = "";
                txtZaPlatiti.Text = "";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            // Sakriti ovaj prozor
            this.Hide();
        }

        private void cmbProizvodi_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Select * from TblProizvodi where NazivPro = '" + cmbProizvodi.Text + "' ", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtCijena.Text = dr[2].ToString();
            }
            con.Close();
        }
    }
}
