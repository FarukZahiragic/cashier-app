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
    public partial class PrikažiRačune : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.ElektronskoPlacanjeConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public PrikažiRačune()
        {
            InitializeComponent();
        }

        private void PrikažiRačune_Load(object sender, EventArgs e)
        {
            IspuniGrid();
            ukupanIznosRacuna();
        }

        private void btnPrikaziRacune_Click(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("Select * from TblPodaciZaglavlja where DatumRačuna between " +
                " '" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "' and " + 
                " '" + dateTimePicker2.Value.ToString("MM/dd/yyyy") + "' order by BrRačuna asc", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "TblPodaciZaglavlja");
            dataGridView1.DataSource = ds.Tables["TblPodaciZaglavlja"];
            con.Close();
            ukupanIznosRacuna();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            textBox1.Text = dr.Cells[0].Value.ToString();

        }

        private void btnIzbrišiRačune_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Izaberite broj računa kojeg želite izbrisati.");
            }
            else {
                DialogResult dialogResult = MessageBox.Show("Da li želite izbrisati izabrani račun", "Brisanje računa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) 
                {
                    SqlCommand cmd = new SqlCommand();
                    SqlCommand cmd1 = new SqlCommand();
                    con.Open();
                    cmd = new SqlCommand("Delete from TblPodaciZaglavlja where BrRačuna = '"+textBox1.Text+"' ", con);
                    cmd1 = new SqlCommand("Delete from TblPodaciReda where BrRačuna = '" + textBox1.Text + "' ", con);

                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    con.Close();

                    IspuniGrid();
                    ukupanIznosRacuna();
                }
                else if (dialogResult == DialogResult.No) 
                {
                    
                }
            }
        }

        public void IspuniGrid() 
        {
            con.Open();
            da = new SqlDataAdapter("Select * from TblPodaciZaglavlja order by BrRačuna asc", con);
            con.Close();
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        // Za prikazivanje broja izdatih racuna i kolicinu prodaje
        public void ukupanIznosRacuna() 
        {
            // Broj racuna
            txtUkupnoRacuna.Text = dataGridView1.Rows.Count.ToString();

            // Ukupan iznos prodaje
            double suma = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                suma += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }
            txtUkupanIznos.Text = suma.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AzurirajRacun ar = new AzurirajRacun();
            ar.txtBrRacuna.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ar.txtUkupanRacun.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ar.txtIznosPopusta.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ar.txtZaPlatiti.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();

            ar.Show(); // Za otvaranje forme AzurirajRacun
            this.Hide(); // Za zatvaranje PrikaziRacune
        }
    }
}
