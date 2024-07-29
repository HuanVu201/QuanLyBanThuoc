namespace QuanLyBanThuoc
{
    partial class InCTHDN
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
            this.crv_CTHDN = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_CTHDN
            // 
            this.crv_CTHDN.ActiveViewIndex = -1;
            this.crv_CTHDN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_CTHDN.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_CTHDN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_CTHDN.Location = new System.Drawing.Point(0, 0);
            this.crv_CTHDN.Name = "crv_CTHDN";
            this.crv_CTHDN.Size = new System.Drawing.Size(800, 450);
            this.crv_CTHDN.TabIndex = 0;
            this.crv_CTHDN.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // InCTHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crv_CTHDN);
            this.Name = "InCTHDN";
            this.Text = "InCTHDN";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_CTHDN;
    }
}