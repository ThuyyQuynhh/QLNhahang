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

namespace QuanAo
{
    public partial class Thongkenhapkho : DevExpress.XtraEditors.XtraUserControl
    {
        public Thongkenhapkho()
        {
            InitializeComponent();
            loadForm();
        }
        private void loadForm()
        {
            cmbtennguyenlieu.DataSource = dataProvider.GetDataTable("exec GetNguyenLieu");
            cmbtennguyenlieu.DisplayMember = "TenNL";
            cmbtennguyenlieu.ValueMember = "id_NguyenLieu";
        }

        dataProvider dataProvider = new dataProvider();
        public int chon = 0;
        private void raBtnthoigian_CheckedChanged(object sender, EventArgs e)//chon thong ke theo thoi gian
        {
            raBtnchonngay.Enabled = true;
            rabtnchonthang.Enabled = true;
            raBtnchonnam.Enabled = true;
            raBtnTP.Enabled = false;
            cmbtennguyenlieu.Enabled = false;
        }

        private void raBtnthucpham_CheckedChanged(object sender, EventArgs e)//chon thong ke theo nguyen lieu
        {
            raBtnchonngay.Enabled = false;
            rabtnchonthang.Enabled = false;
            raBtnchonnam.Enabled = false;
            cmbChonthang.Enabled = false;
            cbmChonnam.Enabled = false;
            dtpChonngay.Enabled = false;
        
            raBtnTP.Enabled = true;
            cmbtennguyenlieu.Enabled = true;
            chon = 3;
        }

        private void raBtnchonngay_CheckedChanged(object sender, EventArgs e)//neu chon ngay
        {
            cmbChonthang.Enabled = false;
            cbmChonnam.Enabled = false;
            dtpChonngay.Enabled = true;
            chon = 0;
        }

        private void rabtnchonthang_CheckedChanged(object sender, EventArgs e)//neu chon thang
        {
            dtpChonngay.Enabled = false;
            cmbChonthang.Enabled = true;
            cbmChonnam.Enabled = true;
            chon = 1;
        }

        private void raBtnchonnam_CheckedChanged(object sender, EventArgs e)//neu chon nam
        {
            dtpChonngay.Enabled = false;
            cmbChonthang.Enabled = false;
            cbmChonnam.Enabled = true;
            chon = 2;
        }

        private void btnThongke_Click(object sender, EventArgs e)//chon thong ke
        {
            //su dung swich case nhung quen
            if (chon == 0)
            {
                dtgvNhapkho.DataSource = dataProvider.GetDataTable("exec thongke_nguyenlieungay '" + dtpChonngay.Value+"'");
               
            }
            if(chon == 1)
            {
                dtgvNhapkho.DataSource = dataProvider.GetDataTable("exec thongke_nguyenlieuthang '" + cmbChonthang.Text+"','" + cbmChonnam.Text+"'");
                
            }
            if(chon == 2)
            {
                dtgvNhapkho.DataSource = dataProvider.GetDataTable("exec thongke_nguyenlieunam '" + cbmChonnam.Text+"'");
                
            }
            if(chon == 3)
            {
                dtgvNhapkho.DataSource = dataProvider.GetDataTable("exec thongke_nguyenlieuten '" + cmbtennguyenlieu.Text+"'");
            }
                    
        }

        private void cmbtennguyenlieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
