namespace QuanLyBanThuoc
{
    partial class HoaDonNhap
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
            this.tb_SoHD = new System.Windows.Forms.TextBox();
            this.tb_MaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtb_ngaylap = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_tblHDN = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.tb_tonggiamua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_indsdn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tblHDN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_SoHD
            // 
            this.tb_SoHD.Location = new System.Drawing.Point(157, 32);
            this.tb_SoHD.Name = "tb_SoHD";
            this.tb_SoHD.Size = new System.Drawing.Size(182, 22);
            this.tb_SoHD.TabIndex = 0;
            // 
            // tb_MaNV
            // 
            this.tb_MaNV.Location = new System.Drawing.Point(157, 82);
            this.tb_MaNV.Name = "tb_MaNV";
            this.tb_MaNV.Size = new System.Drawing.Size(182, 22);
            this.tb_MaNV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 1;
            // 
            // mtb_ngaylap
            // 
            this.mtb_ngaylap.Location = new System.Drawing.Point(157, 130);
            this.mtb_ngaylap.Mask = "00/00/0000";
            this.mtb_ngaylap.Name = "mtb_ngaylap";
            this.mtb_ngaylap.Size = new System.Drawing.Size(182, 22);
            this.mtb_ngaylap.TabIndex = 2;
            this.mtb_ngaylap.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày lập";
            // 
            // dgv_tblHDN
            // 
            this.dgv_tblHDN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tblHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tblHDN.Location = new System.Drawing.Point(6, 21);
            this.dgv_tblHDN.Name = "dgv_tblHDN";
            this.dgv_tblHDN.ReadOnly = true;
            this.dgv_tblHDN.RowHeadersWidth = 51;
            this.dgv_tblHDN.RowTemplate.Height = 24;
            this.dgv_tblHDN.Size = new System.Drawing.Size(761, 204);
            this.dgv_tblHDN.TabIndex = 4;
            this.dgv_tblHDN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tblHDN_CellContentClick);
            this.dgv_tblHDN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_tblHDN_MouseDown);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(420, 32);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 48);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(535, 32);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 48);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(643, 32);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 48);
            this.btn_sua.TabIndex = 5;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // tb_tonggiamua
            // 
            this.tb_tonggiamua.Location = new System.Drawing.Point(157, 183);
            this.tb_tonggiamua.Name = "tb_tonggiamua";
            this.tb_tonggiamua.ReadOnly = true;
            this.tb_tonggiamua.Size = new System.Drawing.Size(182, 22);
            this.tb_tonggiamua.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tổng giá mua";
            // 
            // btn_boqua
            // 
            this.btn_boqua.Location = new System.Drawing.Point(420, 103);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(75, 46);
            this.btn_boqua.TabIndex = 8;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_indsdn);
            this.groupBox1.Controls.Add(this.btn_boqua);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_tonggiamua);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mtb_ngaylap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_MaNV);
            this.groupBox1.Controls.Add(this.tb_SoHD);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 238);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập hóa đơn";
            // 
            // btn_indsdn
            // 
            this.btn_indsdn.Location = new System.Drawing.Point(538, 105);
            this.btn_indsdn.Name = "btn_indsdn";
            this.btn_indsdn.Size = new System.Drawing.Size(180, 43);
            this.btn_indsdn.TabIndex = 9;
            this.btn_indsdn.Text = "In DS đơn nhập";
            this.btn_indsdn.UseVisualStyleBackColor = true;
            this.btn_indsdn.Click += new System.EventHandler(this.btn_indsdn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_tblHDN);
            this.groupBox2.Location = new System.Drawing.Point(14, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 231);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn nhập về";
            // 
            // HoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HoaDonNhap";
            this.Text = "Hóa đơn nhập";
            this.Load += new System.EventHandler(this.HoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tblHDN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_SoHD;
        private System.Windows.Forms.TextBox tb_MaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtb_ngaylap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_tblHDN;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.TextBox tb_tonggiamua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_indsdn;
    }
}