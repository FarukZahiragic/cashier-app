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
    public partial class IzvjestajProdaje : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.ElektronskoPlacanjeConnectionString);
        ReportDocument cryrpt = new ReportDocument();
        SqlDataAdapter da;

        public IzvjestajProdaje()
        {
            InitializeComponent();
        }

        private void IzvjestajProdaje_Load(object sender, EventArgs e)
        {
            con.Open();
            da = new SqlDataAdapter("select * from TblPodaciZaglavlja where DatumRačuna between '" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "' and '" + dateTimePicker2.Value.ToString("MM/dd/yyyy") + "'", con);
            DataSet dst = new DataSet();
            da.Fill(dst, "ŠtampajIzvještajProdaje");
            cryrpt.Load("IzvjestajiProdaje.rpt");
            cryrpt.SetDataSource(dst);
            crystalReportViewer1.ReportSource = cryrpt;
            con.Close();
        }
    }
}
