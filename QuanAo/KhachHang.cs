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
    public partial class KhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        public KhachHang()
        {
            InitializeComponent();
            loadForm();
        }
        private void loadForm()
        {
            DS_KH.DataSource = dataProvider.GetDataTable("exec GetKH");
            pn_ThongTin.Enabled = false;
        }

       
        private void btn_Them_Click(object sender, EventArgs e)
        {
            tx_HoTen.Text = "";
            DT_NgaySinh.Text = "";
            tx_SDT.Text = "";
            tx_DC.Text = "";
            cb_GioiTinh.Text = "";
            pn_ThongTin.Enabled = true;

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(tx_HoTen.Text == "" ||DT_NgaySinh.Text == "" ||tx_SDT.Text == ""||tx_DC.Text == ""|| cb_GioiTinh.Text == "")
            {
                MessageBox.Show(" điền đầy đủ thông tin khách hàng");
            }
            else
            {
                string HoTen = tx_HoTen.Text;
                string ngay, thang;
                if (DT_NgaySinh.Value.Day < 10)
                {
                    ngay = "0" + DT_NgaySinh.Value.Day.ToString();
                }
                else
                {
                    ngay = DT_NgaySinh.Value.Day.ToString();
                }
                if(DT_NgaySinh.Value.Month < 10)
                {
                    thang = "0" + DT_NgaySinh.Value.Month.ToString();
                }
                else{
                    thang = DT_NgaySinh.Value.Month.ToString();
                }
                string NgaySinh = DT_NgaySinh.Value.Year.ToString() + thang + ngay;
                string SDT = tx_SDT.Text;
                string DiaChi = tx_DC.Text;
                string GioiTinh = tx_DC.Text;
                dataProvider.exc("exec ThemKH N'" + HoTen + "','" + NgaySinh + "','" + SDT + "',N'" + DiaChi + "',N'" + GioiTinh + "'");
                MessageBox.Show("Đã thêm thông tin khách hàng thành công!!!");
                loadForm();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            int index = DS_KH.CurrentRow.Index;
            string MaKH = DS_KH.Rows[index].Cells["id_KhachHang"].Value.ToString();

            
        }
    }
}
