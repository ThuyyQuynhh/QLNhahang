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
    public partial class Thongkedoanhthu : DevExpress.XtraEditors.XtraUserControl
    {
        public Thongkedoanhthu()
        {
            InitializeComponent();
        }
        dataProvider dataProvider = new dataProvider();
        public int chon = 0;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)//chon ngay
        {
            cmbchonthang.Enabled = false;
            cmbchonnam.Enabled = false;
            dtpChonngay.Enabled = true;
            chon = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void raBtnThang_CheckedChanged(object sender, EventArgs e)//chon thang
        {
            dtpChonngay.Enabled = false;
            cmbchonthang.Enabled = true;
            cmbchonnam.Enabled = true;
            chon = 1;
        }

        private void raBtnNam_CheckedChanged(object sender, EventArgs e)//chon nam
        {
            dtpChonngay.Enabled = false;
            cmbchonthang.Enabled = false;
            cmbchonnam.Enabled = true;
            chon = 2;
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            if (chon == 0)
            {
                string ngay ;
                if (dtpChonngay.Value.Day < 10)
                {
                    ngay = "0" + dtpChonngay.Value.Day.ToString();
                }
                else
                {
                    ngay =dtpChonngay.Value.Day.ToString();
                }
                string thang;
                if(dtpChonngay.Value.Month < 10)
                {
                    thang = "0" + dtpChonngay.Value.Month.ToString();
                }
                else
                {
                    thang = dtpChonngay.Value.Month.ToString();
                }

                dtgvdoanhthu.DataSource = dataProvider.GetDataTable("exec doanhthu_ngay '" + dtpChonngay.Value.Year.ToString() +thang+ngay+ "'");

                txtdoanhthu.Text = dataProvider.ExcScalar("exec tinhtong_dtngay '" + dtpChonngay.Value.Year.ToString() + thang + ngay + "'").ToString();
               
            }
            else if (chon == 1)
            {
                dtgvdoanhthu.DataSource = dataProvider.GetDataTable("exec doanhthu_thang '" + cmbchonthang.Text +"','"+ cmbchonnam.Text+"'");
                
                txtdoanhthu.Text = dataProvider.ExcScalar("exec tinhtong_dtthang '" + cmbchonthang.Text + "','" + cmbchonnam.Text + "'").ToString();
                
            }
            else if (chon == 2)
            {
                dtgvdoanhthu.DataSource = dataProvider.GetDataTable("exec doanhthu_nam '" + cmbchonnam.Text+"'");
               
                txtdoanhthu.Text = dataProvider.ExcScalar("exec tinhtong_dtnam '" + cmbchonnam.Text + "'").ToString();
               
            }
            
        }

        private void txtdoanhthu_TextChanged(object sender, EventArgs e)
        {

        }
    }

    
            
}

        
  

