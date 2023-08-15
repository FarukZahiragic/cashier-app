using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElektronskoPlacanje
{
    public partial class Glavni : Form
    {
        public Glavni()
        {
            InitializeComponent();
        }

        private void proizvodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Da se otvori child forma u mdi(main) formi
            Proizvodi p = new Proizvodi();
            p.MdiParent = this;
            p.Show();
        }

        private void noviRačunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoviRacun nr = new NoviRacun();
            nr.MdiParent = this;
            nr.Show();
        }

        private void prikažiRačuneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikažiRačune pr = new PrikažiRačune();
            pr.MdiParent = this;
            pr.Show();
        }

        private void štampajRačunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StampajRacun sr = new StampajRacun();
            sr.MdiParent = this;
            sr.Show();
        }

        private void štampajIzvještajProdajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IzvjestajProdaje ip = new IzvjestajProdaje();
            ip.MdiParent = this;
            ip.Show();
        }

        private void računiIzmeđuDvaBrojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RačuniIzmeđuDvaBr ridb = new RačuniIzmeđuDvaBr();
            ridb.MdiParent = this;
            ridb.Show();
        }

        private void Glavni_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;

            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = System.Drawing.Color.LightSkyBlue;
                    //ctlMDI.BackgroundImage = Properties.Resources.Prodavnica.jpg;//Image name from resource. 
                    menuStrip1.Enabled = true;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }
        }
    }
}
