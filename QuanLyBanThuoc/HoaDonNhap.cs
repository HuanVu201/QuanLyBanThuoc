using QuanLyBanThuoc.BaoCao;
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
    public partial class HoaDonNhap : Form, TimKiem
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QuanlyThuoc"].ConnectionString;
        ErrorProvider errorProvider = new ErrorProvider();
        DataView dv = new DataView();
        private string reportFilter;
        public HoaDonNhap()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string querySelect = "Select_HoaDonNhap"; //stored

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
                                    dgv_tblHDN.AutoGenerateColumns = true;
                                    dgv_tblHDN.DataSource = dv;
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
                if (!string.IsNullOrWhiteSpace(tb_SoHD.Text))
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = new SqlCommand("SELECT sSoHD, sMaNV, dNgayLap, fTongGiaMua FROM tblHoaDonNhap", conn);
                        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                        DataTable tblHDN = new DataTable();
                        adapter.Fill(tblHDN);

                        // Assuming input validation before inserting

                        DataRow newRow = tblHDN.NewRow();
                        newRow["sSoHD"] = tb_SoHD.Text;
                        newRow["sMaNV"] = tb_MaNV.Text;
                        newRow["dNgayLap"] = mtb_ngaylap.Text;

                        tblHDN.Rows.Add(newRow);

                        adapter.InsertCommand = new SqlCommand("Insert_tblHDN", conn);
                        adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@sSoHD", SqlDbType.VarChar, 15, "sSoHD"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@sMaNV", SqlDbType.NVarChar, 10, "sMaNV"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@dNgayLap", SqlDbType.Date, 0, "dNgayLap"));

                        int rowsAffected = adapter.Update(tblHDN);

                        if (rowsAffected > 0)
                        {
                            dgv_tblHDN.DataSource = tblHDN.DefaultView;
                            btn_boqua_Click(sender, e);
                            MessageBox.Show("Thêm hóa đơn thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Thêm hóa đơn thất bại.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Số hóa đơn không được trống.");
                }
            }
            catch (Exception ex)
            {
                string strError = ex.Message;
                MessageBox.Show("Đã xáy ra lỗi " + strError);
                if (strError.Contains("'FK_tblHoaDonNhap_MaNV"))
                {
                    MessageBox.Show("Mã nhân viên " + tb_MaNV.Text + " này không tồn tại");
                }
                else if (strError.Contains("PK_tblHoaDo_56411"))
                {
                    MessageBox.Show("Số hóa đơn không được trùng, Số hóa đơn "+ tb_SoHD +" đã tồn tại");
                }
            }
        }

        private void HoaDonNhap_Load(object sender, EventArgs e)
        {
            LoadData();
            //dgv_tblHDN.Columns["sSoHD"].HeaderText = "sSoHD";
        }

        private void dgv_tblHDN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_tblHDN.CurrentRow.Index;
            //tb_masv.Text = dgv_tblSV.Rows[index].Cells["masv"].Value.ToString(); //lay du lieu tu dgv
            //tb_masv.Text = dt.Rows[index]["sMaSV"].ToString();                   //lay du lieu tu DataTable
            tb_SoHD.Text = dv[index]["sSoHD"].ToString();                     //lay du lieu tu goc nhin DataView
            tb_SoHD.ReadOnly = true;
            tb_MaNV.Text = dv[index]["sMaNV"].ToString();
            mtb_ngaylap.Text = dv[index]["dNgayLap"].ToString();
            tb_tonggiamua.Text = dv[index]["fTongGiaMua"].ToString();

            btn_them.Enabled = false;
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            tb_SoHD.Text = "";
            tb_SoHD.ReadOnly = false;
            tb_MaNV.Text = "";
            mtb_ngaylap.Text = "";
            tb_tonggiamua.Text = "";
            dgv_tblHDN.ClearSelection();
            LoadData();
            btn_them.Enabled = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            {
                if (dgv_tblHDN.CurrentRow == null)
                {
                    MessageBox.Show("Chọn một hàng để xóa");
                    return;
                }
                int index = dgv_tblHDN.CurrentRow.Index;
                string SoHD = dv[index]["sSoHD"].ToString();
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Có chắc muốn xóa thuốc " + SoHD + " không ?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //thuc hien xoa
                        dv.Delete(index);

                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter();
                            adapter.DeleteCommand = new SqlCommand("DELETE FROM tblHoaDonNhap WHERE sSoHD = @sSoHD", conn);
                            adapter.DeleteCommand.Parameters.AddWithValue("@sSoHD", SoHD);

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
                    //else if (ex is SqlException && strError.Contains("40"))
                    //{
                    //Lồi 40: không mở được kết nối đến SQL server
                    //}
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đầu vào
                if (!string.IsNullOrWhiteSpace(tb_SoHD.Text))
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tblHoaDonNhap", conn);
                        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                        DataTable tblHDN = new DataTable();
                        adapter.Fill(tblHDN);

                        // Tìm hàng cần cập nhật
                        DataRow[] rowsToUpdate = tblHDN.Select("sSoHD = '" + tb_SoHD.Text + "'");
                        if (rowsToUpdate.Length > 0)
                        {
                            DataRow rowToUpdate = rowsToUpdate[0];

                            // Cập nhật các giá trị mới
                            rowToUpdate["sSoHD"] = tb_SoHD.Text;
                            rowToUpdate["sMaNV"] = tb_MaNV.Text;
                            rowToUpdate["dNgayLap"] = mtb_ngaylap.Text;
                            rowToUpdate["fTongGiaMua"] = tb_tonggiamua.Text;

                            // Đồng bộ thay đổi với cơ sở dữ liệu
                            int rowsAffected = adapter.Update(tblHDN);

                            if (rowsAffected > 0)
                            {
                                dgv_tblHDN.DataSource = tblHDN.DefaultView;
                                btn_boqua_Click(sender, e);
                                MessageBox.Show("Cập nhật hóa đơn thành công.");
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật hoa đơn thất bại.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy hóa đơn cần cập nhật.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("sSoHD phải không trống.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_indsdn_Click(object sender, EventArgs e)
        {
            InHDN inHDN = new InHDN();
            inHDN.Show();
            inHDN.ShowReportHDN("HDNhap.rpt", "Select_HoaDonNhap", null);
        }

        private void dgv_tblHDN_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dgv_tblHDN.HitTest(e.X, e.Y);
                if (hitTestInfo.Type == DataGridViewHitTestType.ColumnHeader)
                {
                    // Lấy tên cột được nhấp
                    string columnName = dgv_tblHDN.Columns[hitTestInfo.ColumnIndex].HeaderText;

                    // Mở form tìm kiếm và truyền tên cột
                    FormTimKiem timKiemHDN = new FormTimKiem();
                    timKiemHDN.Initialize(columnName, this); // Truyền columnName và interface
                    timKiemHDN.ShowDialog();
                }
            }
        }
        public void SearchInDataGridView(string columnName, string searchValue)
        {
            dv.RowFilter = $"{columnName} LIKE '%{searchValue}%'";
            dgv_tblHDN.DataSource = dv;

            if (dv.Count == 0)
            {
                MessageBox.Show("Không tìm thấy giá trị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
