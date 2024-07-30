namespace QuanLyBanThuoc
{
    partial class FormInHoaDon
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
            this.crystalReportViewerHoaDonXuat = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerHoaDonXuat
            // 
            this.crystalReportViewerHoaDonXuat.ActiveViewIndex = -1;
            this.crystalReportViewerHoaDonXuat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerHoaDonXuat.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerHoaDonXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerHoaDonXuat.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerHoaDonXuat.Name = "crystalReportViewerHoaDonXuat";
            this.crystalReportViewerHoaDonXuat.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerHoaDonXuat.TabIndex = 0;
            // 
            // FormInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerHoaDonXuat);
            this.Name = "FormInHoaDon";
            this.Text = "FormInHoaDon";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerHoaDonXuat;
    }
}