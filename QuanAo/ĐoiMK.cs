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
    public partial class ĐoiMK : System.Windows.Forms.UserControl
    {
        string oldusername;

        private static ĐoiMK _instance;
        public static ĐoiMK Instance    // Giúp hiển thị trong form
        {
            get
            {
                if (_instance == null)
                    _instance = new ĐoiMK();
                return _instance;
            }
        }
        public ĐoiMK()
        {
            InitializeComponent();
        }

        private void ĐoiMK_Load(object sender, EventArgs e)
        {
            load();
        }

        //ham load thong tin
        private void load()
        {
            DataProvider provider = new DataProvider();
            DataTable table = provider.loadAccount();
            dgvResult.DataSource = table;
        }
        private void clear()
        {
            txtID.ResetText();
            txtUsername.ResetText();
            txtDisplayname.ResetText();
            txtPassword.ResetText();
        }

        private void dgvResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvResult.Rows[e.RowIndex];
                txtID.Text=row.Cells[0].Value.ToString();
                txtUsername.Text = row.Cells[1].Value.ToString();
                oldusername = row.Cells[1].Value.ToString();
                txtDisplayname.Text = row.Cells[2].Value.ToString();
                txtPassword.Text = row.Cells[3].Value.ToString();
            }
        }

        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }

        private void btnAdd_Click(object sender, EventArgs e) // Thêm tài khoản
        {
            try
            {
                string id = txtID.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                DataProvider provider = new DataProvider();
                provider.AddAccount(id,username,password);
                MessageBox.Show("Thêm thành công!\n Tài khoản " + username + " đã được thêm.", "Đã thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                clear();
            }
            catch
            {
                MessageBox.Show("Không thêm được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) // Xóa tài khoản
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc xóa tài khoản " + oldusername + " không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    //Nhan yes
                    string name = txtUsername.Text;
                    DataProvider provider = new DataProvider();
                    provider.DelAccount(name);
                    MessageBox.Show("Xóa thành công!\n Tài khoản " + name + " đã được xóa.", "Đã xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnEdit_Click(object sender, EventArgs e)  // Sửa tài khoản
        {
            try
            {
                string newid = txtID.Text;
                string newusername = txtUsername.Text;
                string newpassword = txtPassword.Text;
                DataProvider provider = new DataProvider();
                provider.UpdateAccount(newid ,newusername, newpassword,  oldusername);
                MessageBox.Show("Chỉnh sửa thành công!\n Tài khoản " + oldusername + " đã chỉnh sửa.", "Đã sửa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
