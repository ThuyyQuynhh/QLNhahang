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

namespace QuanAo
{
    public partial class NhanVien_HeThong : DevExpress.XtraEditors.XtraUserControl
    {
        string oldusername;

        private static NhanVien_HeThong _instance;
        public static NhanVien_HeThong Instance    // Giúp hiển thị trong form
        {
            get
            {
                if (_instance == null)
                    _instance = new NhanVien_HeThong();
                return _instance;
            }
        }
        public NhanVien_HeThong()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            load();
        }

        //ham load thong tin
        private void load()
        {
            DataProvider provider = new DataProvider();
            DataTable table = provider.loadNhanVien();
            dgvResult.DataSource = table;
        }
        private void clear()
        {
            txtID.ResetText();
            txtUsername.ResetText();
            txtGT.ResetText();
            txtNS.ResetText();
            txtCV.ResetText();
            txtSĐT.ResetText();
            txtLuong.ResetText();
            txtKN.ResetText();
        }

        private void dgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvResult.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtUsername.Text = row.Cells[1].Value.ToString();
                oldusername = row.Cells[1].Value.ToString();
                txtGT.Text = row.Cells[2].Value.ToString();
                txtNS.Text = row.Cells[3].Value.ToString();
                txtCV.Text = row.Cells[4].Value.ToString();
                txtSĐT.Text = row.Cells[5].Value.ToString();
                txtLuong.Text = row.Cells[6].Value.ToString();
                txtKN.Text = row.Cells[7].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text;
                string username = txtUsername.Text;
                string gt = txtGT.Text;
                string ns = txtNS.Text;
                string cv = txtCV.Text;
                string sdt = txtSĐT.Text;
                string luong = txtLuong.Text;
                string kn = txtKN.Text;
                DataProvider provider = new DataProvider();
                provider.AddNhanVien(id, username, gt,ns,cv,sdt,luong,kn);
                MessageBox.Show("Thêm thành công!\n Nhân viên " + username + " đã được thêm.", "Đã thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                clear();
            }
            catch
            {
                MessageBox.Show("Không thêm được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) // Xóa một nhân viên
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc xóa nhân viên " + oldusername + " không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    //Nhan yes
                    string name = txtUsername.Text;
                    DataProvider provider = new DataProvider();
                    provider.DelNhanVien(name);
                    MessageBox.Show("Xóa thành công!\n Nhân viên " + name + " đã được xóa.", "Đã xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                    clear();
                }
                //nhan no
            }
            catch
            {
                MessageBox.Show("Không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)  // Sửa thông tin của một tài khoản
        {
            try
            {
                string id = txtID.Text;
                string username = txtUsername.Text;
                string gt = txtGT.Text;
                string ns = txtNS.Text;
                string cv = txtCV.Text;
                string sdt = txtSĐT.Text;
                string luong = txtLuong.Text;
                string kn = txtKN.Text;
                DataProvider provider = new DataProvider();
                provider.UpdateNhanVien(id,username,gt,ns,cv,sdt,luong,kn,oldusername);
                MessageBox.Show("Chỉnh sửa thành công!\n Nhân viên " + oldusername + " đã chỉnh sửa.", "Đã sửa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                clear();
            }
            catch
            {
                MessageBox.Show("Không sữa được!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
