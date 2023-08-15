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
    public partial class RačuniIzmeđuDvaBr : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.ElektronskoPlacanjeConnectionString);
        ReportDocument cryrpt = new ReportDocument();
        SqlDataAdapter da;

        public RačuniIzmeđuDvaBr()
        {
            InitializeComponent();
        }

        private void btnPronadjiRacune_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select TblPodaciZaglavlja.BrRačuna, TblPodaciZaglavlja.DatumRačuna, " + 
                    " TblPodaciZaglavlja.IznosRačuna, TblPodaciZaglavlja.IznosPop, TblPodaciZaglavlja.UkupnoZaPlatiti, " + 
                    " TblPodaciReda.SrBr, TblPodaciReda.NazivProizvoda, TblPodaciReda.Cijena, TblPodaciReda.Kol, " + 
                    " TblPodaciReda.Iznos, TblPodaciReda.BrRačuna from TblPodaciZaglavlja inner join TblPodaciReda on " + 
                    " TblPodaciZaglavlja.BrRačuna =TblPodaciReda.BrRačuna where " +
                    " TblPodaciZaglavlja.BrRačuna between '"+textBox1.Text+"' and '"+textBox2.Text+"'", con);
                DataSet dst = new DataSet();
                da.Fill(dst, "ŠtampajRačun");
                cryrpt.Load("RačuniIzmeđuDvaBroja.rpt");
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
