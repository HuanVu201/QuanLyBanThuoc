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
    public partial class QuanLyKhachHang : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QuanlyThuoc"].ConnectionString;
        ErrorProvider errorProvider = new ErrorProvider();
        DataView dv = new DataView();
        private string reportFilter;
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string querySelect = "GetAllKhachHang";

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

                                    dt.Columns.Add("sGioiTinh", typeof(string));
                                    foreach (DataRow row in dt.Rows)
                                    {
                                        bool value = Convert.ToBoolean(row["bGioiTinh"]);
                                        row["sGioiTinh"] = value ? "Nam" : "Nữ";
                                    }

                                    dv = dt.DefaultView;
                                    dgv_tblKH.AutoGenerateColumns = false;
                                    dgv_tblKH.DataSource = dv;
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

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(tb_maKH.Text))
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = new SqlCommand("SELECT * FROM tblKhachHang", conn);
                        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                        DataTable tblThuoc = new DataTable();
                        adapter.Fill(tblThuoc);

                        // Assuming input validation before inserting

                        DataRow newRow = tblThuoc.NewRow();
                        newRow["sMaKH"] = tb_maKH.Text;
                        newRow["sHoTen"] = tb_tenKH.Text;
                        newRow["sDiachi"] = tb_diachiKH.Text;
                        newRow["sSDT"] = tb_sdtKH.Text;
                        newRow["dNgaySinh"] = tb_ngaySinh.Text;
                        newRow["bGioiTinh"] = rb_nam.Checked ? true : false;
                        newRow["sKieuDoiTuong"] = cb_doiTuong.Text;
                        newRow["sMaSoThue"] = tb_maSoThue.Text;

                        tblThuoc.Rows.Add(newRow);

                        adapter.InsertCommand = new SqlCommand("InsertKhachHang", conn);
                        adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@sMaKH", SqlDbType.NVarChar, 10, "sMaKH"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@sHoTen", SqlDbType.NVarChar, 50, "sHoTen"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@sDiachi", SqlDbType.NVarChar, 50, "sDiachi"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@sSDT", SqlDbType.VarChar, 15, "sSDT"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@dNgaySinh", SqlDbType.Date, 50, "dNgaySinh"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@bGioiTinh", SqlDbType.Bit, 50, "bGioiTinh"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@sKieuDoiTuong", SqlDbType.NVarChar, 20, "sKieuDoiTuong"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@sMaSoThue", SqlDbType.NVarChar, 50, "sMaSoThue"));

                        int rowsAffected = adapter.Update(tblThuoc);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm khách hàng thành công!");
                            btn_boqua_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Thêm khách hàng thất bại!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mã khách hàng không được để trống!");
                }
            }
            catch (Exception ex)
            {
                string strError = ex.Message;
                MessageBox.Show(strError);

            }
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            tb_maKH.Text = string.Empty;
            tb_tenKH.Text = string.Empty;
            tb_diachiKH.Text = string.Empty;
            tb_sdtKH.Text = string.Empty;
            tb_ngaySinh.Text = string.Empty;
            rb_nam.Checked = false;
            rb_nu.Checked = false;
            cb_doiTuong.Text = string.Empty;
            tb_maSoThue.Text = string.Empty;
            LoadData();
        }

        private void dgv_tblKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_tblKH.CurrentRow.Index;

            tb_maKH.Text = dv[index]["sMaKH"].ToString(); //lay du lieu tu goc nhin DataView
            //tb_maKH.ReadOnly = true;
            tb_tenKH.Text = dv[index]["sHoTen"].ToString();
            tb_ngaySinh.Text = dv[index]["dNgaySinh"].ToString();
            tb_sdtKH.Text = dv[index]["sSDT"].ToString();
            tb_diachiKH.Text = dv[index]["sDiachi"].ToString();
            cb_doiTuong.Text = dv[index]["sKieuDoiTuong"].ToString();
            tb_maSoThue.Text = dv[index]["sMaSoThue"].ToString();
            if ((bool)(dv[index]["bGioitinh"]) == true)
            {
                rb_nam.Checked = true;
            }
            else
            {
                rb_nu.Checked = true;
            }
            btn_them.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //DeleteKhachHang
            if (dgv_tblKH.CurrentRow == null)
            {
                MessageBox.Show("Chọn một hàng để xóa");
                return;
            }
            int index = dgv_tblKH.CurrentRow.Index;
            string hoTen = dv[index]["sHoTen"].ToString();
            string makh = dv[index]["sMaKH"].ToString();
            try
            {
                DialogResult dialogResult = MessageBox.Show("Có chắc muốn xóa khách hàng '" + hoTen + "' không ?",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    dv.Delete(index);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string queryDelete = "DeleteKhachHang";
                        using (SqlCommand cmd = new SqlCommand(queryDelete, conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@sMaKH", makh);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show($"Xóa khách hàng {hoTen} thành công!");
                        }
                    }
                    btn_boqua_Click(sender, e);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                string strError = ex.Message;
                MessageBox.Show($"Lỗi: {strError}");

            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đầu vào
                if (!string.IsNullOrEmpty(tb_maKH.Text))
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tblKhachHang", conn);
                        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                        DataTable tblKhachHang = new DataTable();
                        adapter.Fill(tblKhachHang);

                        // Tìm hàng cần cập nhật
                        DataRow[] rowsToUpdate = tblKhachHang.Select("sMaKH = '" + tb_maKH.Text + "'");
                        if (rowsToUpdate.Length > 0)
                        {
                            DataRow rowToUpdate = rowsToUpdate[0];

                            // Cập nhật các giá trị mới
                            rowToUpdate["sHoTen"] = tb_tenKH.Text;
                            rowToUpdate["sDiachi"] = tb_diachiKH.Text;
                            rowToUpdate["sSDT"] = tb_sdtKH.Text;
                            rowToUpdate["dNgaySinh"] = tb_ngaySinh.Text;
                            rowToUpdate["bGioitinh"] = rb_nam.Checked ? true : false;
                            rowToUpdate["sKieuDoiTuong"] = cb_doiTuong.Text;
                            rowToUpdate["sMaSoThue"] = tb_maSoThue.Text;

                            // Đồng bộ thay đổi với cơ sở dữ liệu
                            int rowsAffected = adapter.Update(tblKhachHang);

                            if (rowsAffected > 0)
                            {
                                dgv_tblKH.DataSource = tblKhachHang.DefaultView;
                                LoadData();
                                MessageBox.Show("Cập nhật khách hàng thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật khách hàng thất bại!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy khách hàng cần cập nhật!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mã khách hàng không hợp lệ!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật khách hàng: " + ex.Message);
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_maKH.Text.Trim()) && string.IsNullOrEmpty(tb_tenKH.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập mã/tên khách hàng cần tìm!");
                return;
            }

            string filter = string.Empty;

            string filterTen = tb_tenKH.Text.Trim();
            if (!string.IsNullOrEmpty(filterTen))
            {
                filter = $" AND sHoTen LIKE '%{filterTen}%'";
            }

            string filterMaKH = tb_maKH.Text.Trim();
            if (!string.IsNullOrEmpty(filterMaKH))
            {
                filter += $" AND sMaKH LIKE '%{filterMaKH}%'";
            }
            if (filter.StartsWith(" AND"))
            {
                filter = filter.Substring(" AND".Length);
            }
            dv.RowFilter = filter;
        }

        private void btn_inDSNV_Click(object sender, EventArgs e)
        {
            string reportFilter = string.Empty;
            //reportFilter = "NOT(ISNULL({GetAllKhachHang.sMaSV}))";
            //if (!string.IsNullOrEmpty(reportFilter))
            //{

            //}

            FormInDSKH formInDSKH = new FormInDSKH();
            formInDSKH.Show();
            formInDSKH.ShowReport("DSKH.rpt", "GetAllKhachHang", reportFilter);
        }
    }
}
