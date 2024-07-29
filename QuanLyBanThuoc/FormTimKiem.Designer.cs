namespace QuanLyBanThuoc
{
    partial class FormTimKiem
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
            this.lb_tentimkiem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tk = new System.Windows.Forms.TextBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_tentimkiem
            // 
            this.lb_tentimkiem.AutoSize = true;
            this.lb_tentimkiem.Location = new System.Drawing.Point(42, 22);
            this.lb_tentimkiem.Name = "lb_tentimkiem";
            this.lb_tentimkiem.Size = new System.Drawing.Size(105, 16);
            this.lb_tentimkiem.TabIndex = 0;
            this.lb_tentimkiem.Text = "Tên cột được tìm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lọc theo điều kiện";
            // 
            // tb_tk
            // 
            this.tb_tk.Location = new System.Drawing.Point(203, 63);
            this.tb_tk.Name = "tb_tk";
            this.tb_tk.Size = new System.Drawing.Size(233, 22);
            this.tb_tk.TabIndex = 2;
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(96, 118);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 23);
            this.btn_huy.TabIndex = 3;
            this.btn_huy.Text = "Hủy bỏ";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(340, 118);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(75, 23);
            this.btn_tim.TabIndex = 3;
            this.btn_tim.Text = "Tìm kiếm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // TimKiemCTHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 158);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.tb_tk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_tentimkiem);
            this.Name = "TimKiemCTHDN";
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.TimKiemCTHDN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_tentimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tk;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_tim;
    }
}