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
    public partial class FormTimKiem : Form    
    {
        private string columnName;
        private TimKiem timKiem;
        public FormTimKiem()
        {
            InitializeComponent();
        }
        public void Initialize(string columnName, TimKiem timKiem)
        {
            this.columnName = columnName;
            this.timKiem = timKiem;
        }
        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            string searchValue = tb_tk.Text;
            timKiem?.SearchInDataGridView(columnName, searchValue);
            this.Close();
        }

        private void TimKiemCTHDN_Load(object sender, EventArgs e)
        {
            lb_tentimkiem.Text = "Tìm kiếm theo " + columnName;
        }
    }
}
