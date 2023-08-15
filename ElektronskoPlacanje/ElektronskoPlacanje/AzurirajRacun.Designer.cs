namespace ElektronskoPlacanje
{
    partial class AzurirajRacun
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
            this.BtnSpasi = new System.Windows.Forms.Button();
            this.txtZaPlatiti = new System.Windows.Forms.TextBox();
            this.txtIznosPopusta = new System.Windows.Forms.TextBox();
            this.txtUkupanRacun = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbProizvodi = new System.Windows.Forms.ComboBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtKol = new System.Windows.Forms.TextBox();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.txtIzbrisiAzuriranje = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBrRacuna = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSpasi
            // 
            this.BtnSpasi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSpasi.Location = new System.Drawing.Point(699, 418);
            this.BtnSpasi.Name = "BtnSpasi";
            this.BtnSpasi.Size = new System.Drawing.Size(123, 43);
            this.BtnSpasi.TabIndex = 23;
            this.BtnSpasi.Text = "Spasi";
            this.BtnSpasi.UseVisualStyleBackColor = true;
            this.BtnSpasi.Click += new System.EventHandler(this.BtnSpasi_Click);
            // 
            // txtZaPlatiti
            // 
            this.txtZaPlatiti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZaPlatiti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZaPlatiti.Location = new System.Drawing.Point(699, 390);
            this.txtZaPlatiti.Name = "txtZaPlatiti";
            this.txtZaPlatiti.ReadOnly = true;
            this.txtZaPlatiti.Size = new System.Drawing.Size(123, 22);
            this.txtZaPlatiti.TabIndex = 22;
            // 
            // txtIznosPopusta
            // 
            this.txtIznosPopusta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIznosPopusta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIznosPopusta.Location = new System.Drawing.Point(699, 362);
            this.txtIznosPopusta.Name = "txtIznosPopusta";
            this.txtIznosPopusta.Size = new System.Drawing.Size(123, 22);
            this.txtIznosPopusta.TabIndex = 21;
            // 
            // txtUkupanRacun
            // 
            this.txtUkupanRacun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUkupanRacun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUkupanRacun.Location = new System.Drawing.Point(699, 334);
            this.txtUkupanRacun.Name = "txtUkupanRacun";
            this.txtUkupanRacun.ReadOnly = true;
            this.txtUkupanRacun.Size = new System.Drawing.Size(123, 22);
            this.txtUkupanRacun.TabIndex = 20;
            this.txtUkupanRacun.TextChanged += new System.EventHandler(this.txtUkupanRacun_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(587, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ukupno za platiti";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(643, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Popust";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(560, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ukupan iznos računa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(820, 227);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.87989F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.1167F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.39222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.60798F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.083618F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.59234F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.32725F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbProizvodi, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCijena, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtKol, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtIznos, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDodaj, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnIzbrisi, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnOcisti, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtIzbrisiAzuriranje, 7, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(820, 47);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Naziv Proizvoda";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cijena";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kol";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Iznos";
            // 
            // cmbProizvodi
            // 
            this.cmbProizvodi.FormattingEnabled = true;
            this.cmbProizvodi.Location = new System.Drawing.Point(3, 21);
            this.cmbProizvodi.Name = "cmbProizvodi";
            this.cmbProizvodi.Size = new System.Drawing.Size(189, 24);
            this.cmbProizvodi.TabIndex = 5;
            this.cmbProizvodi.SelectedIndexChanged += new System.EventHandler(this.cmbProizvodi_SelectedIndexChanged);
            // 
            // txtCijena
            // 
            this.txtCijena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCijena.Location = new System.Drawing.Point(198, 21);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(96, 22);
            this.txtCijena.TabIndex = 6;
            this.txtCijena.Leave += new System.EventHandler(this.txtCijena_Leave);
            // 
            // txtKol
            // 
            this.txtKol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKol.Location = new System.Drawing.Point(300, 21);
            this.txtKol.Name = "txtKol";
            this.txtKol.Size = new System.Drawing.Size(84, 22);
            this.txtKol.TabIndex = 7;
            this.txtKol.Leave += new System.EventHandler(this.txtKol_Leave);
            // 
            // txtIznos
            // 
            this.txtIznos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIznos.Location = new System.Drawing.Point(390, 21);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.ReadOnly = true;
            this.txtIznos.Size = new System.Drawing.Size(100, 22);
            this.txtIznos.TabIndex = 8;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(496, 21);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(60, 23);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(562, 21);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(56, 23);
            this.btnIzbrisi.TabIndex = 10;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnOcisti
            // 
            this.btnOcisti.Location = new System.Drawing.Point(624, 21);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(75, 23);
            this.btnOcisti.TabIndex = 11;
            this.btnOcisti.Text = "Očisti";
            this.btnOcisti.UseVisualStyleBackColor = true;
            // 
            // txtIzbrisiAzuriranje
            // 
            this.txtIzbrisiAzuriranje.Location = new System.Drawing.Point(728, 21);
            this.txtIzbrisiAzuriranje.Name = "txtIzbrisiAzuriranje";
            this.txtIzbrisiAzuriranje.Size = new System.Drawing.Size(40, 22);
            this.txtIzbrisiAzuriranje.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtBrRacuna);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 36);
            this.panel1.TabIndex = 14;
            // 
            // txtBrRacuna
            // 
            this.txtBrRacuna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrRacuna.Location = new System.Drawing.Point(72, 6);
            this.txtBrRacuna.Name = "txtBrRacuna";
            this.txtBrRacuna.ReadOnly = true;
            this.txtBrRacuna.Size = new System.Drawing.Size(100, 22);
            this.txtBrRacuna.TabIndex = 1;
            this.txtBrRacuna.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(687, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Br računa";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum računa";
            // 
            // AzurirajRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(860, 498);
            this.Controls.Add(this.BtnSpasi);
            this.Controls.Add(this.txtZaPlatiti);
            this.Controls.Add(this.txtIznosPopusta);
            this.Controls.Add(this.txtUkupanRacun);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AzurirajRacun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Azuriraj Racun";
            this.Load += new System.EventHandler(this.AzurirajRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSpasi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbProizvodi;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtKol;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.TextBox txtIzbrisiAzuriranje;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtZaPlatiti;
        public System.Windows.Forms.TextBox txtIznosPopusta;
        public System.Windows.Forms.TextBox txtUkupanRacun;
        public System.Windows.Forms.TextBox txtBrRacuna;
    }
}