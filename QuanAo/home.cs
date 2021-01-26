using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;
using QuanAo.Data;
namespace QuanAo
{
    public partial class home : DevExpress.XtraBars.Ribbon.RibbonForm//giải thích chỗ này
    {
        public string userName;
        public string pass;
        
        public home(string user, string pass)
        {
            this.userName = user;
            this.pass = pass;
            InitializeComponent();
          
            

        }
        // giao diện của sự kiện khi load form lên sẽ mặc định là office 2007 green
        private void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel def = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            def.LookAndFeel.SkinName = "Office 2007 Green";
        }
        // khi load form gọi tới skin() => để laod giao diện mặc định lên
        private void home_Load(object sender, EventArgs e)
        {
            TrangChu TC = new TrangChu();
            addpage(fr_main, "Trang chủ", TC);


            skin();
        }
        /* phương thức thêm 1 page vào xtratabcontrol 
            - xtratabcha: Tên của xtratabcontrol được dùng để thêm các tabpage con
            - tabname: Tên sẽ hiển thị ra của tabpage con
            - usetr: usercontrol được thêm vào cái page mới được tạo ra
         */
        public  void addpage(DevExpress.XtraTab.XtraTabControl xtratabCha , string tabNameAdd ,System.Windows.Forms.UserControl useCtr )    
        {
            int dem = 0;        // biến đếm tabpage trùng tên
            foreach(DevExpress.XtraTab.XtraTabPage tab in fr_main.TabPages)                 // chạy vòng lặp để ktra xem form muốn add vào đã có chưa
            {
                if(tab.Name == tabNameAdd)                                                  // nếu tên form mới đã có
                {                   
                    fr_main.SelectedTabPage = tab;                          // focus vào page muốn tạo nhưng đã tồn tại 
                    dem = 1;                                                // thay đổi biến đếm =1
                }

            }   
            // chạy xong vòng lặp, nếu dem = 1 = > page đã tồn tại, nếu dem !=1 => page chưa tồn tại nên sẽ addpage vào extratab
            if(dem != 1)
            {
                DevExpress.XtraTab.XtraTabPage TabAdd = new DevExpress.XtraTab.XtraTabPage();           // tạo ra page  để add usercontrol và sau đó add vào extratab
                TabAdd.Text = tabNameAdd;                       // gán tên của tabpage mới được tạo bằng tên mình muốn
                TabAdd.Name = tabNameAdd;                       // gán tên cho tabpage
                TabAdd.Controls.Add(useCtr);                    // add usercontrol vào tabpage vừa tạo ra
                useCtr.Dock = DockStyle.Fill;                   // fill cho nó đầy ra tabpage
                fr_main.TabPages.Add(TabAdd);                   // thêm tabpage vào xtratabcontrol 
                fr_main.SelectedTabPage = TabAdd;               // focus vào tabpage vừa được tạo ra
            }


           
        }

        // sự kiện khi click vào dấu x của page con trong xtratabcontrol
        private void fr_main_CloseButtonClick(object sender, EventArgs e)
        {// dong tab
            DevExpress.XtraTab.XtraTabControl tabControl = sender as DevExpress.XtraTab.XtraTabControl;
            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs arg = e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs;
            (arg.Page as DevExpress.XtraTab.XtraTabPage).Dispose();
            

            
        }
        // click vào button thêm món
        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            DanhSachBan DSB = new DanhSachBan();
            addpage(fr_main, "Thêm món", DSB);
        }
        // click vào button đặt bàn
        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            DatBan DB = new DatBan();
            addpage(fr_main, "Đặt bàn", DB);
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            Thongkedoanhthu DT = new Thongkedoanhthu();
            addpage(fr_main, "Thống kê doanh thu", DT);
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            Thongkehoadonkhachhang TKHD = new Thongkehoadonkhachhang();
            addpage(fr_main, "Thống kê hóa đơn", TKHD);
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            Thongkenhapkho NK = new Thongkenhapkho();
            addpage(fr_main, "Thống kê nhập kho", NK);
        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            KHO K = new KHO();
            addpage(fr_main, "Quản lý kho", K);
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            NhanVien NV = new NhanVien();
            addpage(fr_main, "Quản lý nhân viên", NV);
        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            ĐoiMK DMK = new ĐoiMK();
            addpage(fr_main, "Đổi mật khẩu", DMK);
        }

        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {
            NhanVien_HeThong NVHT = new NhanVien_HeThong();
            addpage(fr_main, "Nhân viên hệ thống", NVHT);
        }

        private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)
        {
            fLogin f = new fLogin();
            Sleep SL = new Sleep(userName, userName, pass);
            SL.ShowDialog();
        }

        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DanhSachBan DSB = new DanhSachBan();
            addpage(fr_main, "Thêm món", DSB);
        }

        private void navBarItem18_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DatBan DB = new DatBan();
            addpage(fr_main, "Đặt bàn", DB);
        }

        private void navBarItem14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Thongkenhapkho NK = new Thongkenhapkho();
            addpage(fr_main, "Thống kê nhập kho", NK);
        }

        private void navBarItem15_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Thongkehoadonkhachhang TKHD = new Thongkehoadonkhachhang();
            addpage(fr_main, "Thống kê hóa đơn", TKHD);
        }

        private void navBarItem16_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            NhanVien NV = new NhanVien();
            addpage(fr_main, "Quản lý nhân viên", NV);
        }

        private void fr_main_Click(object sender, EventArgs e)
        {

        }

        private void navBarItem17_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            KhachHang KH = new KhachHang();
            addpage(fr_main, "Khách hàng", KH);
        }
    }
}