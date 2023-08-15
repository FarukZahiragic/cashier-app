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
using CrystalDecisions.CrystalReports.Engine;

namespace ElektronskoPlacanje
{
    public partial class StampajRacun : Form
    {

        SqlConnection con = new SqlConnection(Properties.Settings.Default.ElektronskoPlacanjeConnectionString);
        ReportDocument cryrpt = new ReportDocument();
        SqlDataAdapter da;

        public StampajRacun()
        {
            InitializeComponent();
        }

        private void StampajRacun_Load(object sender, EventArgs e)
        {
            txtBrRacuna.Text = Class1.strInv;

            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select TblPodaciZaglavlja.BrRačuna, TblPodaciZaglavlja.DatumRačuna, TblPodaciZaglavlja.IznosRačuna, TblPodaciZaglavlja.IznosPop, TblPodaciZaglavlja.UkupnoZaPlatiti, TblPodaciReda.SrBr, TblPodaciReda.NazivProizvoda, TblPodaciReda.Cijena, TblPodaciReda.Kol, TblPodaciReda.Iznos, TblPodaciReda.BrRačuna from TblPodaciZaglavlja inner join TblPodaciReda on TblPodaciZaglavlja.BrRačuna =TblPodaciReda.BrRačuna where TblPodaciZaglavlja.BrRačuna = '" + txtBrRacuna.Text + "'", con);
                DataSet dst = new DataSet();
                da.Fill(dst, "ŠtampajRačun");
                cryrpt.Load("StampajRacune.rpt");
                cryrpt.SetDataSource(dst);
                crystalReportViewer1.ReportSource = cryrpt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Class1.strInv = "";
        }

        private void btnPronađi_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select TblPodaciZaglavlja.BrRačuna, TblPodaciZaglavlja.DatumRačuna, " + 
                    " TblPodaciZaglavlja.IznosRačuna, TblPodaciZaglavlja.IznosPop, TblPodaciZaglavlja.UkupnoZaPlatiti, " + 
                    " TblPodaciReda.SrBr, TblPodaciReda.NazivProizvoda, TblPodaciReda.Cijena, TblPodaciReda.Kol, " + 
                    " TblPodaciReda.Iznos, TblPodaciReda.BrRačuna from TblPodaciZaglavlja inner join TblPodaciReda on " + 
                    " TblPodaciZaglavlja.BrRačuna =TblPodaciReda.BrRačuna where TblPodaciZaglavlja.BrRačuna = '" + txtBrRacuna.Text + "'", con);
                DataSet dst = new DataSet();
                da.Fill(dst, "ŠtampajRačun");
                cryrpt.Load("StampajRacune.rpt");
                cryrpt.SetDataSource(dst);
                crystalReportViewer1.ReportSource = cryrpt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
