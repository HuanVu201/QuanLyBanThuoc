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
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
