using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanAo
{
    public partial class Sleep : Form
    {
        private string password;
        public Sleep()
        {
            InitializeComponent();
        }

        public Sleep(string user, string name, string pass) : this()
        {
            lblName.Text = name;
            password = pass;
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void check()
        {
            if (txtMatKhau.Text == password)
            {
                //nhap dung mat khaus
                this.Close();
            }
            else
            {
                txtMatKhau.Focus();
                pbErr.Visible = true;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            txtMatKhau.Focus();
        }

        private void Sleep_Leave(object sender, EventArgs e)
        {
            txtMatKhau.Focus();
        }

        private void Sleep_Load(object sender, EventArgs e)
        {

        }
    }
}
