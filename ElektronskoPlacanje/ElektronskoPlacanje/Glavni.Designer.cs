namespace ElektronskoPlacanje
{
    partial class Glavni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naplataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviRačunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiRačuneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.štampajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.štampajRačunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.štampajIzvještajProdajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.računiIzmeđuDvaBrojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.naplataToolStripMenuItem,
            this.prikažiToolStripMenuItem,
            this.štampajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proizvodiToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(67, 25);
            this.dataToolStripMenuItem.Text = "Podaci";
            // 
            // proizvodiToolStripMenuItem
            // 
            this.proizvodiToolStripMenuItem.Name = "proizvodiToolStripMenuItem";
            this.proizvodiToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.proizvodiToolStripMenuItem.Text = "Proizvodi";
            this.proizvodiToolStripMenuItem.Click += new System.EventHandler(this.proizvodiToolStripMenuItem_Click);
            // 
            // naplataToolStripMenuItem
            // 
            this.naplataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviRačunToolStripMenuItem});
            this.naplataToolStripMenuItem.Name = "naplataToolStripMenuItem";
            this.naplataToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.naplataToolStripMenuItem.Text = "Naplata";
            // 
            // noviRačunToolStripMenuItem
            // 
            this.noviRačunToolStripMenuItem.Name = "noviRačunToolStripMenuItem";
            this.noviRačunToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.noviRačunToolStripMenuItem.Text = "Novi račun";
            this.noviRačunToolStripMenuItem.Click += new System.EventHandler(this.noviRačunToolStripMenuItem_Click);
            // 
            // prikažiToolStripMenuItem
            // 
            this.prikažiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikažiRačuneToolStripMenuItem});
            this.prikažiToolStripMenuItem.Name = "prikažiToolStripMenuItem";
            this.prikažiToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.prikažiToolStripMenuItem.Text = "Prikaži";
            // 
            // prikažiRačuneToolStripMenuItem
            // 
            this.prikažiRačuneToolStripMenuItem.Name = "prikažiRačuneToolStripMenuItem";
            this.prikažiRačuneToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.prikažiRačuneToolStripMenuItem.Text = "Prikaži račune";
            this.prikažiRačuneToolStripMenuItem.Click += new System.EventHandler(this.prikažiRačuneToolStripMenuItem_Click);
            // 
            // štampajToolStripMenuItem
            // 
            this.štampajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.štampajRačunToolStripMenuItem,
            this.štampajIzvještajProdajeToolStripMenuItem,
            this.računiIzmeđuDvaBrojaToolStripMenuItem});
            this.štampajToolStripMenuItem.Name = "štampajToolStripMenuItem";
            this.štampajToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.štampajToolStripMenuItem.Text = "Štampaj";
            // 
            // štampajRačunToolStripMenuItem
            // 
            this.štampajRačunToolStripMenuItem.Name = "štampajRačunToolStripMenuItem";
            this.štampajRačunToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.štampajRačunToolStripMenuItem.Text = "Štampaj račun";
            this.štampajRačunToolStripMenuItem.Click += new System.EventHandler(this.štampajRačunToolStripMenuItem_Click);
            // 
            // štampajIzvještajProdajeToolStripMenuItem
            // 
            this.štampajIzvještajProdajeToolStripMenuItem.Name = "štampajIzvještajProdajeToolStripMenuItem";
            this.štampajIzvještajProdajeToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.štampajIzvještajProdajeToolStripMenuItem.Text = "Štampaj izvještaj prodaje";
            this.štampajIzvještajProdajeToolStripMenuItem.Click += new System.EventHandler(this.štampajIzvještajProdajeToolStripMenuItem_Click);
            // 
            // računiIzmeđuDvaBrojaToolStripMenuItem
            // 
            this.računiIzmeđuDvaBrojaToolStripMenuItem.Name = "računiIzmeđuDvaBrojaToolStripMenuItem";
            this.računiIzmeđuDvaBrojaToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.računiIzmeđuDvaBrojaToolStripMenuItem.Text = "Računi između dva broja";
            this.računiIzmeđuDvaBrojaToolStripMenuItem.Click += new System.EventHandler(this.računiIzmeđuDvaBrojaToolStripMenuItem_Click);
            // 
            // Glavni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavni";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Glavni_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naplataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviRačunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiRačuneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem štampajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem štampajRačunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem štampajIzvještajProdajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem računiIzmeđuDvaBrojaToolStripMenuItem;
    }
}

