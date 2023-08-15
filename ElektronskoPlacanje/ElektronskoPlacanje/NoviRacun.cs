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
    public partial class NoviRacun : Form
    {

        SqlConnection con = new SqlConnection(Properties.Settings.Default.ElektronskoPlacanjeConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;

        public NoviRacun()
        {
            InitializeComponent();
            txtIzbrisiAzuriranje.Visible = false;
        }

        private void NoviRacun_Load(object sender, EventArgs e)
        {
            cmbProizvodi.Select();

            cmbProizvodi.Items.Clear(); // ciscenje combobox-a prije ucitavanja forme
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select NazivPro from TblProizvodi order by NazivPro asc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbProizvodi.Items.Add(dr["NazivPro"].ToString());
            }
            con.Close();

            UcitajBrRacuna();

            // dataGridView1.Columns[5].Visible = false;
            // dataGridView1.Columns[6].Visible = false;
        }

        public void UcitajBrRacuna() { 
        
            // Ucitavanje br racuna iz baze podataka
            int a;
            string constr = (Properties.Settings.Default.ElektronskoPlacanjeConnectionString);
            con = new SqlConnection(constr);
            con.Open();
            string query = "Select Max(BrRačuna) from TblPodaciZaglavlja";
            cmd = new SqlCommand(query, con);

            dr = cmd.ExecuteReader();

            if(dr.Read()) 
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    txtBrRacuna.Text = "1";
                }
                else 
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    txtBrRacuna.Text = a.ToString();
                }
                con.Close();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (cmbProizvodi.Text == "") 
            {
                MessageBox.Show("Naziv proizvoda je prazan.");
            }
            else if(txtCijena.Text=="") 
            {
                MessageBox.Show("Cijena proizvoda je prazna.");
            }
            else if (txtKol.Text == "")
            {
                MessageBox.Show("Količina proizvoda je prazna.");
            }
            else 
            {
                // Za dodavanje podataka u gridview
                if (txtIzbrisiAzuriranje.Text == "") 
                {
                    int red = 0;
                    dataGridView1.Rows.Add();
                    red = dataGridView1.Rows.Count - 1;
                    dataGridView1["NazivProizvoda", red].Value = cmbProizvodi.Text;
                    dataGridView1["Cijena", red].Value = txtCijena.Text;
                    dataGridView1["Kol", red].Value = txtKol.Text;
                    dataGridView1["Iznos", red].Value = txtIznos.Text;
                    dataGridView1["BrRačuna", red].Value = txtBrRacuna.Text;
                    dataGridView1["Datum", red].Value = dateTimePicker1.Value.ToString("dd-MM-yyyy");

                    dataGridView1.Refresh();
                    cmbProizvodi.Focus();

                    if (dataGridView1.Rows.Count > 0)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1];
                    }
                }
                    else 
                    {
                        int i;
                        i = Convert.ToInt32(txtIzbrisiAzuriranje.Text);
                        DataGridViewRow red = dataGridView1.Rows[i-1];
                        red.Cells[1].Value = cmbProizvodi.Text;
                        red.Cells[2].Value = txtCijena.Text;
                        red.Cells[3].Value = txtKol.Text;
                        red.Cells[4].Value = txtIznos.Text;

                        btnDodaj.Text = "Dodaj";
                    } 

                    ocistitextbox();

                    gridUkupno();
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex+1).ToString();
        }

        int i;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];
            cmbProizvodi.Text = row.Cells[1].Value.ToString();
            txtCijena.Text = row.Cells[2].Value.ToString();
            txtKol.Text = row.Cells[3].Value.ToString();
            txtIznos.Text = row.Cells[4].Value.ToString();
            txtIzbrisiAzuriranje.Text = row.Cells[0].Value.ToString();

            btnDodaj.Text = "Ažuriraj";
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (txtIzbrisiAzuriranje.Text == "")
            {
                MessageBox.Show("Izaberite proizvod koji želite izbrisati.");
            }
            else 
            {
                foreach(DataGridViewRow row in dataGridView1.SelectedRows) 
                {
                    if (!row.IsNewRow) dataGridView1.Rows.Remove(row);
                }
            }
            btnDodaj.Text = "Dodaj";

            gridUkupno();
            ocistitextbox();
        }

        public void ocistitextbox()
        {
            cmbProizvodi.Text = "";
            txtCijena.Text = "";
            txtKol.Text = "";
            txtIznos.Text = "";
            txtIzbrisiAzuriranje.Text = "";
        }

        public void IzracunajIznos() 
        {
            double a1, b1, i;
            double.TryParse(txtCijena.Text, out a1);
            double.TryParse(txtKol.Text, out b1);
            i = a1 * b1;
            if (i>0) 
            {
                txtIznos.Text = i.ToString("C").Remove(0, 1);
            }
        }

        private void txtKol_Leave(object sender, EventArgs e)
        {
            IzracunajIznos();
        }

        private void txtCijena_Leave(object sender, EventArgs e)
        {
            IzracunajIznos();
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

        private void txtUkupanRacun_TextChanged(object sender, EventArgs e)
        {
            IzracunajPopust();
        }

        private void txtIznosPopusta_Leave(object sender, EventArgs e)
        {
            IzracunajPopust();
        }

        private void BtnSpasi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("Dodajte barem jedan proizvod na račun");
            }
            else 
            {
                // Spasi glavne podatke
                con.Open();
                cmd = new SqlCommand("Insert into TblPodaciZaglavlja (BrRačuna,DatumRačuna,IznosRačuna,IznosPop,UkupnoZaPlatiti) values " + 
                    " ('"+txtBrRacuna.Text+"', '"+dateTimePicker1.Value.ToString("MM/dd/yyyy")+"', '"+txtUkupanRacun.Text+"', '"+txtIznosPopusta.Text+"', '"+txtZaPlatiti.Text+"')", con);
                cmd.ExecuteNonQuery();
                

                // Spasi podatke reda dataGridViewa
                for (int i = 0; i < dataGridView1.Rows.Count; i++) 
                {
                    SqlCommand cmd1 = new SqlCommand("Insert into TblPodaciReda (SrBr,NazivProizvoda,Cijena,Kol,Iznos,BrRačuna) values " + 
                        " ('" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "', " +
                        " '" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[4].Value.ToString() + "','" + dataGridView1.Rows[i].Cells[5].Value.ToString() + "')", con);
                    cmd1.ExecuteNonQuery();
                }
                dataGridView1.Rows.Clear();

                MessageBox.Show("Račun je spašen.");
                con.Close();

                Class1.strInv = txtBrRacuna.Text;

                UcitajBrRacuna();
                ocistitextbox();

                txtUkupanRacun.Text = "";
                txtIznosPopusta.Text = "";
                txtZaPlatiti.Text = "";

                cmbProizvodi.Select();

                StampajRacun sr = new StampajRacun();
                sr.ShowDialog();
            }
        }

        private void cmbProizvodi_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Select * from TblProizvodi where NazivPro = '"+cmbProizvodi.Text+"' ", con);
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
