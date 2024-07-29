using BTH3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanThuoc
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            this.Size = new Size(1300, 620);
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void formNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNV quanLyNV = new QuanLyNV();
            quanLyNV.MdiParent = this;
            quanLyNV.Show();
        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyThuoc quanLyThuoc = new QuanLyThuoc();
            quanLyThuoc.MdiParent = this;
            quanLyThuoc.Show();
        }
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chiTiếtHóaĐơnNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChiTietHoaDonNhap chiTietHoaDonNhap = new ChiTietHoaDonNhap();
            chiTietHoaDonNhap.MdiParent = this;
            chiTietHoaDonNhap.Show();
        }

        private void hóaĐơnNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HoaDonNhap hoaDonNhap = new HoaDonNhap();
            hoaDonNhap.MdiParent = this;
            hoaDonNhap.Show();
        }
    }
}
