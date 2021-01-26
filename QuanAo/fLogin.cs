
using System;
using System.Data;
using System.Windows.Forms;
using QuanAo.Data;
namespace QuanAo
{
    public partial class fLogin : Form
    {

        private string user;
        private string pass;

        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
        public fLogin(string username, string password)
        {
            this.User = username;
            this.Pass = password;
        }



        public fLogin()
        {
            InitializeComponent();
            this.User = txbUserName.Text;
            this.Pass = txbPassWord.Text;
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void loadform()
        {
            DataTable data = dataProvider.GetDataTable("select * from NhanVien where id_NhanVien = 'NV00'");
            if(data.Rows.Count == 0)
            {
                dataProvider.exc("exec ThêmKHVaNVMacDinh");
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if (Login(userName, passWord))
            {
                loadform();
                this.Hide();
                home HOME = new home(userName, passWord);
                HOME.ShowDialog();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }

        }
        bool Login(string useName, string passWord)
        {

            return AccountDAO.Instance.Login(useName, passWord);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
