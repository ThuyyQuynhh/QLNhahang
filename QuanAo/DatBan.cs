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
    public partial class DatBan : DevExpress.XtraEditors.XtraUserControl
    {
        private string id_KH = "";
        public DatBan()
        {
            InitializeComponent();
            loadForm();
        }
        private void loadForm()
        {
            lb_TenKH.Text = "";
            // load nhân viên thu ngân lên
            CBNhanVien.DataSource = dataProvider.GetDataTable("exec GetNhanVienThuNgan");
            CBNhanVien.DisplayMember = "HoTen";
            CBNhanVien.ValueMember = "id_NhanVien";
            // load bàn trống lên
            cbBan.DataSource = dataProvider.GetDataTable("exec GetDanhSachBanTrong");
            cbBan.DisplayMember = "TenBan";
            cbBan.ValueMember = "TenBan";
            // load hóa đon chưa thanh toán lên form
            DS_HD.DataSource = dataProvider.GetDataTable("exec GetHDChuaThanhToan");
            pn_ThongTin.Enabled = false;
            pn_ChucNang.Enabled = false;

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
        // khi clcik vào 1 trong các dòng của datagridview, khi chọn 1 hóa đơn chưa thanh toán
        private void DS_HD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int i = DS_HD.CurrentRow.Index;
            // hiển thị các thông tin hóa đơn
            string id_HD = DS_HD.Rows[i].Cells["id_HoaDon"].Value.ToString();
            HoaDonBan.DataSource = dataProvider.GetDataTable("exec GetBanCuaHD '" + id_HD + "'");
            lbid_HD.Text = id_HD;
            CBNhanVien.DisplayMember = DS_HD.Rows[i].Cells["Tên nhân viên"].Value.ToString();
            lb_TenKH.Text = DS_HD.Rows[i].Cells["Tên khách hàng"].Value.ToString();
            tx_SDT.Text = DS_HD.Rows[i].Cells["SDT"].Value.ToString();
            // cho phép thêm bàn mới hoặc xóa bàn
            pn_ChucNang.Enabled = true;
            pn_ThongTin.Enabled = false;
            

        }

        private void HoaDonBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // click vào button thêm mới
        private void btn_ThemBan_Click(object sender, EventArgs e)
        {
            // thêm hóa đơn bàn
            int i = DS_HD.CurrentRow.Index;
            string id_HD= DS_HD.Rows[i].Cells["id_HoaDon"].Value.ToString();
            int soBan = Convert.ToInt32(cbBan.SelectedValue);
            dataProvider.exc("exec InsertHoaDonBan '" + id_HD + "'," + soBan.ToString());
            // load lại bàn trống
            cbBan.DataSource = dataProvider.GetDataTable("exec GetDanhSachBanTrong");
            cbBan.DisplayMember = "TenBan";
            cbBan.ValueMember = "TenBan";
            // load lại datagridview các bàn thuộc hóa đơn
            HoaDonBan.DataSource = dataProvider.GetDataTable("exec GetBanCuaHD '" + id_HD + "'");

        }
        // click vào button xóa bàn 
        private void btn_XoaBan_Click(object sender, EventArgs e)
        {
            try
            {
                int i = DS_HD.CurrentRow.Index;
                int TongHD = Convert.ToInt32(DS_HD.Rows[i].Cells["TongGia"].Value);
                string id_HD = DS_HD.Rows[i].Cells["id_HoaDon"].Value.ToString();
                // bàn mới đặt và chưa gọi món có thể xóa đi được
                if (TongHD == 0)
                {
                    dataProvider.exc("exec XoaHoaDon '" + id_HD + "'");
                    loadForm();
                    HoaDonBan.DataSource = null;

                }
                // bàn đã gọi món thì k thể thanh toán được
                else
                {
                    MessageBox.Show("Bàn có người đang ăn không thể xóa !!!");
                }
            }
            catch{ };
            
        }
        // clivk button cập nhật lại dữ liệu
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            loadForm();
            HoaDonBan.DataSource = null;

        }

        private void HoaDonBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_ThemBan.Enabled = false;
            btn_XoaBan.Enabled = true;

        }
        // sự kiện thêm mới hóa đơn
        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            pn_ThongTin.Enabled = true;
            pn_ChucNang.Enabled = false;
            lbid_HD.Text = "";
            tx_SDT.Text = "";
            lb_TenKH.Text = "";
            HoaDonBan.DataSource = null;
            
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {

            DataTable data = dataProvider.GetDataTable("exec GetKHTheoSDT '" + tx_SDT.Text.ToString()+"'");
            // nếu có khách hàng đó trong database
            if (data.Rows.Count > 0)
            {
                lb_TenKH.Text = data.Rows[0]["HoTen"].ToString();
                id_KH = data.Rows[0]["id_KhachHang"].ToString();
            }
            // nếu chưa có yêu cầu tạo thông tin lưu trữ hoặc dùng khách hàng temp
            else
            {
                MessageBox.Show("Khách hàng chưa được đăng ký thông tin");
                tx_SDT.Text = "";
            }
        }
        // tạo hóa đơn đặt bàn trước
        private void btn_Tao_Click(object sender, EventArgs e)
        {
            // nếu dùng tên khách hàng temp
            if (lb_TenKH.Text == "")
            {
                dataProvider.exc("exec InsertHDDatTruoc '" + CBNhanVien.SelectedValue.ToString() + "','KH000'");
            
            }
            // nếu có thông tin khách hàng cụ thể
            else
            {
                dataProvider.exc("exec InsertHDDatTruoc '" + CBNhanVien.SelectedValue.ToString() + "','" + id_KH+"'");

            }
            // load lại hóa đơn chưa thanh toán lên bảng
            DS_HD.DataSource = dataProvider.GetDataTable("exec GetHDChuaThanhToan");

        }
    }
}
