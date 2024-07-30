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
    public partial class QuanLyXuatHoaDon : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QuanlyThuoc"].ConnectionString;
        ErrorProvider errorProvider = new ErrorProvider();
        DataView dv = new DataView();
        private string reportFilter;
        Thuoc currentThuoc = new Thuoc();
        List<string> maKhs = new List<string>();
        private string maNVCurrent;
        private string maChiTietHoaDon;
        private bool hinhThucBan;
        public QuanLyXuatHoaDon()
        {
            InitializeComponent();
        }

        private void QuanLyXuatHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();

        }



        private void cb_maThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_maThuoc.SelectedIndex != -1)
            {

                ComboBox comboBox = (ComboBox)sender;
                ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
                string selectedValue = selectedItem.Value;
                cb_hinhThucBan.Text = string.Empty;
                tb_donViBan.Text = string.Empty;
                tb_donGia.Text = string.Empty;
                tb_soLuong.Text = string.Empty;

                string querySelect = "GetThuocByMaThuoc";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = querySelect;
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@sMaThuoc", selectedValue);

                            using (SqlDataAdapter adapter = new SqlDataAdapter())
                            {
                                adapter.SelectCommand = cmd;
                                using (DataTable dt = new DataTable())
                                {
                                    adapter.Fill(dt);
                                    if (dt.Rows.Count > 0)
                                    {
                                        DataRow row = dt.Rows[0];

                                        tb_tenThuoc.Text = row["sTenThuoc"].ToString();

                                        currentThuoc.sMaThuoc = row["sMaThuoc"].ToString();
                                        currentThuoc.sMaLoaiThuoc = row["sMaLoaiThuoc"].ToString();
                                        currentThuoc.sTenThuoc = row["sTenThuoc"].ToString();
                                        currentThuoc.sMaNCC = row["sMaNCC"].ToString();
                                        currentThuoc.sNoiSX = row["sNoiSX"].ToString();
                                        currentThuoc.iSoLuong = row["iSoLuong"].ToString();
                                        currentThuoc.dHanSD = row["dHanSD"].ToString();
                                        currentThuoc.fDonGia = row["fDonGia"].ToString();
                                        currentThuoc.fDonGiaBanLe = row["fDonGiaBanLe"].ToString();
                                        currentThuoc.sDonViBan = row["sDonViBan"].ToString();
                                        currentThuoc.sDonViBanLe = row["sDonViBanLe"].ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Không có thông tin mã thuốc này!");
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lấy thông tin bệnh nhân: " + ex.Message);
                }
            }
        }


        private void cb_hinhThucBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            string selectedValue = selectedItem.Value;
            if (string.IsNullOrEmpty(cb_maThuoc.Text))
                return;
            if (selectedValue.Contains("1"))
            {
                tb_donViBan.Text = currentThuoc.sDonViBan.ToString();
                tb_donGia.Text = currentThuoc.fDonGia.ToString();
            }
            else if (selectedValue.Contains("0"))
            {
                tb_donViBan.Text = currentThuoc.sDonViBanLe.ToString();
                tb_donGia.Text = currentThuoc.fDonGiaBanLe.ToString();
            }
            tb_soLuong.Text = "1";
            if (selectedValue == "1")
                hinhThucBan = true;
            else
                hinhThucBan = false;
        }

        private void cb_maKH_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                ComboBox comboBox = (ComboBox)sender;
                ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
                string selectedValue = selectedItem.Value;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        string querySelect = "GetKhachHangByMaKH";
                        cmd.CommandText = querySelect;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sMaKH", selectedValue);

                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                adapter.Fill(dt);
                                if (dt.Rows.Count > 0)
                                {
                                    DataRow row = dt.Rows[0];
                                    tb_tenKH.Text = row["sHoTen"].ToString();
                                    tb_sdtKH.Text = row["sSDT"].ToString();
                                    tb_diachiKH.Text = row["sDiachi"].ToString();
                                    tb_ngaySinh.Text = row["dNgaySinh"].ToString();
                                    cb_doiTuong.Text = row["sKieuDoiTuong"].ToString();
                                    tb_maSoThue.Text = row["sMaSoThue"].ToString();


                                    bool value = Convert.ToBoolean(row["bGioiTinh"]);
                                    if (value)
                                    {
                                        rb_nam.Checked = true;
                                        rb_nu.Checked = false;
                                    }
                                    else
                                    {
                                        rb_nam.Checked = false;
                                        rb_nu.Checked = true;
                                    }
                                    EnableKhachHang(false);
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy thông tin khách hàng!");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy thông tin khách hàng: " + ex);
            }
        }

        private void cb_maKH_TextChanged(object sender, EventArgs e)
        {
            EnableKhachHang(true);
            ClearValueKhachHang();
        }






        private void tb_donGia_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!IsNumeric(textBox.Text) && !string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider.SetError(tb_donGia, "Nhập số!");
            }
            else
            {
                errorProvider.SetError(tb_donGia, "");
            }
        }

        private void tb_soLuong_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!IsNumeric(textBox.Text) && !string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider.SetError(tb_soLuong, "Nhập số!");
            }
            else
            {
                errorProvider.SetError(tb_soLuong, "");
            }
        }

        private void LoadData()
        {
            SetCurrentDateToMaskedTextBox(tb_ngayBan);
            tb_ngayBan.Enabled = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        string querySelect = "GetAllMaNV";
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
                                    cb_maNV.Items.Clear();
                                    foreach (DataRow row in dt.Rows)
                                    {
                                        string displayTextNV = row["sTenNV"].ToString();
                                        string valueNV = row["sMaNV"].ToString();
                                        cb_maNV.Items.Add(new ComboBoxItem(displayTextNV, valueNV));
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Không có bản ghi nào!");
                                }
                            }
                        }
                    }
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        string querySelect = "GetAllMaKH";
                        cmd.CommandText = querySelect;
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                adapter.Fill(dt);
                                maKhs.Clear();
                                if (dt.Rows.Count > 0)
                                {
                                    cb_maKH.Items.Clear();
                                    foreach (DataRow row in dt.Rows)
                                    {
                                        string displayTextNV = row["sMaKH"].ToString();
                                        string valueNV = row["sMaKH"].ToString();
                                        cb_maKH.Items.Add(new ComboBoxItem(displayTextNV, valueNV));
                                        maKhs.Add(valueNV);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Không có bản ghi nào!");
                                }
                            }
                        }
                    }
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        string querySelect = "GetAllMaThuoc";
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
                                    cb_maThuoc.Items.Clear();
                                    foreach (DataRow row in dt.Rows)
                                    {
                                        string displayTextNV = row["sMaThuoc"].ToString();
                                        string valueNV = row["sMaThuoc"].ToString();
                                        cb_maThuoc.Items.Add(new ComboBoxItem(displayTextNV, valueNV));
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Không có bản ghi nào!");
                                }
                            }
                        }
                    }

                    cb_hinhThucBan.Items.Clear();
                    cb_hinhThucBan.Items.Add(new ComboBoxItem("Bán nguyên", "1"));
                    cb_hinhThucBan.Items.Add(new ComboBoxItem("Bán lẻ", "0"));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy thông tin: " + ex);
            }
        }

        public class ComboBoxItem
        {
            public string DisplayText { get; set; }
            public string Value { get; set; }

            public ComboBoxItem(string displayText, string value)
            {
                DisplayText = displayText;
                Value = value;
            }

            public override string ToString()
            {
                return DisplayText;
            }
        }
        private void SetCurrentDateToMaskedTextBox(MaskedTextBox maskedTextBox)
        {
            DateTime currentDate = DateTime.Now;
            maskedTextBox.Text = currentDate.ToString("dd/MM/yyyy");
        }

        public void EnableKhachHang(bool enable)
        {
            tb_tenKH.Enabled = enable;
            tb_sdtKH.Enabled = enable;
            tb_diachiKH.Enabled = enable;
            tb_ngaySinh.Enabled = enable;
            cb_doiTuong.Enabled = enable;
            tb_maSoThue.Enabled = enable;
            rb_nam.Enabled = enable;
            rb_nu.Enabled = enable;
        }

        public void ClearValueKhachHang()
        {
            tb_tenKH.Text = "";
            tb_sdtKH.Text = "";
            tb_diachiKH.Text = "";
            tb_ngaySinh.Text = "";
            cb_doiTuong.Text = "";
            tb_maSoThue.Text = "";
            rb_nam.Checked = false;
            rb_nu.Checked = false;
        }

        private bool IsNumeric(string text)
        {
            return double.TryParse(text, out _);
        }

        public class Thuoc
        {
            public string sMaThuoc { get; set; }
            public string sMaLoaiThuoc { get; set; }
            public string sTenThuoc { get; set; }
            public string sMaNCC { get; set; }
            public string sNoiSX { get; set; }
            public string iSoLuong { get; set; }
            public string dHanSD { get; set; }
            public string fDonGia { get; set; }
            public string fDonGiaBanLe { get; set; }
            public string sDonViBan { get; set; }
            public string sDonViBanLe { get; set; }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (!CheckValue())
            {
                return;
            }

            InsertHoaDonXuat();
            InsertChiTietDonXuat();
            InsertKhachHangIfNotExist();

            GetChiTietDonXuatWithThuocBySoHD();

        }

        public bool CheckValue()
        {
            if (!IsNumeric(tb_donGia.Text) || !IsNumeric(tb_soLuong.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(cb_maNV.Text))
            {
                errorProvider.SetError(cb_maNV, "Vui lòng chọn!");
                return false;
            }
            if (string.IsNullOrEmpty(cb_maThuoc.Text))
            {
                errorProvider.SetError(cb_maThuoc, "Vui lòng chọn!");
                return false;
            }

            if (string.IsNullOrEmpty(tb_soHoaDon.Text))
            {
                errorProvider.SetError(tb_soHoaDon, "Không được để trống!");
                return false;
            }

            string maKHCurrent = cb_maKH.Text;
            if (string.IsNullOrEmpty(maKHCurrent))
            {
                errorProvider.SetError(cb_maKH, "Không được để trống!");
                return false;
            }

            return true;
        }
        public void InsertHoaDonXuat()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand("SELECT * FROM tblHoaDonXuat", conn);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    DataTable tblThuoc = new DataTable();
                    adapter.Fill(tblThuoc);

                    // Assuming input validation before inserting

                    DataRow newRow = tblThuoc.NewRow();
                    newRow["sSoHD"] = tb_soHoaDon.Text;
                    newRow["sMaKH"] = cb_maKH.Text;
                    newRow["sMaNV"] = maNVCurrent;
                    newRow["gTongGiaBan"] = 0;
                    newRow["dNgayBan"] = tb_ngayBan.Text;


                    tblThuoc.Rows.Add(newRow);

                    adapter.InsertCommand = new SqlCommand("InsertHoaDonXuat", conn);
                    adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@sSoHD", SqlDbType.NVarChar, 10, "sSoHD"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@sMaKH", SqlDbType.NVarChar, 50, "sMaKH"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@sMaNV", SqlDbType.NVarChar, 50, "sMaNV"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@gTongGiaBan", SqlDbType.Float, 15, "gTongGiaBan"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@dNgayBan", SqlDbType.Date, 50, "dNgayBan"));

                    int rowsAffected = adapter.Update(tblThuoc);


                }

            }
            catch (Exception ex)
            {
                string strError = ex.Message;
                MessageBox.Show(strError);

            }
        }

        public void InsertChiTietDonXuat()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand("SELECT * FROM tblChiTietDonXuat", conn);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    DataTable tblThuoc = new DataTable();
                    adapter.Fill(tblThuoc);

                    // Assuming input validation before inserting

                    DataRow newRow = tblThuoc.NewRow();
                    newRow["sID"] = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                    newRow["sMaThuoc"] = cb_maThuoc.Text;
                    newRow["iSoLuongThuoc"] = tb_soLuong.Text;
                    newRow["fDonGia"] = tb_donGia.Text;
                    newRow["bHinhThucBan"] = hinhThucBan;
                    newRow["sSoHD"] = tb_soHoaDon.Text;


                    tblThuoc.Rows.Add(newRow);

                    adapter.InsertCommand = new SqlCommand("InsertChiTietDonXuat", conn);
                    adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@sID", SqlDbType.VarChar, 20, "sID"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@sMaThuoc", SqlDbType.NVarChar, 10, "sMaThuoc"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@iSoLuongThuoc", SqlDbType.Int, 50, "iSoLuongThuoc"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@fDonGia", SqlDbType.Float, 15, "fDonGia"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@bHinhThucBan", SqlDbType.Bit, 10, "bHinhThucBan"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@sSoHD", SqlDbType.VarChar, 15, "sSoHD"));
                    int rowsAffected = adapter.Update(tblThuoc);

                }

            }
            catch (Exception ex)
            {
                string strError = ex.Message;
                MessageBox.Show(strError);

            }
        }

        public void InsertKhachHangIfNotExist()
        {
            try
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
                    newRow["sMaKH"] = cb_maKH.Text;
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

                }
            }
            catch (Exception ex)
            {
                string strError = ex.Message;
                MessageBox.Show(strError);

            }
        }

        private void cb_maNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            maNVCurrent = selectedItem.Value;
        }

        private void GetChiTietDonXuatWithThuocBySoHD()
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        string querySelect = "GetChiTietDonXuatWithThuocBySoHD";
                        cmd.CommandText = querySelect;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sSoHD", tb_soHoaDon.Text);
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                adapter.Fill(dt);
                                if (dt.Rows.Count > 0)
                                {

                                    dt.Columns.Add("sDonViBanValue", typeof(string));
                                    foreach (DataRow row in dt.Rows)
                                    {
                                        if (Convert.ToBoolean(row["bHinhThucBan"]))
                                        {
                                            row["sDonViBanValue"] = row["sDonViBan"];
                                        }
                                        else
                                        {
                                            row["sDonViBanValue"] = row["sDonViBanLe"];
                                        }

                                    }

                                    dv = dt.DefaultView;
                                    dgv_HoaDon.AutoGenerateColumns = false;
                                    dgv_HoaDon.DataSource = dv;
                                }

                            }
                        }
                    }

                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        string querySelect = "GetKhachHangBySoHD";
                        cmd.CommandText = querySelect;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sSoHD", tb_soHoaDon.Text);
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                adapter.Fill(dt);
                                if (dt.Rows.Count > 0)
                                {
                                    var row = dt.Rows[0];
                                    cb_maKH.Text = row["sMaKH"].ToString();
                                    tb_tenKH.Text = row["sHoTen"].ToString();
                                    tb_sdtKH.Text = row["sSDT"].ToString();
                                    tb_diachiKH.Text = row["sDiachi"].ToString();
                                    tb_ngaySinh.Text = row["dNgaySinh"].ToString();
                                    cb_doiTuong.Text = row["sKieuDoiTuong"].ToString();
                                    tb_maSoThue.Text = row["sMaSoThue"].ToString();
                                    if (Convert.ToBoolean(row["bGioiTinh"]))
                                    {
                                        rb_nam.Checked = true;
                                        rb_nu.Checked = false;
                                    }
                                    else
                                    {
                                        rb_nam.Checked = false;
                                        rb_nu.Checked = true;
                                    }
                                    EnableKhachHang(false);


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

        private void btn_tim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_soHoaDon.Text))
            {
                errorProvider.SetError(tb_soHoaDon, "Không để trống!");
                MessageBox.Show("Vui lòng nhập số hóa đơn để tìm kiếm!");
                return;
            }
            else
            {
                GetChiTietDonXuatWithThuocBySoHD();
            }
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            dgv_HoaDon.DataSource = null;
            EnableKhachHang(true);
            tb_soHoaDon.Text = "";
            SetCurrentDateToMaskedTextBox(tb_ngayBan);
            cb_maNV.Text = "";
            cb_maThuoc.Text = "";
            cb_maThuoc.SelectedIndex = -1;
            tb_tenThuoc.Text = "";
            cb_hinhThucBan.Text = "";
            tb_donViBan.Text = "";
            tb_donGia.Text = "";
            tb_soLuong.Text = "";
            cb_maKH.Text = "";
            tb_tenKH.Text = "";
            tb_sdtKH.Text = "";
            tb_diachiKH.Text = "";
            tb_ngaySinh.Text = "";
            cb_doiTuong.Text = "";
            tb_maSoThue.Text = "";
            rb_nam.Checked = false;
            rb_nu.Checked = false;
        }

        private void btn_xoaSP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maChiTietHoaDon))
            {
                MessageBox.Show("Chọn bản ghi cần xóa!");
                return;
            }
            int index = dgv_HoaDon.CurrentRow.Index;
            try
            {
                DialogResult dialogResult = MessageBox.Show($"Có chắc muốn xóa {tb_tenThuoc.Text} không ?",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    dv.Delete(index);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string queryDelete = "DeleteChiTietDonXuatById";
                        using (SqlCommand cmd = new SqlCommand(queryDelete, conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@sID", maChiTietHoaDon);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show($"Xóa thành công!");
                        }
                        cb_maThuoc.SelectedIndex = -1;
                        tb_tenThuoc.Text = "";
                        cb_hinhThucBan.Text = "";
                        tb_donViBan.Text = "";
                        tb_donGia.Text = "";
                        tb_soLuong.Text = "";
                        GetChiTietDonXuatWithThuocBySoHD();
                    }

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

        private void btn_xoaHD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_soHoaDon.Text))
            {
                MessageBox.Show("Nhập số hóa đơn cần xóa!");
                return;
            }
            try
            {
                DialogResult dialogResult = MessageBox.Show("Có chắc muốn xóa hóa đơn với mã '" + tb_soHoaDon.Text + "' không ?",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string queryDelete = "DeleteHoaDonXuatAndDetailsBySoHD";
                        using (SqlCommand cmd = new SqlCommand(queryDelete, conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@sSoHD", tb_soHoaDon.Text);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show($"Xóa thành công!");
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

        private void dgv_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_HoaDon.CurrentRow.Index;
            maChiTietHoaDon = dv[index]["sID"].ToString();
            cb_maThuoc.Text = dv[index]["sMaThuoc"].ToString();
            tb_tenThuoc.Text = dv[index]["sTenThuoc"].ToString();

            tb_donViBan.Text = dv[index]["sDonViBanValue"].ToString();
            tb_donGia.Text = dv[index]["fDonGia"].ToString();
            tb_soLuong.Text = dv[index]["iSoLuongThuoc"].ToString();

            if ((bool)(dv[index]["bHinhThucBan"]) == true)
            {
                cb_hinhThucBan.Text = "Bán nguyên";
            }
            else
            {
                cb_hinhThucBan.Text = "Bán lẻ";
            }

        }

        private void btn_inHoaDon_Click(object sender, EventArgs e)
        {
            string reportFilter = string.Empty;
            //reportFilter = "NOT(ISNULL({GetAllKhachHang.sMaSV}))";
            //if(!string.IsNullOrEmpty(reportFilter))
            //{

            //}
            if (!string.IsNullOrEmpty(tb_soHoaDon.Text))
            {
                FormInHoaDon formInHD = new FormInHoaDon();
                formInHD.Show();
                formInHD.ShowReport("HoaDonXuat.rpt", "XuatHoaDonBySoHD", tb_soHoaDon.Text);
            }
            else
            {
                MessageBox.Show("Không có thông tin hóa đơn cần xuất!");
                errorProvider.SetError(tb_soHoaDon, "Nhập số hóa đơn");
            }
        }
    }
}
