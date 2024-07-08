using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BTH3
{
    public partial class QuanLyNV : Form/*,IXuLyDuLieu*/
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QuanlyThuoc"].ConnectionString;
        ErrorProvider errorProvider = new ErrorProvider();
        DataView dv = new DataView();
        public QuanLyNV()
        {
            InitializeComponent();
            this.Text = "Thông tin nhân viên";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string querySelect = "Select_TongHop1"; //stored

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
                                    dgv_tblNV.AutoGenerateColumns = false;
                                    dgv_tblNV.DataSource = dv;
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

        private void tb_manv_TextChanged(object sender, EventArgs e)
        {
            if (tb_manv.Text.Length > 0)
            {
                btn_them.Enabled = true;
            }
            else
            {
                btn_them.Enabled = false;
            }
        }

        private void tb_manv_Validated(object sender, EventArgs e)
        {

        }

        private void tb_manv_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_manv.Text))
            {
                //e.Cancel = true;
                errorProvider.SetError(tb_manv, "Mã nhân viên không được để trống");
            }
            else
            {
                //e.Cancel = false;
                errorProvider.SetError(tb_manv, null);
            }
        }

        private void dgv_tblNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_tblNV.CurrentRow.Index;
            //tb_masv.Text = dgv_tblSV.Rows[index].Cells["masv"].Value.ToString(); //lay du lieu tu dgv
            //tb_masv.Text = dt.Rows[index]["sMaSV"].ToString();                   //lay du lieu tu DataTable
            tb_manv.Text = dv[index]["sMaNV"].ToString(); //lay du lieu tu goc nhin DataView
            tb_manv.ReadOnly = true;
            tb_hoten.Text = dv[index]["sTenNV"].ToString();
            dt_ngsinh.Text = dv[index]["dNgaySinh"].ToString();
            tb_sdt.Text = dv[index]["sDienThoai"].ToString();
            tb_diachi.Text = dv[index]["sDiaChi"].ToString();
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
            if (dgv_tblNV.CurrentRow == null)
            {
                MessageBox.Show("Chọn một hàng để xóa");
                return;
            }
            int index = dgv_tblNV.CurrentRow.Index;
            string manv = dv[index]["sMaNV"].ToString();
            try
            {
                DialogResult dialogResult = MessageBox.Show("Có chắc muốn xóa nhân viên " + manv + " không ?",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    //thuc hien xoa
                    dv.Delete(index);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.DeleteCommand = new SqlCommand("DELETE FROM tblNhanVien WHERE sMaNV = @sMaNV", conn);
                        adapter.DeleteCommand.Parameters.AddWithValue("@sMaNV", manv);

                        // Cập nhật thay đổi vào database
                        adapter.Update(dv.Table);
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
                if (strError.Contains("FK_tblNhanVien_tblDIEM"))
                {
                    MessageBox.Show("Ma sinh vien " + manv + " da co phat sinh diem");
                }
                //else if (ex is SqlException && strError.Contains("40"))
                //{
                //Lồi 40: không mở được kết nối đến SQL server
                //}
            }
        }

        private void tb_sdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(tb_manv.Text) && int.TryParse(tb_manv.Text, out int maNV) && maNV > 0)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = new SqlCommand("SELECT * FROM tblNhanVien", conn);
                        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                        DataTable tblNhanVien = new DataTable();
                        adapter.Fill(tblNhanVien);

                        // Assuming input validation before inserting

                        DataRow newRow = tblNhanVien.NewRow();
                        newRow["sMaNV"] = tb_manv.Text;
                        newRow["sTenNV"] = tb_hoten.Text;
                        newRow["dNgaySinh"] = dt_ngsinh.Value;
                        newRow["bGioiTinh"] = rb_nam.Checked ? true : false;
                        newRow["sDiaChi"] = tb_diachi.Text;
                        newRow["dNgayvaolam"] = DateTime.Now;
                        newRow["sDienThoai"] = tb_sdt.Text;

                        tblNhanVien.Rows.Add(newRow);

                        adapter.InsertCommand = new SqlCommand("Insert_tblNhanVien", conn);
                        adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@sMaNV", SqlDbType.NVarChar, 10, "sMaNV"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@sTenNV", SqlDbType.NVarChar, 50, "sTenNV"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@dNgaySinh", SqlDbType.Date, 0, "dNgaySinh"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@bGioiTinh", SqlDbType.Bit, 1, "bGioiTinh"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@sDiaChi", SqlDbType.NVarChar, 50, "sDiaChi"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@dNgayvaolam", SqlDbType.Date, 0, "dNgayvaolam"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@sDienThoai", SqlDbType.NVarChar, 12, "sDienThoai"));

                        int rowsAffected = adapter.Update(tblNhanVien);

                        if (rowsAffected > 0)
                        {
                            dgv_tblNV.DataSource = tblNhanVien.DefaultView;
                            btn_boqua_Click(sender, e);
                            MessageBox.Show("Thêm nhân viên thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Thêm nhân viên thất bại.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mã nhân viên phải không trống và lớn hơn 0.");
                }
            }
            catch (Exception ex)
            {
                string strError = ex.Message;
                if (strError.Contains("'PK__tblNhanV__328E1C0F6A2FE2B4'"))
                {
                    MessageBox.Show("Mã nhân viên " + tb_manv.Text + " này đã tồn tại");
                }
                //else if (strError.Contains("'Index 12 is either negative or above rows count.'"))
                //{
                //    MessageBox.Show("Mã nhân viên phải lớn hơn 0");
                //}
            }
        }
        private void btn_boqua_Click(object sender, EventArgs e)
        {
            tb_manv.Text = "";
            tb_manv.ReadOnly = false;
            tb_hoten.Text = "";
            tb_sdt.Text = "";
            tb_diachi.Text = "";
            dt_ngsinh.Text = null;
            rb_nam.Checked = false;
            rb_nu.Checked = false;
            btn_them.Enabled = true;
            dgv_tblNV.ClearSelection();
            LoadData();
            //dv.RowFilter = string.Empty;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đầu vào
                if (!string.IsNullOrWhiteSpace(tb_manv.Text) && int.TryParse(tb_manv.Text, out int maNV) && maNV > 0)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tblNhanVien", conn);
                        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                        DataTable tblNhanVien = new DataTable();
                        adapter.Fill(tblNhanVien);

                        // Tìm hàng cần cập nhật
                        DataRow[] rowsToUpdate = tblNhanVien.Select("sMaNV = '" + tb_manv.Text + "'");
                        if (rowsToUpdate.Length > 0)
                        {
                            DataRow rowToUpdate = rowsToUpdate[0];

                            // Cập nhật các giá trị mới
                            rowToUpdate["sTenNV"] = tb_hoten.Text;
                            rowToUpdate["dNgaySinh"] = dt_ngsinh.Value;
                            rowToUpdate["bGioiTinh"] = rb_nam.Checked ? true : false;
                            rowToUpdate["sDiaChi"] = tb_diachi.Text;
                            rowToUpdate["dNgayvaolam"] = DateTime.Now; // Hoặc lấy giá trị từ input nếu cần
                            rowToUpdate["sDienThoai"] = tb_sdt.Text;

                            // Đồng bộ thay đổi với cơ sở dữ liệu
                            int rowsAffected = adapter.Update(tblNhanVien);

                            if (rowsAffected > 0)
                            {
                                dgv_tblNV.DataSource = tblNhanVien.DefaultView;
                                btn_boqua_Click(sender, e);
                                MessageBox.Show("Cập nhật nhân viên thành công.");
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật nhân viên thất bại.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhân viên cần cập nhật.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mã nhân viên phải không trống và lớn hơn 0.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            string TK_manv = tb_manv.Text.Trim();

            // Kiểm tra xem từ khóa tìm kiếm có rỗng không
            if (string.IsNullOrEmpty(TK_manv) && string.IsNullOrEmpty(tb_hoten.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên hoặc tên nhân viên cần tìm.");
                return;
            }


            // Lặp qua các dòng trong DataView để tìm kiếm
            //foreach (DataGridViewRow row in dgv_tblNV.Rows)
            //{
            //    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == TK_manv)
            //    {
            //        // Tìm thấy từ khóa trong cột "sMaNV"
            //        row.Selected = true; // Chọn dòng tìm thấy
            //        dgv_tblNV.CurrentCell = row.Cells[0]; // Di chuyển đến ô chứa từ khóa
            //        return;
            //    }
            //}

            // Nếu không tìm thấy từ khóa
            //MessageBox.Show("Không tìm thấy kết quả cho từ khóa \"" + TK_manv + "\".");
            string filterTen = tb_hoten.Text;
            if (!string.IsNullOrEmpty(filterTen))
            {
                dv.RowFilter = $"sTenNV LIKE '%{filterTen}%'";
            }
            string filterMaNV = tb_manv.Text;
            if (!string.IsNullOrEmpty(filterMaNV))
            {
                dv.RowFilter = $"sMaNV LIKE '%{filterMaNV}%'";
            }
        }

        private void tb_hoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_tblNV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0 && dgv_tblNV.Columns[e.ColumnIndex].Name == "sMaNV")
            //{
            //    // Hiển thị Form A và truyền vào interface
            //    FormLocHoTen formLocHoten = new FormLocHoTen(this);
            //    formLocHoten.ShowDialog();
            //}
        }
        public void FilterData(string dulieu)
        {
            dv.RowFilter = $"sMaNV = '{dulieu}'";
        }

        private void btn_lsdn_Click(object sender, EventArgs e)
        {
            //{
            //    if (tb_manv.Text != null)
            //    {
            //        string selectedMaNV = tb_manv.Text.ToString();
            //        Form2 form2 = new Form2(this);
            //        form2.IDataHD(selectedMaNV);
            //        if (form2.dgv_hdn.Rows.Count == 0)
            //        {
            //            MessageBox.Show("Bệnh nhân chưa có lịch sử khám.");
            //        }
            //        else
            //        {
            //            form2.Show();
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Vui lòng chọn mã bệnh nhân.");
            //    }
            //}
        }
    }
}
