using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanAo.Data;
using DevExpress.XtraReports.UI;

namespace QuanAo
{
    public partial class Thongkehoadonkhachhang : DevExpress.XtraEditors.XtraUserControl
    {
        public Thongkehoadonkhachhang()
        {
            InitializeComponent();
        }
        dataProvider dataProvider = new dataProvider();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            dtgvlistKH.DataSource = dataProvider.GetDataTable("exec thongke_listKH '" + dtpTungay.Value+"','" + dtpDenngay.Value+"'");


        }

        private void dtgvlistKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnInhoadon.Enabled = true;
        }

        private void btnInhoadon_Click(object sender, EventArgs e)//in hoa don
        {
            int index = dtgvlistKH.CurrentRow.Index;
            string id_HD = dtgvlistKH.Rows[index].Cells["id_HoaDon"].Value.ToString();
            DataTable data = dataProvider.GetDataTable("exec ReportHoaDon '" + id_HD + "'");
            HoaDonThanhToan TT = new HoaDonThanhToan();
            TT.DataSource = data;
            TT.ShowPreviewDialog();
        }
    }
}
