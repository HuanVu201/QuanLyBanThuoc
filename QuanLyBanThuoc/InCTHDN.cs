using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
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
    public partial class InCTHDN : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QuanlyThuoc"].ConnectionString;
        public InCTHDN()
        {
            InitializeComponent();
        }
        public void ShowReportCTHDN(string tenBaoCao, string tenProc, string reportFilter)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = tenProc;
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                adapter.Fill(dt);

                                //Load du lieu len bao cao
                                ReportDocument report = new ReportDocument();
                                string path = string.Format("{0}\\BaoCao\\{1}", Application.StartupPath, tenBaoCao);
                                report.Load(path);

                                report.Database.Tables[tenProc].SetDataSource(dt);

                                report.SetParameterValue("sNguoiLapBieu", "Trần Quốc Trung");

                                //đặt điều kiện để lọc các bản ghi hiển thị lên báo cáo
                                if (reportFilter != null)
                                {
                                    report.RecordSelectionFormula = reportFilter;
                                }
                                crv_CTHDN.ReportSource = report;
                                crv_CTHDN.Refresh();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
