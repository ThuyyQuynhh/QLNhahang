using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanAo.Data;

namespace QuanAo
{
    
    public partial class AddKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public AddKhachHang()
        {
            InitializeComponent();
        }
        dataProvider dataProvider = new dataProvider();
        public string sdt;
        //khi thực hiện bán hàng kiểm tra xem khách hàng đã đến mua chưa, nếu chưa và KH đồng ý thì Add_KH
        //nếu khách hàng k đồng ý thì để khách hàng là mặc định NV00 mua
        private void AddKhachHang_Load(object sender, EventArgs e)
        {
            DataTable data = dataProvider.GetDataTable("select * from KhachHang");
            txmakh.Text = "KH" + (data.Rows.Count+1).ToString();// mã khách hàng là số hàng vừa select tăng lên 1
            txsdt.Text = sdt.ToString();
        }
        // button hủy
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // button thêm khách hàng
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(txtenkh.Text =="" || txsdt.Text == "")
            {
                MessageBox.Show("Thông tin khách hàng chưa đầy đủ");
            }
            else
            {
                string query = "insert into KhachHang values('" + txmakh.Text.ToString() + "',N'" + txtenkh.Text.ToString() + "','" + sdt + "')";
                dataProvider.exc(query);//chạy nonexecute không xuất ra dữ liệu
                MessageBox.Show("Thêm khách hàng thành công");
                this.Close();
            }
        }
            

        private void txsdt_KeyPress(object sender, KeyPressEventArgs e)//chỉ cho phép nhập số ở textbox sdt
        {
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                    e.Handled = true;
           
        }
    }
}