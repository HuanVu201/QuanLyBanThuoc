namespace BTH3
{
    partial class QuanLyNV
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_manv = new System.Windows.Forms.TextBox();
            this.tb_hoten = new System.Windows.Forms.TextBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.dt_ngsinh = new System.Windows.Forms.DateTimePicker();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_tblNV = new System.Windows.Forms.DataGridView();
            this.sDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanlyThuocDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_lsdn = new System.Windows.Forms.Button();
            this.btn_lsdx = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tblNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyThuocDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Giới tính";
            // 
            // tb_manv
            // 
            this.tb_manv.Location = new System.Drawing.Point(227, 90);
            this.tb_manv.Name = "tb_manv";
            this.tb_manv.Size = new System.Drawing.Size(294, 22);
            this.tb_manv.TabIndex = 3;
            this.tb_manv.TextChanged += new System.EventHandler(this.tb_manv_TextChanged);
            this.tb_manv.Validating += new System.ComponentModel.CancelEventHandler(this.tb_manv_Validating);
            this.tb_manv.Validated += new System.EventHandler(this.tb_manv_Validated);
            // 
            // tb_hoten
            // 
            this.tb_hoten.Location = new System.Drawing.Point(227, 121);
            this.tb_hoten.Name = "tb_hoten";
            this.tb_hoten.Size = new System.Drawing.Size(294, 22);
            this.tb_hoten.TabIndex = 3;
            this.tb_hoten.TextChanged += new System.EventHandler(this.tb_hoten_TextChanged);
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(227, 153);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(294, 22);
            this.tb_sdt.TabIndex = 3;
            this.tb_sdt.TextChanged += new System.EventHandler(this.tb_sdt_TextChanged);
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(227, 188);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(294, 22);
            this.tb_diachi.TabIndex = 3;
            // 
            // dt_ngsinh
            // 
            this.dt_ngsinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngsinh.Location = new System.Drawing.Point(227, 230);
            this.dt_ngsinh.Name = "dt_ngsinh";
            this.dt_ngsinh.Size = new System.Drawing.Size(294, 22);
            this.dt_ngsinh.TabIndex = 4;
            this.dt_ngsinh.Value = new System.DateTime(2024, 6, 27, 4, 51, 5, 0);
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Location = new System.Drawing.Point(269, 270);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(57, 20);
            this.rb_nam.TabIndex = 5;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(429, 270);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(45, 20);
            this.rb_nu.TabIndex = 6;
            this.rb_nu.TabStop = true;
            this.rb_nu.Text = "Nữ";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Danh sách nhân viên";
            // 
            // dgv_tblNV
            // 
            this.dgv_tblNV.AllowUserToAddRows = false;
            this.dgv_tblNV.AllowUserToDeleteRows = false;
            this.dgv_tblNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tblNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tblNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sDiaChi,
            this.sDienThoai});
            this.dgv_tblNV.Location = new System.Drawing.Point(15, 396);
            this.dgv_tblNV.Name = "dgv_tblNV";
            this.dgv_tblNV.ReadOnly = true;
            this.dgv_tblNV.RowHeadersWidth = 51;
            this.dgv_tblNV.RowTemplate.Height = 24;
            this.dgv_tblNV.Size = new System.Drawing.Size(874, 161);
            this.dgv_tblNV.TabIndex = 8;
            this.dgv_tblNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tblNV_CellContentClick);
            this.dgv_tblNV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tblNV_CellContentDoubleClick);
            // 
            // sDiaChi
            // 
            this.sDiaChi.DataPropertyName = "sDiaChi";
            this.sDiaChi.HeaderText = "sDiaChi";
            this.sDiaChi.MinimumWidth = 6;
            this.sDiaChi.Name = "sDiaChi";
            this.sDiaChi.ReadOnly = true;
            // 
            // sDienThoai
            // 
            this.sDienThoai.DataPropertyName = "sDienThoai";
            this.sDienThoai.HeaderText = "sDienThoai";
            this.sDienThoai.MinimumWidth = 6;
            this.sDienThoai.Name = "sDienThoai";
            this.sDienThoai.ReadOnly = true;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_them.Location = new System.Drawing.Point(648, 65);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(90, 50);
            this.btn_them.TabIndex = 9;
            this.btn_them.Text = "Thêm mới";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_boqua
            // 
            this.btn_boqua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_boqua.ForeColor = System.Drawing.Color.Black;
            this.btn_boqua.Location = new System.Drawing.Point(648, 121);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(90, 50);
            this.btn_boqua.TabIndex = 9;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = false;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Location = new System.Drawing.Point(648, 177);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(90, 50);
            this.btn_sua.TabIndex = 9;
            this.btn_sua.Text = "Chỉnh sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Location = new System.Drawing.Point(648, 233);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(90, 50);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa bỏ";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_tim.ForeColor = System.Drawing.Color.Black;
            this.btn_tim.Location = new System.Drawing.Point(648, 289);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(90, 50);
            this.btn_tim.TabIndex = 9;
            this.btn_tim.Text = "Tìm kiếm";
            this.btn_tim.UseVisualStyleBackColor = false;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_lsdn
            // 
            this.btn_lsdn.Location = new System.Drawing.Point(767, 79);
            this.btn_lsdn.Name = "btn_lsdn";
            this.btn_lsdn.Size = new System.Drawing.Size(122, 50);
            this.btn_lsdn.TabIndex = 10;
            this.btn_lsdn.Text = "Xem lịch sử đơn nhập";
            this.btn_lsdn.UseVisualStyleBackColor = true;
            this.btn_lsdn.Click += new System.EventHandler(this.btn_lsdn_Click);
            // 
            // btn_lsdx
            // 
            this.btn_lsdx.Location = new System.Drawing.Point(767, 135);
            this.btn_lsdx.Name = "btn_lsdx";
            this.btn_lsdx.Size = new System.Drawing.Size(122, 50);
            this.btn_lsdx.TabIndex = 10;
            this.btn_lsdx.Text = "Xem lịch sử đơn xuất";
            this.btn_lsdx.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_tim);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_boqua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rb_nu);
            this.groupBox1.Controls.Add(this.rb_nam);
            this.groupBox1.Controls.Add(this.dt_ngsinh);
            this.groupBox1.Controls.Add(this.tb_diachi);
            this.groupBox1.Controls.Add(this.tb_sdt);
            this.groupBox1.Controls.Add(this.tb_hoten);
            this.groupBox1.Controls.Add(this.tb_manv);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 365);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // QuanLyNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 604);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_lsdx);
            this.Controls.Add(this.btn_lsdn);
            this.Controls.Add(this.dgv_tblNV);
            this.Name = "QuanLyNV";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tblNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyThuocDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_manv;
        private System.Windows.Forms.TextBox tb_hoten;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.RadioButton rb_nam;
        private System.Windows.Forms.RadioButton rb_nu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_tblNV;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.BindingSource quanlyThuocDataSetBindingSource;
        //private QuanlyThuocDataSet quanlyThuocDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bGioiTinhDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDienThoai;
        private System.Windows.Forms.DateTimePicker dt_ngsinh;
        private System.Windows.Forms.Button btn_lsdn;
        private System.Windows.Forms.Button btn_lsdx;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

