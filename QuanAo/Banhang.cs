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
    public partial class Banhang : DevExpress.XtraEditors.XtraUserControl
    {
        public Banhang()
        {
            InitializeComponent();
        }
        dataProvider dataProvider = new dataProvider();//tạo mới một đối tượng lớp kết nối

        private string mahd;                // lưu tạm mã hóa đơn khi tạo hóa đơn mới, sẽ quyết định có ghi ra database không sau


        // load các dữ liệu ban đầu khi form được load lên
        private void Banhang_Load(object sender, EventArgs e)
        {
            //load ngày bán là ngày đăng nhập
            txNgayNhap.Text = DateTime.Now.ToString();  
            // load danh mục lên combobox các danh mục tìm kiếm
            string query = "SELECT * FROM DanhMuc";
            CBSP.DataSource = dataProvider.GetDataTable(query);
            // hiển thị ra tên các danh mục
            CBSP.DisplayMember = "TenDM";
            // giá trị của mỗi tên danh mục sẽ được đại diện bằng value của danh mục đó là MaDm
            CBSP.ValueMember = "MaDM";
            // load các tên nhân viên trong công ty lên combobox nhân viên
            string query1 = "select * from NhanVien";
            CBNV.DataSource = dataProvider.GetDataTable(query1);
            CBNV.DisplayMember = "TenNV";
            CBNV.ValueMember = "MaNV";
            // load sản phẩm lên datatimkiem trước khi tìm kiếm lần đầu tiên
            string query3 = "select MaSP, TenSP , ThuongHieu,Donvi,Gia ,Ton from SanPham";
            dataTimKiem.DataSource = dataProvider.GetDataTable(query3);
            // gán mã hóa đơn để thao tác sau
            mahd = "HD" +( dataProvider.GetDataTable("select * from HoaDon").Rows.Count + 1).ToString();
            txMaHD.Text = mahd;                 // gán mặc định mã hóa đơn cho text MaHd và không sửa được
        }

     

      

      
        // click vào button làm mới hóa đơn
        private void BTLamMoi_Click_1(object sender, EventArgs e)
        {
            // set các text và về null để nhập lại
            
            txSDT.Text = "";
            numSoLuong.Value = 0;
            numKhuyenMai.Value = 0;
            txNgayNhap.Text = "";
            // duyệt bảng các sản phẩm đã được chọn để thanh toán trả về cho kho
            for(int  i = 0 ; i < dataSP.Rows.Count -1; i++)
            {
                // update số lượng sản phẩm còn tồn trong kho
                string queryupdate = "update SanPham set Ton =Ton +" + dataSP.Rows[i].Cells[5].Value.ToString() + "where MaSP = '" + dataSP.Rows[i].Cells[0].Value.ToString() + "' select MaSP, TenSP , ThuongHieu,Donvi,Gia ,Ton from SanPham";
                dataTimKiem.DataSource = dataProvider.GetDataTable(queryupdate);
            }
            // load lại bảng dữ liệu tìm kiếm để cập nhật số lượng mới
            dataTimKiem.DataSource = dataProvider.GetDataTable("select MaSP, TenSP , ThuongHieu,Donvi,Gia,Ton from SanPham");
            dataSP.Rows.Clear();

        }
        // sự kiện khi chọn vào 1 thuộc tính nào đó trong combobox loại sản phẩm
        private void CBSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBSP.SelectedValue.ToString() == "DMALL")
            {
                // set tên sản phẩm về null
                txTenSP.Text = "";
                // tìm kiếm các sản phẩm phù hợp với điều kiện
                string query = "select MaSP, TenSP , ThuongHieu,Donvi,Gia,Ton from SanPham  ";
                DataTable data = dataProvider.GetDataTable(query);
                // load lại data lên bảng tìm kiếm
                dataTimKiem.DataSource = data;
            }
            else
            {
                // set tên sản phẩm về null
                txTenSP.Text = "";
                // tìm kiếm các sản phẩm phù hợp với điều kiện
                string query = "select MaSP, TenSP ,ThuongHieu,Donvi,Gia,Ton from SanPham where MaDM = '" + CBSP.SelectedValue.ToString() + "'";
                DataTable data = dataProvider.GetDataTable(query);
                // load lại data lên bảng tìm kiếm
                dataTimKiem.DataSource = data;
            }
            
        }
        // click button tìm kiếm => tìm kiếm trong database các sản phẩm phù hợp
        private void TimKiem_Click(object sender, EventArgs e)
        {
            string query = "select MaSP, TenSP , ThuongHieu,Donvi,Gia,Ton from SanPham where TenSP like N'%" + txTenSP.Text.ToString() + "%'";
            DataTable data = dataProvider.GetDataTable(query);
            dataTimKiem.DataSource = data;
        }
        //sự kiện click vào 1 hàng trong datagridview tìm kiếm
        private void dataTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            // lưu index của hàng hiện tại ra biến i;
            int i;
            i = dataTimKiem.CurrentRow.Index;
            
            
            // cho phép nhận button thêm
            Them.Enabled = true;
            // không cho phép bấm button xóa
            Xoa.Enabled = false;
            

            
        }
       
        int TongGia()
        {
            int tong = 0;
            for(int  i = 0; i<dataSP.Rows.Count -1; i++)
            {
                tong += Convert.ToInt32(dataSP.Rows[i].Cells[4].Value) * Convert.ToInt32(dataSP.Rows[i].Cells[5].Value);
            }
            return tong;
        }
        // khi chọn 1 sản phẩm bên hóa đơn thì cho phép xóa và không cho phép thêm
        private void dataSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Them.Enabled = false;
            Xoa.Enabled = true;
            

        }
        
        // button thêm
        private void Them_Click_1(object sender, EventArgs e)
        {
            try
            {
                // lấy các dữ liệu của sản phẩm được chọn bên trường tìm kiếm, và lưu vào datatable data 
                int k;
                k = dataTimKiem.CurrentRow.Index;
                string masp = dataTimKiem.Rows[k].Cells[0].Value.ToString();
                string query = "select MaSP, TenSP , ThuongHieu,Donvi,Gia,Ton from SanPham where MaSP = '" + masp + "'";
                DataTable data = dataProvider.GetDataTable(query);
                // kiểm tra số lượng muốn mua có đủ không, không đủ thì đưa ra thông báo
                if (Convert.ToInt32(data.Rows[0][5]) < numSoLuong.Value)
                {
                    MessageBox.Show(" Số lượng không đủ ");
                }
                // nếu đủ sẽ thêm vào hóa đơn tạm
                else
                {
                    // gán các cột trong bảng hiển thị chi tiết hóa đơn bằng sản phẩm mới đưuọc chọn
                    string tensp = data.Rows[0][1].ToString();
                    string thuonghieu = data.Rows[0][2].ToString();
                    string donvi = data.Rows[0][3].ToString();
                    string gia = data.Rows[0][4].ToString();
                    // biến tìm chỉ số của sản phẩm nếu chọn mua sản phẩm đã bị trùng trong hóa đơn
                    int index = 0;

                    //chạy vòng for để ktra xem mã sp có trong bảng hay chưa
                    for (int i = 0; i < dataSP.Rows.Count - 1; i++)
                    {
                        // nếu có sản phẩm trong hóa đơn thì kết thúc vòng for, trả về chỉ số của sản phẩm trong hóa đơn
                        if (masp == dataSP.Rows[i].Cells[0].Value.ToString())
                        {

                            break;

                        }
                        index++;

                    }


                    // nếu chưa có trong bảng thanh toán thì add vào bảng
                    if (index == dataSP.RowCount - 1 && numSoLuong.Value > 0)
                    {
                        // thêm vào bảng thanh toán
                        dataSP.Rows.Add(masp, tensp, thuonghieu,donvi, gia, numSoLuong.Value);

                    }
                    // nếu đã có thì cộng thêm số lượng bên hóa đơn
                    else if (index < dataSP.RowCount - 1 && numSoLuong.Value > 0)
                    {

                        dataSP.Rows[index].Cells[5].Value = (Convert.ToInt32(dataSP.Rows[index].Cells[5].Value) + numSoLuong.Value).ToString();
                    }
                    // update lại số lượng trong kho
                    string queryupdate = "update SanPham set Ton = Ton -" + numSoLuong.Value.ToString() + "where MaSP = '" + dataTimKiem.Rows[k].Cells[0].Value.ToString() +"'" ;
                    dataProvider.exc(queryupdate);
                   // load sản phẩm lên datatimkiem trước khi tìm kiếm lần đầu tiên
                    string query3 = "select MaSP, TenSP , ThuongHieu,Donvi,Gia ,Ton from SanPham";
                    dataTimKiem.DataSource = dataProvider.GetDataTable(query3);

                }
                txTongGia.Text = TongGia().ToString();
                TienPhaiTra.Text = (TongGia() * (float)((100 - numKhuyenMai.Value) / 100)).ToString();
            }
            catch
            {

            }
            
        }

        
        // button thanh toán
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // nếu chưa có sản phẩm nào trong hóa đơn
            if(dataSP.RowCount == 1 || CBNV.Text =="" || txNgayNhap.Text == "")
            {
                MessageBox.Show("Chưa có sản phẩm để thanh toán hoặc chưa đủ thông tin hóa đơn");
            }
            // có sp để thanh toán
            else
            {
                // có thông tin khách hàng để thanh toán
                if (txTenKhachHang.Text != "")
                {
                    DataTable data = dataProvider.GetDataTable("select * from KhachHang where SDT = '" + txSDT.Text.ToString() + "'");
                    string queryHD = "insert into HoaDon values('" + txMaHD.Text.ToString() + "','" + CBNV.SelectedValue.ToString() + "','" + data.Rows[0][0].ToString() + "','" + Convert.ToDateTime(txNgayNhap.EditValue).ToString("yyyy-MM-dd") + "'," + TienPhaiTra.Text.ToString() + ","+numKhuyenMai.Value.ToString()+")";
                    dataProvider.exc(queryHD);
                    
                    for (int i = 0; i < dataSP.RowCount -1; i++)
                    {
                        string queryCTHD = "insert into ChiTiet values('"+txMaHD.Text.ToString()+"','"+dataSP.Rows[i].Cells[0].Value.ToString()+"','"+dataSP.Rows[i].Cells[5].Value.ToString()+"')";
                        dataProvider.exc(queryCTHD);
                        string queryBan = "update SanPham set Ban = Ban +" + dataSP.Rows[i].Cells[5].Value.ToString() + " where MaSP = '" + dataSP.Rows[i].Cells[0].Value.ToString()+"'";
                        dataProvider.exc(queryBan);

                    }
                    // in hóa đơn
                    ReportHD report = new ReportHD();


                    string query = "exec Report1 '" + txMaHD.Text.ToString() + "'";
                    DataTable dataHD = dataProvider.GetDataTable(query);
                    report.DataSource = dataHD;
                    report.ShowPreviewDialog();
                    // gán mã hóa đơn để thao tác sau
                    mahd = "HD" + (dataProvider.GetDataTable("select * from HoaDon").Rows.Count + 1).ToString();
                    txMaHD.Text = mahd;                 // gán mặc định mã hóa đơn cho text MaHd và không sửa được
                    txSDT.Text = "";
                    numSoLuong.Value = 0;
                    numKhuyenMai.Value = 0;
                    txNgayNhap.Text = "";
                    dataSP.Rows.Clear();

                    


                }
                else
                {
                    
                    string queryHD = "insert into HoaDon values('" + txMaHD.Text.ToString() + "','" + CBNV.SelectedValue.ToString() + "','NV00','" + Convert.ToDateTime(txNgayNhap.EditValue).ToString("yyyy-MM-dd") + "'," + TienPhaiTra.Text.ToString() + ","+numKhuyenMai.Value.ToString()+")";
                    dataProvider.exc(queryHD);

                    for (int i = 0; i < dataSP.RowCount - 1; i++)
                    {
                        string queryCTHD = "insert into ChiTiet values('" + txMaHD.Text.ToString() + "','" + dataSP.Rows[i].Cells[0].Value.ToString() + "','" + dataSP.Rows[i].Cells[5].Value.ToString() + "')";
                        dataProvider.exc(queryCTHD);
                        string queryBan = "update SanPham set Ban = Ban +" + dataSP.Rows[i].Cells[5].Value.ToString() + " where MaSP = '" + dataSP.Rows[i].Cells[0].Value.ToString()+"'";
                        dataProvider.exc(queryBan);

                    }
                    // in hóa đơn
                    ReportHD report = new ReportHD();
                    string query = "exec Report '" + txMaHD.Text.ToString() + "'";
                    DataTable dataHD = dataProvider.GetDataTable(query);
                    report.DataSource = dataHD;
                    report.ShowPreviewDialog();
                    // gán mã hóa đơn để thao tác sau
                    mahd = "HD" + (dataProvider.GetDataTable("select * from HoaDon").Rows.Count + 1).ToString();
                    txMaHD.Text = mahd;                 // gán mặc định mã hóa đơn cho text MaHd và không sửa được
                    txSDT.Text = "";
                    numSoLuong.Value = 0;
                    numKhuyenMai.Value = 0;
                    txNgayNhap.Text = "";
                    dataSP.Rows.Clear();
                    
                }
            }
            
            

        }
        //button tìm kiếm khách hàng
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = dataProvider.GetDataTable("Select * from KhachHang where SDT = '" + txSDT.Text.ToString() + "'");
                if (data.Rows.Count == 0)
                {
                    txTenKhachHang.Text = "";
                    AddKhachHang AddKH = new AddKhachHang();
                    AddKH.sdt = txSDT.Text.ToString();
                    AddKH.ShowDialog();
                    
                }
                else
                {
                    txTenKhachHang.Text = data.Rows[0][1].ToString();
                }
            }
            catch
            {

            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // button xóa sản phẩm ra khỏi bảng
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                // lấy chỉ số hiện tại của hàng đang click
                int i;
                i = dataSP.CurrentRow.Index;
                // update lại số lượng sp trong kho
                string queryupdate = "update SanPham set Ton =Ton +" + dataSP.Rows[i].Cells[5].Value.ToString() + "where MaSP = '" + dataSP.Rows[i].Cells[0].Value + "' select MaSP, TenSP , ThuongHieu,Donvi,Gia ,Ton from SanPham";
                dataTimKiem.DataSource = dataProvider.GetDataTable(queryupdate);
                // xóa hàng vừa chọn khỏi bảng data
                dataSP.Rows.Remove(dataSP.Rows[i]);
            }
            catch
            {

            }
            txTongGia.Text = TongGia().ToString();
            TienPhaiTra.Text = (TongGia() * (float)((100 - numKhuyenMai.Value) / 100)).ToString();
        }

       

        private void numKhuyenMai_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TienPhaiTra.Text = (TongGia() * (float)((100 - numKhuyenMai.Value) / 100)).ToString();
        }

        private void numKhuyenMai_ValueChanged(object sender, EventArgs e)
        {
            TienPhaiTra.Text = (TongGia() * (float)((100 - numKhuyenMai.Value) / 100)).ToString();

        }

        private void dataTimKiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TimKiem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
