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
    public partial class QuanLyThuoc : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QuanlyThuoc"].ConnectionString;
        ErrorProvider errorProvider = new ErrorProvider();
        DataView dv = new DataView();
        private string reportFilter;
        public QuanLyThuoc()
        {
            InitializeComponent();
            this.Text = "Thông tin thuốc";
            this.Size = new Size(1200, 460);
        }
        private void LoadData()
        {
            string querySelect = "Select_TongHopThuoc"; //stored

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
                                    dgv_tblThuoc.AutoGenerateColumns = true;
                                    dgv_tblThuoc.DataSource = dv;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyThuoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_tblThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_tblThuoc.CurrentRow.Index;
            //tb_masv.Text = dgv_tblSV.Rows[index].Cells["masv"].Value.ToString(); //lay du lieu tu dgv
            //tb_masv.Text = dt.Rows[index]["sMaSV"].ToString();                   //lay du lieu tu DataTable
            tb_mathuoc.Text = dv[index]["sMaThuoc"].ToString();                     //lay du lieu tu goc nhin DataView
            tb_mathuoc.ReadOnly = true;
            tb_maloaithuoc.Text = dv[index]["sMaLoaiThuoc"].ToString();
            tb_tenthuoc.Text = dv[index]["sTenThuoc"].ToString();
            tb_ncc.Text = dv[index]["sMaNCC"].ToString();
            tb_noisx.Text = dv[index]["sNoiSX"].ToString();
            tb_sl.Text = dv[index]["iSoLuong"].ToString();
            mtx_hsd.Text = dv[index]["dHanSD"].ToString();
            tb_dvb.Text = dv[index]["sDonViBan"].ToString();
            tb_gb.Text = dv[index]["fDonGia"].ToString();
            tb_dvbl.Text = dv[index]["sDonViBanLe"].ToString();
            tb_gbl.Text = dv[index]["fDonGiaBanLe"].ToString();

            btn_them.Enabled = false;
        }

        private void mtx_hsd_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("The date you supplied is not a valid date. Please re-enter.");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đầu vào
                if (!string.IsNullOrWhiteSpace(tb_mathuoc.Text))
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tblThuoc", conn);
                        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                        DataTable tblNhanVien = new DataTable();
                        adapter.Fill(tblNhanVien);

                        // Tìm hàng cần cập nhật
                        DataRow[] rowsToUpdate = tblNhanVien.Select("sMaThuoc = '" + tb_mathuoc.Text + "'");
                        if (rowsToUpdate.Length > 0)
                        {
                            DataRow rowToUpdate = rowsToUpdate[0];

                            // Cập nhật các giá trị mới
                            rowToUpdate["sMaThuoc"] = tb_mathuoc.Text;
                            rowToUpdate["sMaLoaiThuoc"] = tb_maloaithuoc.Text;
                            rowToUpdate["sTenThuoc"] = tb_tenthuoc.Text;
                            rowToUpdate["sMaNCC"] = tb_ncc.Text;
                            rowToUpdate["sNoiSX"] = tb_noisx.Text;
                            rowToUpdate["iSoLuong"] = tb_sl.Text;
                            rowToUpdate["dHanSD"] = mtx_hsd.Text;
                            rowToUpdate["fDonGia"] = tb_gb.Text;
                            rowToUpdate["fDonGiaBanLe"] = tb_gbl.Text;
                            rowToUpdate["sDonViBan"] = tb_dvb.Text;
                            rowToUpdate["sDonViBanLe"] = tb_dvbl.Text;

                            // Đồng bộ thay đổi với cơ sở dữ liệu
                            int rowsAffected = adapter.Update(tblNhanVien);

                            if (rowsAffected > 0)
                            {
                                dgv_tblThuoc.DataSource = tblNhanVien.DefaultView;
                                btn_boqua_Click(sender, e);
                                MessageBox.Show("Cập nhật thuốc thành công.");
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật thuốc thất bại.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thuốc cần cập nhật.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mã thuốc phải không trống.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(tb_mathuoc.Text))
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = new SqlCommand("SELECT * FROM tblThuoc", conn);
                        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                        DataTable tblThuoc = new DataTable();
                        adapter.Fill(tblThuoc);

                        // Assuming input validation before inserting

                        DataRow newRow = tblThuoc.NewRow();
                        newRow["sMaThuoc"] = tb_mathuoc.Text;
                        newRow["sMaLoaiThuoc"] = tb_maloaithuoc.Text;
                        newRow["sTenThuoc"] = tb_tenthuoc.Text;
                        newRow["sMaNCC"] = tb_ncc.Text;
                        newRow["sNoiSX"] = tb_noisx.Text;
                        newRow["iSoLuong"] = tb_sl.Text;
                        newRow["dHanSD"] = mtx_hsd.Text;
                        newRow["fDonGia"] = tb_gb.Text;
                        newRow["fDonGiaBanLe"] = tb_gbl.Text;
                        newRow["sDonViBan"] = tb_dvb.Text;
                        newRow["sDonViBanLe"] = tb_dvbl.Text;

                        tblThuoc.Rows.Add(newRow);

                        adapter.InsertCommand = new SqlCommand("Insert_tblThuoc", conn);
                        adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@sMaThuoc", SqlDbType.NVarChar, 10, "sMaThuoc"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@sMaLoaiThuoc", SqlDbType.NVarChar, 10, "sMaLoaiThuoc"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@sTenThuoc", SqlDbType.NVarChar, 50, "sTenThuoc"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@sMaNCC", SqlDbType.NVarChar, 10, "sMaNCC"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@sNoiSX", SqlDbType.NVarChar, 50, "sNoiSX"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@iSoLuong", SqlDbType.Int, 50, "iSoLuong"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@dHanSD", SqlDbType.Date, 0, "dHanSD"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@fDonGia", SqlDbType.Float, 50, "fDonGia"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@fDonGiaBanLe", SqlDbType.Float, 50, "fDonGiaBanLe"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@sDonViBan", SqlDbType.NVarChar, 20, "sDonViBan"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@sDonViBanLe", SqlDbType.NVarChar, 20, "sDonViBanLe"));

                        int rowsAffected = adapter.Update(tblThuoc);

                        if (rowsAffected > 0)
                        {
                            dgv_tblThuoc.DataSource = tblThuoc.DefaultView;
                            btn_boqua_Click(sender, e);
                            MessageBox.Show("Thêm thuốc thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Thêm thuốc thất bại.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mã thuốc phải không trống.");
                }
            }
            catch (Exception ex)
            {
                string strError = ex.Message;
                //if (strError.Contains("'PK__tblNhanV__328E1C0F6A2FE2B4'"))
                //{
                //    MessageBox.Show("Mã nhân viên " + tb_manv.Text + " này đã tồn tại");
                //}
                //else if (strError.Contains("'Index 12 is either negative or above rows count.'"))
                //{
                //    MessageBox.Show("Mã nhân viên phải lớn hơn 0");
                //}
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_tblThuoc.CurrentRow == null)
            {
                MessageBox.Show("Chọn một hàng để xóa");
                return;
            }
            int index = dgv_tblThuoc.CurrentRow.Index;
            string mathuoc = dv[index]["sMaThuoc"].ToString();
            try
            {
                DialogResult dialogResult = MessageBox.Show("Có chắc muốn xóa thuốc " + mathuoc + " không ?",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    //thuc hien xoa
                    dv.Delete(index);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.DeleteCommand = new SqlCommand("DELETE FROM tblThuoc WHERE sMaThuoc = @sMaThuoc", conn);
                        adapter.DeleteCommand.Parameters.AddWithValue("@sMaThuoc", mathuoc);

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

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            tb_mathuoc.Text = "";
            tb_mathuoc.ReadOnly = false;
            tb_maloaithuoc.Text = "";
            tb_tenthuoc.Text = "";
            tb_ncc.Text = "";
            tb_noisx.Text = "";
            tb_sl.Text = "";
            mtx_hsd.Text = "";
            tb_dvb.Text = "";
            tb_gb.Text = "";
            tb_dvbl.Text = "";
            tb_gbl.Text = "";
            dgv_tblThuoc.ClearSelection();
            LoadData();
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

        private void tb_maloaithuoc_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_maloaithuoc.Text))
            {
                //e.Cancel = true;
                errorProvider.SetError(tb_maloaithuoc, "Mã loại thuốc không được để trống");
            }
            else
            {
                //e.Cancel = false;
                errorProvider.SetError(tb_maloaithuoc, null);
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

        private void tb_mathuoc_TextChanged(object sender, EventArgs e)
        {
            if (tb_mathuoc.Text.Length > 0)
            {
                btn_them.Enabled = true;
            }
            else
            {
                btn_them.Enabled = false;
            }
        }

        private void btn_dsthuoc_Click(object sender, EventArgs e)
        {
            InDSThuoc inDSThuoc = new InDSThuoc();
            inDSThuoc.Show();
            inDSThuoc.ShowReportThuoc("DSThuoc.rpt", "Select_TongHopThuoc", null);
        }
    }
}
