using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyBanThuoc
{
    public partial class ChiTietHoaDonNhap : Form, TimKiem
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QuanlyThuoc"].ConnectionString;
        ErrorProvider errorProvider = new ErrorProvider();
        DataView dv = new DataView();
        private string reportFilter;
        public ChiTietHoaDonNhap()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string querySelect = "Select_CTHDN"; //stored

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = querySelect;
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                adapter.Fill(dt);
                                if (dt.Rows.Count > 0)
                                {
                                    dv = dt.DefaultView;
                                    dgv_tblCTHDN.AutoGenerateColumns = true;
                                    dgv_tblCTHDN.DataSource = dv;
                                }
                                else
                                {
                                    MessageBox.Show("Khong ton tai ban ghi nao");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Da xay ra loi" + ex);
            }
        }
        private void ChiTietHoaDonNhap_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private DataTable GetData()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo SqlCommand để thực hiện truy vấn
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblChiTietDonNhap", conn))
                    {
                        // Tạo SqlDataAdapter để nạp dữ liệu vào DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            // Điền dữ liệu vào DataTable
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi lấy dữ liệu: " + ex.Message);
            }

            return dataTable;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (!string.IsNullOrWhiteSpace(tb_ID.Text))
            //    {
            //        using (SqlConnection conn = new SqlConnection(connectionString))
            //        {
            //            SqlDataAdapter adapter = new SqlDataAdapter();
            //            adapter.SelectCommand = new SqlCommand("SELECT * FROM tblChiTietHoaDonNhap", conn);
            //            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            //            DataTable tblCTHDN = new DataTable();
            //            adapter.Fill(tblCTHDN);

            //             Assuming input validation before inserting
            //            if (string.IsNullOrWhiteSpace(tb_SoHD.Text) ||
            //        string.IsNullOrWhiteSpace(tb_mathuoc.Text) ||
            //        string.IsNullOrWhiteSpace(tb_ncc.Text) ||
            //        !double.TryParse(tb_sl.Text, out double soluong) ||
            //        !double.TryParse(tb_giamua.Text, out double giamua))
            //            {
            //                MessageBox.Show("Vui lòng kiểm tra dữ liệu đầu vào.");
            //                return;
            //            }
            //            DataRow newRow = tblCTHDN.NewRow();
            //            newRow["sID"] = tb_ID.Text;
            //            newRow["sSoHD"] = tb_SoHD.Text;
            //            newRow["sMaThuoc"] = tb_mathuoc.Text;
            //            newRow["sMaNCC"] = tb_ncc.Text;
            //            newRow["fSoluong"] = soluong;
            //            newRow["fGiaMua"] = giamua;

            //            tblCTHDN.Rows.Add(newRow);

            //            adapter.InsertCommand = new SqlCommand("Insert_ChiTietDonNhap", conn);
            //            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
            //            adapter.InsertCommand.Parameters.Add(new SqlParameter("@sID", SqlDbType.VarChar, 20, "sID"));
            //            adapter.InsertCommand.Parameters.Add(new SqlParameter("@sSoHD", SqlDbType.VarChar, 15, "sSoHD"));
            //            adapter.InsertCommand.Parameters.Add(new SqlParameter("@sMaThuoc", SqlDbType.NVarChar, 10, "sMaThuoc"));
            //            adapter.InsertCommand.Parameters.Add(new SqlParameter("@sMaNCC", SqlDbType.NVarChar, 10, "sMaNCC"));
            //            adapter.InsertCommand.Parameters.Add(new SqlParameter("@fSoluong", SqlDbType.Float, 50, "fSoluong"));
            //            adapter.InsertCommand.Parameters.Add(new SqlParameter("@fGiaMua", SqlDbType.Float, 50, "fGiaMua"));

            //            int rowsAffected = adapter.Update(tblCTHDN);

            //            if (rowsAffected > 0)
            //            {
            //                dgv_tblCTHDN.DataSource = tblCTHDN.DefaultView;
            //                btn_boqua_Click(sender, e);
            //                MessageBox.Show("Thêm chi tiết hóa đơn nhập thành công.");
            //            }
            //            else
            //            {
            //                MessageBox.Show("Thêm chi tiết hóa đơn nhập thất bại.");
            //            }
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("ID phải không trống.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    string strError = ex.Message;
            //    if (strError.Contains("'PK__tblNhanV__328E1C0F6A2FE2B4'"))
            //    {
            //        MessageBox.Show("Mã nhân viên " + tb_manv.Text + " này đã tồn tại");
            //    }
            //    else if (strError.Contains("'Index 12 is either negative or above rows count.'"))
            //    {
            //        MessageBox.Show("Mã nhân viên phải lớn hơn 0");
            //    }
            //}
            if (!string.IsNullOrWhiteSpace(tb_ID.Text) &&
        !string.IsNullOrWhiteSpace(tb_SoHD.Text) &&
        !string.IsNullOrWhiteSpace(tb_mathuoc.Text) &&
        !string.IsNullOrWhiteSpace(tb_ncc.Text) &&
        double.TryParse(tb_sl.Text, out double quantity) &&
        double.TryParse(tb_giamua.Text, out double price))
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open(); // Mở kết nối

                        // Tạo lệnh chèn dữ liệu
                        using (SqlCommand cmd = new SqlCommand("Insert_ChiTietDonNhap", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Thêm các tham số vào SqlCommand
                            cmd.Parameters.AddWithValue("@sID", tb_ID.Text);
                            cmd.Parameters.AddWithValue("@sSoHD", tb_SoHD.Text);
                            cmd.Parameters.AddWithValue("@sMaThuoc", tb_mathuoc.Text);
                            cmd.Parameters.AddWithValue("@sMaNCC", tb_ncc.Text);
                            cmd.Parameters.AddWithValue("@fSoluong", quantity);
                            cmd.Parameters.AddWithValue("@fGiaMua", price);

                            // Thực hiện lệnh
                            cmd.ExecuteNonQuery();
                        }

                        // Cập nhật DataGridView với dữ liệu mới
                        dgv_tblCTHDN.DataSource = GetData();

                        MessageBox.Show("Thêm chi tiết hóa đơn nhập thành công.");
                    }
                }
                catch (Exception ex)
                {
                    string strError = ex.Message;
                    if (strError.Contains("PK__tblChhiT__DDDED94"))
                    {
                        MessageBox.Show("ID " + tb_ID.Text + " đã tồn tại");
                    }
                    else if (strError.Contains("FK_tblChiTietHoaDonNhap_sMaThuoc"))
                    {
                        MessageBox.Show("Mã thuốc " + tb_mathuoc.Text + " không tồn tại");
                    }
                    else if (strError.Contains("FK_tblChiTietHoaDonNhap_sSoHD"))
                    {
                        MessageBox.Show("Số hóa đơn " + tb_SoHD.Text + " không tồn tại");
                    }    
                    else   MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra dữ liệu đầu vào.");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        //{
        //    {
        //        if (dgv_tblCTHDN.CurrentRow == null)
        //        {
        //            MessageBox.Show("Chọn một hàng để xóa");
        //            return;
        //        }
        //        int index = dgv_tblCTHDN.CurrentRow.Index;
        //        string ID = dv[index]["sID"].ToString();
        //        try
        //        {
        //            DialogResult dialogResult = MessageBox.Show("Có chắc muốn xóa thuốc " + ID + " không ?",
        //                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        //            if (dialogResult == DialogResult.Yes)
        //            {
        //                //thuc hien xoa
        //                dv.Delete(index);

        //                using (SqlConnection conn = new SqlConnection(connectionString))
        //                {
        //                    SqlDataAdapter adapter = new SqlDataAdapter();
        //                    adapter.DeleteCommand = new SqlCommand("DELETE FROM tblChiTietHoaDonNhap WHERE sID = @sID", conn);
        //                    adapter.DeleteCommand.Parameters.AddWithValue("@sID", ID);

        //                    // Cập nhật thay đổi vào database
        //                    adapter.Update(dv.Table);
        //                }
        //                btn_boqua_Click(sender, e);
        //            }
        //            else
        //            {
        //                return;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            //else if (ex is SqlException && strError.Contains("40"))
        //            //{
        //            //Lồi 40: không mở được kết nối đến SQL server
        //            //}
        //        }
        //    }
        //}
        {
            // Kiểm tra nếu không có hàng nào được chọn
            if (dgv_tblCTHDN.CurrentRow == null)
            {
                MessageBox.Show("Chọn một hàng để xóa");
                return;
            }

            // Lấy thông tin từ hàng hiện tại
            int index = dgv_tblCTHDN.CurrentRow.Index;
            string sID = dgv_tblCTHDN.CurrentRow.Cells["sID"].Value.ToString();
            string sSoHD = dgv_tblCTHDN.CurrentRow.Cells["sSoHD"].Value.ToString();

            try
            {
                // Xác nhận hành động xóa
                DialogResult dialogResult = MessageBox.Show("Có chắc muốn xóa chi tiết hóa đơn nhập với ID " + sID + " không?",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM tblChiTietDonNhap WHERE sID = @sID", conn);
                        cmd.Parameters.AddWithValue("@sID", sID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Cập nhật dữ liệu trong DataGridView
                            LoadData(); // Hàm này sẽ nạp lại dữ liệu từ cơ sở dữ liệu
                            MessageBox.Show("Xóa chi tiết hóa đơn nhập thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Xóa chi tiết hóa đơn nhập thất bại.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            tb_ID.Text = "";
            tb_ID.ReadOnly = false;
            tb_SoHD.Text = "";
            tb_mathuoc.Text = "";
            tb_ncc.Text = "";
            tb_sl.Text = "";
            tb_giamua.Text = "";
            LoadData();
            btn_them.Enabled = true;
        }

        private void dgv_tblCTHDN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_tblCTHDN.CurrentRow.Index;
            //tb_masv.Text = dgv_tblSV.Rows[index].Cells["masv"].Value.ToString(); //lay du lieu tu dgv
            //tb_masv.Text = dt.Rows[index]["sMaSV"].ToString();                   //lay du lieu tu DataTable
            tb_ID.Text = dv[index]["sID"].ToString();                     //lay du lieu tu goc nhin DataView
            tb_ID.ReadOnly = true;
            tb_SoHD.Text = dv[index]["sSoHD"].ToString();
            tb_mathuoc.Text = dv[index]["sMaThuoc"].ToString();
            tb_ncc.Text = dv[index]["sMaNCC"].ToString();
            tb_sl.Text = dv[index]["fSoluong"].ToString();
            tb_giamua.Text = dv[index]["fGiaMua"].ToString();

            btn_them.Enabled = false;
        }

        private void btn_inCTDN_Click(object sender, EventArgs e)
        {
            string reportFilter = "NOT(ISNULL({Select_CTHDN.sSoHD}))";
            if (!string.IsNullOrEmpty(tb_SoHD.Text))
            {
                reportFilter += string.Format(" AND {0} LIKE '*{1}*'", "{Select_CTHDN.sSoHD}", tb_SoHD.Text);
                InCTHDN inCTHDN = new InCTHDN();
                inCTHDN.Show();
                inCTHDN.ShowReportCTHDN("CTHDN.rpt", "Select_CTHDN", reportFilter);
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 số hóa đơn");
            }
            //if (!string.IsNullOrEmpty(tb_hoten.Text))
            //{
            //    reportFilter += string.Format(" AND {0} LIKE '*{1}*'", "{Select_tblNhanVien.sTenNV}", tb_hoten.Text);
            //}

            //InCTHDN inCTHDN = new InCTHDN();
            //inCTHDN.Show();
            //inCTHDN.ShowReportCTHDN("CTHDN.rpt", "Select_CTHDN", reportFilter);
        }

        private void btn_InDSHDNCC_Click(object sender, EventArgs e)
        {
            InCTHDN inCTHDN = new InCTHDN();
            inCTHDN.Show();
            inCTHDN.ShowReportCTHDN("CTHDN_NCC.rpt", "Select_CTHDN", null);
        }

        private void dgv_tblCTHDN_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dgv_tblCTHDN.HitTest(e.X, e.Y);
                if (hitTestInfo.Type == DataGridViewHitTestType.ColumnHeader)
                {
                    // Lấy tên cột được nhấp
                    string columnName = dgv_tblCTHDN.Columns[hitTestInfo.ColumnIndex].HeaderText;

                    // Mở form tìm kiếm và truyền tên cột
                    FormTimKiem timKiemCTHDN = new FormTimKiem();
                    timKiemCTHDN.Initialize(columnName, this); // Truyền columnName và interface
                    timKiemCTHDN.ShowDialog();
                }
            }
        }
        public void SearchInDataGridView(string columnName, string searchValue)
        {
            dv.RowFilter = $"{columnName} LIKE '%{searchValue}%'";
            dgv_tblCTHDN.DataSource = dv;

            if (dv.Count == 0)
            {
                MessageBox.Show("Không tìm thấy giá trị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_InAllCTHDN_Click(object sender, EventArgs e)
        {
            InCTHDN inCTHDN = new InCTHDN();
            inCTHDN.Show();
            inCTHDN.ShowReportCTHDN("DSCTHDN.rpt", "Select_CTHDN", null);
        }

        private void tb_ID_Validating(object sender, CancelEventArgs e)
        {
            {
                if (String.IsNullOrEmpty(tb_ID.Text))
                {
                    //e.Cancel = true;
                    errorProvider.SetError(tb_ID, "ID không được để trống");
                }
                else
                {
                    //e.Cancel = false;
                    errorProvider.SetError(tb_ID, null);
                }
            }
        }

        private void tb_ncc_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_ncc.Text))
            {
                //e.Cancel = true;
                errorProvider.SetError(tb_ncc, "Nhà cung cấp không được để trống");
            }
            else
            {
                //e.Cancel = false;
                errorProvider.SetError(tb_ncc, null);
            }
        }

        private void tb_SoHD_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_SoHD.Text))
            {
                //e.Cancel = true;
                errorProvider.SetError(tb_SoHD, "Số hóa đơn không được để trống");
            }
            else
            {
                //e.Cancel = false;
                errorProvider.SetError(tb_SoHD, null);
            }
        }

        private void tb_mathuoc_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_mathuoc.Text))
            {
                //e.Cancel = true;
                errorProvider.SetError(tb_mathuoc, "Mã thuốc không được để trống");
            }
            else
            {
                //e.Cancel = false;
                errorProvider.SetError(tb_mathuoc, null);
            }
        }
    }
}
