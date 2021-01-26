using DevExpress.XtraReports.UI;
using QuanAo.Data;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanAo
{
    public partial class DanhSachBan : DevExpress.XtraEditors.XtraUserControl
    {
        private int TenBan = 0;
        public DanhSachBan()
        {
            InitializeComponent();
            loadForm();
            loadBan();
        }
        // load bàn ăn lên form khi mở form
        public void loadBan()
        {
            DS_Ban.Controls.Clear();
            // lấy data lên bảng datatable
            DataTable dsBan = dataProvider.GetDataTable("exec GetDSBan");
            //add các button với thông tin của bàn vào form, set màu cho các bàn đã có ng và chưa có ng
            foreach (DataRow item in dsBan.Rows)
            {
                // set độ lớn cho button
                Button btn = new Button() { Width = 160, Height = 115 };
                // hiển thị thông tin bàn từ csdl lên button
                btn.Text = "Bàn " + item["TenBan"] + " ( " + item["SoGhe"] + " ghế )" + Environment.NewLine + item["TrangThai"];
                //gắn tag để xđ id bàn
                btn.Tag = item["TenBan"];
                // thêm sự kiện click button
                btn.Click += btn_Click;
                // set màu cho bàn trống
                if (item["TrangThai"].ToString() == "Trống")
                {
                    btn.BackColor = Color.Aqua;
                }
                // màu cho bàn có ng
                else
                {
                    
                    btn.BackColor = Color.OliveDrab;
                }
                
                DS_Ban.Controls.Add(btn);
            }

        }
        // load form lên và đưa các dữ liệu vào combobox
        private void loadForm()
        {
            //load danh mục lên
            CBDanhMuc.DataSource = dataProvider.GetDataTable("exec GetDanhMuc");
            CBDanhMuc.DisplayMember = "Ten";
            CBDanhMuc.ValueMember = "id_DanhMuc";
            // load luôn những món trong danh mục đầu tiên
            CBMon.DataSource = dataProvider.GetDataTable("exec GetMon '" + CBDanhMuc.SelectedValue + "'");
            CBMon.DisplayMember = "Ten";
            CBMon.ValueMember = "id_ThucPham";
            // load bàn chuyển lên combobox
            
            cbBan.DataSource = dataProvider.GetDataTable("exec GetDSBan");
            cbBan.DisplayMember = "TenBan";
            cbBan.ValueMember = "TenBan";
            ChiTietBan.Enabled = false;
        }
        // load bill lên 
       private void loadBill(int idBan)
        {
            listBillInfo.Items.Clear();
            // lấy thông tin hóa đơn từ csdl lên
            DataTable data = dataProvider.GetDataTable("exec GetBillInfo " + idBan.ToString());
            int i = 0;
            // khởi tạo biến tính tổng giá tiền của hóa đơn
            float tongGia = 0;
            foreach (DataRow item in data.Rows)
            {
                listBillInfo.Items.Add(item["Ten"].ToString());
                listBillInfo.Items[i].SubItems.Add(item["SoLuong"].ToString());
                listBillInfo.Items[i].SubItems.Add(item["Gia"].ToString());
                listBillInfo.Items[i].SubItems.Add(item["TongGia"].ToString());
                tongGia += Convert.ToInt64(item["TongGia"]);
                i++;
            }
            lb_TongGia.Text = tongGia.ToString("c") + " VND";
        }
        // sự kiện khi click vào 1 btn bàn nào đó
        private void btn_Click(object sender, EventArgs e)
        {
            // xóa bảng danh sách các món của bàn đã click trước đó
            listBillInfo.Items.Clear();
            // lấy id bàn từ tag ra
            int id_Ban = Convert.ToInt32((sender as Button).Tag);
            // gắn tag cho listbillinfor tag của bàn hiện tại mỗi khi click vào bàn nào đó
            listBillInfo.Tag = (sender as Button).Tag;
            //load bill lên
            loadBill(id_Ban);
            SoBan.Text = "Bàn " + (sender as Button).Tag.ToString();
            TenBan =Convert.ToInt32((sender as Button).Tag);
            ChiTietBan.Enabled = true;

            
            

        }

        private void CBDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBMon.DataSource = dataProvider.GetDataTable("exec GetMon '" + CBDanhMuc.SelectedValue + "'");
            CBMon.DisplayMember = "Ten";
            CBMon.ValueMember = "id_ThucPham";
        }
        
        // check bàn đó đã có bill chưa? nếu chưa có thì tạo
        //nếu bàn đã có hóa đơn thì trả về true còn chưa thì trả về false
       private int checkBillTable( int id_Ban)
        {
            int BanCheck = 0;
            BanCheck  =Convert.ToInt32(dataProvider.ExcScalar("exec CheckTable " + id_Ban.ToString()));
            return BanCheck;
        }
        // khi click vào button thêm món
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // kiểm tra số lượng được thêm vào có hợp lý hay không
            if (SL_Mon.Value <= 0 )
            {
                MessageBox.Show("chọn số lượng đồ ăn !!!");
            }
            // nếu đúng số lượng rồi thì check bill
            else
            {
                int id_ban =Convert.ToInt32( listBillInfo.Tag);
                int id_HDBan = checkBillTable(id_ban);
                // nếu bill chưa tồn tại và bàn đó trống
                if (id_HDBan == 0)
                {
                    // thêm vào hóa đơn mới
                    dataProvider.exc("exec insertHoaDon");
                    // lấy id hóa đơn vừa thêm vào
                    string id_HoaDon = "HD" + dataProvider.ExcScalar("exec MaxIdHoaDon").ToString();
                    // thêm hóa đơn bàn theo hóa đơn vừa thêm vào
                    dataProvider.exc("exec InsertHoaDonBan '" + id_HoaDon + "'," + id_ban.ToString());
                    // lấy hóa đơn bàn vừa thêm vào
                    string id_HoaDonBan = dataProvider.ExcScalar("exec MaxIdHDBan").ToString();
                    // thêm chi tiết hóa đơn mới vào
                    dataProvider.exc("exec InsertChiTietHoaDon " + id_HoaDonBan + "," + CBMon.SelectedValue + "," + SL_Mon.Value.ToString());
                    loadBan();
                    loadBill(id_ban);
                }
                // khi bàn đã có hóa đơn từ trước chưa thanh toán
                else
                {
                    // thêm luôn vào bàn có hóa đơn đã có từ trước
                    dataProvider.exc("exec InsertChiTietHoaDon " + id_HDBan + "," + CBMon.SelectedValue + "," + SL_Mon.Value.ToString());
                    loadBan();
                    loadBill(id_ban);
                }
            }
        }

        
        // click button chuyển bàn 1 qua bàn 2
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            int CheckBan1 = checkBillTable(TenBan);
            int CheckBan2 = checkBillTable(Convert.ToInt32(cbBan.SelectedValue));
            // kiểm tra nếu bàn muốn chuyển chưa có món gì thì thôi không cần chuyển nữa
            if(CheckBan1 != 0)
            {
                // trường hợp bàn 2 chưa có hóa đơn bàn 
                if(CheckBan2 == 0)
                {
                    // thêm vào hóa đơn mới
                    dataProvider.exc("exec insertHoaDon");
                    // lấy id hóa đơn vừa thêm vào
                    string id_HoaDon = "HD" + dataProvider.ExcScalar("exec MaxIdHoaDon").ToString();
                    // thêm hóa đơn bàn theo hóa đơn vừa thêm vào
                    dataProvider.exc("exec InsertHoaDonBan '" + id_HoaDon + "'," + cbBan.SelectedValue.ToString());
                    // lấy hóa đơn bàn vừa thêm vào
                    string id_HoaDonBan2 = dataProvider.ExcScalar("exec MaxIdHDBan").ToString();
                    // và chuyển bàn
                    dataProvider.exc("exec ChuyenBan " + CheckBan1.ToString() + "," + id_HoaDonBan2.ToString());
                    loadBan();
                    listBillInfo.Items.Clear();

                }
                //trường hợp bàn 2 đã có hóa đơn bàn
                else
                {
                    dataProvider.exc("exec ChuyenBan " + CheckBan1.ToString() + "," + CheckBan2.ToString());
                    loadBan();
                    listBillInfo.Items.Clear();
                }
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            string id_HD = dataProvider.ExcScalar("exec GetIdHDTheoSoBan " + TenBan.ToString()).ToString();
            dataProvider.exc("exec ThanhToan '" + id_HD + "'," + numKM.Value.ToString());
            DataTable data = dataProvider.GetDataTable("exec ReportHoaDon '"+id_HD+"'");
            HoaDonThanhToan TT = new HoaDonThanhToan();
            TT.DataSource = data;
            TT.ShowPreviewDialog();
            loadBan();
            listBillInfo.Items.Clear();
        }
    }
}
