namespace QuanLyBanThuoc
{
    partial class QuanLyThuoc
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
            this.tb_mathuoc = new System.Windows.Forms.TextBox();
            this.tb_maloaithuoc = new System.Windows.Forms.TextBox();
            this.tb_tenthuoc = new System.Windows.Forms.TextBox();
            this.tb_ncc = new System.Windows.Forms.TextBox();
            this.tb_noisx = new System.Windows.Forms.TextBox();
            this.tb_sl = new System.Windows.Forms.TextBox();
            this.tb_dvbl = new System.Windows.Forms.TextBox();
            this.tb_dvb = new System.Windows.Forms.TextBox();
            this.tb_gb = new System.Windows.Forms.TextBox();
            this.tb_gbl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.dgv_tblThuoc = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_dsthuoc = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.mtx_hsd = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tblThuoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_mathuoc
            // 
            this.tb_mathuoc.Location = new System.Drawing.Point(151, 30);
            this.tb_mathuoc.Name = "tb_mathuoc";
            this.tb_mathuoc.Size = new System.Drawing.Size(201, 22);
            this.tb_mathuoc.TabIndex = 0;
            this.tb_mathuoc.TextChanged += new System.EventHandler(this.tb_mathuoc_TextChanged);
            this.tb_mathuoc.Validating += new System.ComponentModel.CancelEventHandler(this.tb_mathuoc_Validating);
            // 
            // tb_maloaithuoc
            // 
            this.tb_maloaithuoc.Location = new System.Drawing.Point(151, 75);
            this.tb_maloaithuoc.Name = "tb_maloaithuoc";
            this.tb_maloaithuoc.Size = new System.Drawing.Size(201, 22);
            this.tb_maloaithuoc.TabIndex = 0;
            this.tb_maloaithuoc.Validating += new System.ComponentModel.CancelEventHandler(this.tb_maloaithuoc_Validating);
            // 
            // tb_tenthuoc
            // 
            this.tb_tenthuoc.Location = new System.Drawing.Point(151, 119);
            this.tb_tenthuoc.Name = "tb_tenthuoc";
            this.tb_tenthuoc.Size = new System.Drawing.Size(201, 22);
            this.tb_tenthuoc.TabIndex = 0;
            // 
            // tb_ncc
            // 
            this.tb_ncc.Location = new System.Drawing.Point(151, 169);
            this.tb_ncc.Name = "tb_ncc";
            this.tb_ncc.Size = new System.Drawing.Size(201, 22);
            this.tb_ncc.TabIndex = 0;
            this.tb_ncc.Validating += new System.ComponentModel.CancelEventHandler(this.tb_ncc_Validating);
            // 
            // tb_noisx
            // 
            this.tb_noisx.Location = new System.Drawing.Point(151, 218);
            this.tb_noisx.Name = "tb_noisx";
            this.tb_noisx.Size = new System.Drawing.Size(201, 22);
            this.tb_noisx.TabIndex = 0;
            // 
            // tb_sl
            // 
            this.tb_sl.Location = new System.Drawing.Point(151, 266);
            this.tb_sl.Name = "tb_sl";
            this.tb_sl.Size = new System.Drawing.Size(201, 22);
            this.tb_sl.TabIndex = 0;
            // 
            // tb_dvbl
            // 
            this.tb_dvbl.Location = new System.Drawing.Point(466, 33);
            this.tb_dvbl.Name = "tb_dvbl";
            this.tb_dvbl.Size = new System.Drawing.Size(189, 22);
            this.tb_dvbl.TabIndex = 0;
            // 
            // tb_dvb
            // 
            this.tb_dvb.Location = new System.Drawing.Point(151, 359);
            this.tb_dvb.Name = "tb_dvb";
            this.tb_dvb.Size = new System.Drawing.Size(201, 22);
            this.tb_dvb.TabIndex = 0;
            // 
            // tb_gb
            // 
            this.tb_gb.Location = new System.Drawing.Point(151, 408);
            this.tb_gb.Name = "tb_gb";
            this.tb_gb.Size = new System.Drawing.Size(201, 22);
            this.tb_gb.TabIndex = 0;
            // 
            // tb_gbl
            // 
            this.tb_gbl.Location = new System.Drawing.Point(454, 75);
            this.tb_gbl.Name = "tb_gbl";
            this.tb_gbl.Size = new System.Drawing.Size(201, 22);
            this.tb_gbl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã thuốc";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã loại thuốc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên thuốc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã nhà cung cấp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nơi sản xuất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Hạn sử dụng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Giá bán";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(377, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Giá bán lẻ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Đơn vị bán";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(377, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Đơn vị bán lẻ";
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_them.Location = new System.Drawing.Point(380, 146);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 45);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sua.Location = new System.Drawing.Point(478, 146);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 45);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_xoa.Location = new System.Drawing.Point(580, 146);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 45);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // dgv_tblThuoc
            // 
            this.dgv_tblThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tblThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tblThuoc.Location = new System.Drawing.Point(6, 23);
            this.dgv_tblThuoc.Name = "dgv_tblThuoc";
            this.dgv_tblThuoc.ReadOnly = true;
            this.dgv_tblThuoc.RowHeadersWidth = 51;
            this.dgv_tblThuoc.RowTemplate.Height = 24;
            this.dgv_tblThuoc.Size = new System.Drawing.Size(826, 421);
            this.dgv_tblThuoc.TabIndex = 5;
            this.dgv_tblThuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tblThuoc_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_dsthuoc);
            this.groupBox1.Controls.Add(this.btn_boqua);
            this.groupBox1.Controls.Add(this.mtx_hsd);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_gbl);
            this.groupBox1.Controls.Add(this.tb_dvb);
            this.groupBox1.Controls.Add(this.tb_dvbl);
            this.groupBox1.Controls.Add(this.tb_sl);
            this.groupBox1.Controls.Add(this.tb_noisx);
            this.groupBox1.Controls.Add(this.tb_ncc);
            this.groupBox1.Controls.Add(this.tb_tenthuoc);
            this.groupBox1.Controls.Add(this.tb_gb);
            this.groupBox1.Controls.Add(this.tb_maloaithuoc);
            this.groupBox1.Controls.Add(this.tb_mathuoc);
            this.groupBox1.Location = new System.Drawing.Point(11, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 451);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thuốc";
            // 
            // btn_dsthuoc
            // 
            this.btn_dsthuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_dsthuoc.Location = new System.Drawing.Point(478, 207);
            this.btn_dsthuoc.Name = "btn_dsthuoc";
            this.btn_dsthuoc.Size = new System.Drawing.Size(75, 45);
            this.btn_dsthuoc.TabIndex = 7;
            this.btn_dsthuoc.Text = "In DS Thuốc";
            this.btn_dsthuoc.UseVisualStyleBackColor = false;
            this.btn_dsthuoc.Click += new System.EventHandler(this.btn_dsthuoc_Click);
            // 
            // btn_boqua
            // 
            this.btn_boqua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_boqua.Location = new System.Drawing.Point(380, 207);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(75, 45);
            this.btn_boqua.TabIndex = 6;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = false;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // mtx_hsd
            // 
            this.mtx_hsd.Location = new System.Drawing.Point(151, 312);
            this.mtx_hsd.Mask = "00/00/0000";
            this.mtx_hsd.Name = "mtx_hsd";
            this.mtx_hsd.Size = new System.Drawing.Size(201, 22);
            this.mtx_hsd.TabIndex = 5;
            this.mtx_hsd.ValidatingType = typeof(System.DateTime);
            this.mtx_hsd.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.mtx_hsd_TypeValidationCompleted);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_tblThuoc);
            this.groupBox2.Location = new System.Drawing.Point(697, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(840, 450);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thuốc";
            // 
            // QuanLyThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 473);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanLyThuoc";
            this.Text = "QuanLyThuoc";
            this.Load += new System.EventHandler(this.QuanLyThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tblThuoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_mathuoc;
        private System.Windows.Forms.TextBox tb_maloaithuoc;
        private System.Windows.Forms.TextBox tb_tenthuoc;
        private System.Windows.Forms.TextBox tb_ncc;
        private System.Windows.Forms.TextBox tb_noisx;
        private System.Windows.Forms.TextBox tb_sl;
        private System.Windows.Forms.TextBox tb_dvbl;
        private System.Windows.Forms.TextBox tb_dvb;
        private System.Windows.Forms.TextBox tb_gb;
        private System.Windows.Forms.TextBox tb_gbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.DataGridView dgv_tblThuoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mtx_hsd;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_dsthuoc;
    }
}