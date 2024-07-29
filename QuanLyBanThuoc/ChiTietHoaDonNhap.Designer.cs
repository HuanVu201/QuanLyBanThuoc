namespace QuanLyBanThuoc
{
    partial class ChiTietHoaDonNhap
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
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_SoHD = new System.Windows.Forms.TextBox();
            this.tb_mathuoc = new System.Windows.Forms.TextBox();
            this.tb_ncc = new System.Windows.Forms.TextBox();
            this.tb_sl = new System.Windows.Forms.TextBox();
            this.tb_giamua = new System.Windows.Forms.TextBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dgv_tblCTHDN = new System.Windows.Forms.DataGridView();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_inCTDN = new System.Windows.Forms.Button();
            this.btn_InDSHDNCC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_InAllCTHDN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tblCTHDN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(176, 30);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(158, 22);
            this.tb_ID.TabIndex = 0;
            this.tb_ID.Validating += new System.ComponentModel.CancelEventHandler(this.tb_ID_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số HD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã thuốc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhà cung cấp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Giá mua";
            // 
            // tb_SoHD
            // 
            this.tb_SoHD.Location = new System.Drawing.Point(176, 65);
            this.tb_SoHD.Name = "tb_SoHD";
            this.tb_SoHD.Size = new System.Drawing.Size(158, 22);
            this.tb_SoHD.TabIndex = 0;
            this.tb_SoHD.Validating += new System.ComponentModel.CancelEventHandler(this.tb_SoHD_Validating);
            // 
            // tb_mathuoc
            // 
            this.tb_mathuoc.Location = new System.Drawing.Point(176, 97);
            this.tb_mathuoc.Name = "tb_mathuoc";
            this.tb_mathuoc.Size = new System.Drawing.Size(158, 22);
            this.tb_mathuoc.TabIndex = 0;
            this.tb_mathuoc.Validating += new System.ComponentModel.CancelEventHandler(this.tb_mathuoc_Validating);
            // 
            // tb_ncc
            // 
            this.tb_ncc.Location = new System.Drawing.Point(176, 135);
            this.tb_ncc.Name = "tb_ncc";
            this.tb_ncc.Size = new System.Drawing.Size(158, 22);
            this.tb_ncc.TabIndex = 0;
            this.tb_ncc.Validating += new System.ComponentModel.CancelEventHandler(this.tb_ncc_Validating);
            // 
            // tb_sl
            // 
            this.tb_sl.Location = new System.Drawing.Point(176, 172);
            this.tb_sl.Name = "tb_sl";
            this.tb_sl.Size = new System.Drawing.Size(158, 22);
            this.tb_sl.TabIndex = 0;
            // 
            // tb_giamua
            // 
            this.tb_giamua.Location = new System.Drawing.Point(176, 210);
            this.tb_giamua.Name = "tb_giamua";
            this.tb_giamua.Size = new System.Drawing.Size(158, 22);
            this.tb_giamua.TabIndex = 0;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(110, 262);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 37);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(202, 262);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 37);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(16, 262);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 37);
            this.btn_them.TabIndex = 2;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dgv_tblCTHDN
            // 
            this.dgv_tblCTHDN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tblCTHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tblCTHDN.Location = new System.Drawing.Point(6, 21);
            this.dgv_tblCTHDN.Name = "dgv_tblCTHDN";
            this.dgv_tblCTHDN.ReadOnly = true;
            this.dgv_tblCTHDN.RowHeadersWidth = 51;
            this.dgv_tblCTHDN.RowTemplate.Height = 24;
            this.dgv_tblCTHDN.Size = new System.Drawing.Size(595, 398);
            this.dgv_tblCTHDN.TabIndex = 3;
            this.dgv_tblCTHDN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tblCTHDN_CellContentClick);
            this.dgv_tblCTHDN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_tblCTHDN_MouseDown);
            // 
            // btn_boqua
            // 
            this.btn_boqua.Location = new System.Drawing.Point(305, 262);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(75, 37);
            this.btn_boqua.TabIndex = 4;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // btn_inCTDN
            // 
            this.btn_inCTDN.Location = new System.Drawing.Point(16, 314);
            this.btn_inCTDN.Name = "btn_inCTDN";
            this.btn_inCTDN.Size = new System.Drawing.Size(169, 46);
            this.btn_inCTDN.TabIndex = 5;
            this.btn_inCTDN.Text = "In Chi tiết đơn nhận";
            this.btn_inCTDN.UseVisualStyleBackColor = true;
            this.btn_inCTDN.Click += new System.EventHandler(this.btn_inCTDN_Click);
            // 
            // btn_InDSHDNCC
            // 
            this.btn_InDSHDNCC.Location = new System.Drawing.Point(202, 314);
            this.btn_InDSHDNCC.Name = "btn_InDSHDNCC";
            this.btn_InDSHDNCC.Size = new System.Drawing.Size(178, 46);
            this.btn_InDSHDNCC.TabIndex = 6;
            this.btn_InDSHDNCC.Text = "In DS Chi tiết đơn nhận theo mã nhà cung cấp";
            this.btn_InDSHDNCC.UseVisualStyleBackColor = true;
            this.btn_InDSHDNCC.Click += new System.EventHandler(this.btn_InDSHDNCC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_tblCTHDN);
            this.groupBox1.Location = new System.Drawing.Point(425, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 426);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách chi tiết đơn nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_InAllCTHDN);
            this.groupBox2.Controls.Add(this.btn_InDSHDNCC);
            this.groupBox2.Controls.Add(this.btn_inCTDN);
            this.groupBox2.Controls.Add(this.btn_boqua);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_giamua);
            this.groupBox2.Controls.Add(this.tb_sl);
            this.groupBox2.Controls.Add(this.tb_ncc);
            this.groupBox2.Controls.Add(this.tb_mathuoc);
            this.groupBox2.Controls.Add(this.tb_SoHD);
            this.groupBox2.Controls.Add(this.tb_ID);
            this.groupBox2.Location = new System.Drawing.Point(17, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 419);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết đơn nhập";
            // 
            // btn_InAllCTHDN
            // 
            this.btn_InAllCTHDN.Location = new System.Drawing.Point(16, 368);
            this.btn_InAllCTHDN.Name = "btn_InAllCTHDN";
            this.btn_InAllCTHDN.Size = new System.Drawing.Size(364, 45);
            this.btn_InAllCTHDN.TabIndex = 7;
            this.btn_InAllCTHDN.Text = "In toàn bộ danh sách chi tiết đơn nhận";
            this.btn_InAllCTHDN.UseVisualStyleBackColor = true;
            this.btn_InAllCTHDN.Click += new System.EventHandler(this.btn_InAllCTHDN_Click);
            // 
            // ChiTietHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChiTietHoaDonNhap";
            this.Text = "Chi tiết đơn nhập";
            this.Load += new System.EventHandler(this.ChiTietHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tblCTHDN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_SoHD;
        private System.Windows.Forms.TextBox tb_mathuoc;
        private System.Windows.Forms.TextBox tb_ncc;
        private System.Windows.Forms.TextBox tb_sl;
        private System.Windows.Forms.TextBox tb_giamua;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dgv_tblCTHDN;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_inCTDN;
        private System.Windows.Forms.Button btn_InDSHDNCC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_InAllCTHDN;
    }
}