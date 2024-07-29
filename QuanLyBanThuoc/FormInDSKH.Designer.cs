namespace QuanLyBanThuoc
{
    partial class FormInDSKH
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
            this.crystalReportViewerKH = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerKH
            // 
            this.crystalReportViewerKH.ActiveViewIndex = -1;
            this.crystalReportViewerKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerKH.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerKH.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerKH.Name = "crystalReportViewerKH";
            this.crystalReportViewerKH.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerKH.TabIndex = 0;
            // 
            // FormInDSKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerKH);
            this.Name = "FormInDSKH";
            this.Text = "FormInDSKH";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerKH;
    }
}