namespace ElektronskoPlacanje
{
    partial class StampajRacun
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrRacuna = new System.Windows.Forms.TextBox();
            this.btnPronađi = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Br računa";
            // 
            // txtBrRacuna
            // 
            this.txtBrRacuna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrRacuna.Location = new System.Drawing.Point(85, 10);
            this.txtBrRacuna.Name = "txtBrRacuna";
            this.txtBrRacuna.Size = new System.Drawing.Size(100, 20);
            this.txtBrRacuna.TabIndex = 1;
            // 
            // btnPronađi
            // 
            this.btnPronađi.Location = new System.Drawing.Point(192, 9);
            this.btnPronađi.Name = "btnPronađi";
            this.btnPronađi.Size = new System.Drawing.Size(75, 23);
            this.btnPronađi.TabIndex = 2;
            this.btnPronađi.Text = "Pronađi";
            this.btnPronađi.UseVisualStyleBackColor = true;
            this.btnPronađi.Click += new System.EventHandler(this.btnPronađi_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(16, 38);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(847, 445);
            this.crystalReportViewer1.TabIndex = 3;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // StampajRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(875, 495);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnPronađi);
            this.Controls.Add(this.txtBrRacuna);
            this.Controls.Add(this.label1);
            this.Name = "StampajRacun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stampaj Racun";
            this.Load += new System.EventHandler(this.StampajRacun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrRacuna;
        private System.Windows.Forms.Button btnPronađi;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}