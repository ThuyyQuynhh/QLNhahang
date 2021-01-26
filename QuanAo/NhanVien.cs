using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using QuanAo.Data;

namespace QuanAo
{
    public partial class NhanVien : System.Windows.Forms.UserControl
    {
        private string id_tab1;
        private string id_tab2;
        private string name;
        private string gt;
        private string ns;
        private string cv;
        private string phone;
        private string luog;
        private string kn;
        private DataTable table = dataProvider.GetDataTable("exec load_nv");
        public NhanVien()
        {
            InitializeComponent();
            clear_grid();
        }

        /// <summary>
        /// Chỉ là làm cho cái GridControl thành rỗng
        /// </summary>
        public void clear_grid()
        {
            ds_nv.DataSource = null;
            gridControl1.DataSource = dataProvider.GetDataTable("exec load_nv"); 
        }

        /// <summary>
        /// Load dữ liệu của tất cả nhân viên
        /// </summary>
        public void load_data()
        {
            clear_grid();
            //DataProvider2 data = new DataProvider2();
            //ds_nv.DataSource = data.LoadAll_NV();
            ds_nv.DataSource = dataProvider.GetDataTable("exec load_nv");
        }

        /// <summary>
        /// Hàm tạo ra mã nhân viên khi thêm 1 nhân viên mới
        /// </summary>
        /// <returns></returns>
        public string Create_IDNV()
        {
            string id_nv;
            int n = dataProvider.GetDataTable("exec load_nv").Rows.Count;
            string str = dataProvider.GetDataTable("exec load_nv").Rows[n-1][0].ToString();

            id_nv = str.Substring(2);
            int id = int.Parse(id_nv);
            if(id_nv[0] != '0' && id > 8)
            {
                id++;
                id_nv = "NV" + id.ToString();
            }
            else
            {
                id++;
                id_nv = "NV0" + id.ToString();
            }
            return id_nv;
        }

        /// <summary>
        /// Định dạng lại ngày sinh khi hiển thị cho đúng
        /// </summary>
        public string format_date(string str)
        {
            str = str.Split(' ')[0];
            string[] mini_str = str.Split('/');
            str = mini_str[2] + "-" + mini_str[1] + "-" + mini_str[0];
            return str;
        }

        
        /// <summary>
        /// Nút load danh sách nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            //load_data();
            ds_nv.DataSource = dataProvider.GetDataTable("exec load_nv");
        }
        
        /// <summary>
        /// Nút ẩn đi danh sách ( GridControl về rỗng )
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hide_Click_1(object sender, EventArgs e)
        {
            clear_grid();
        }

        /// <summary>
        /// Nút Thêm để bắt đầu nhập thông tin và thêm nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_Click_1(object sender, EventArgs e)
        {
            try
            {
                idNhanVien.Text = Create_IDNV();
                dataProvider.exc("exec add_nv " + "'" + idNhanVien.Text + "', N'" + hoten.Text + "', N'" + gioitinh.Text + "', '" + format_date(ngaysinh.Text) + "', N'" + chucvu.Text + "', '" + sdt.Text + "', " + float.Parse(luong.Text) + ", N'" + kynang.Text + "'");
                MessageBox.Show("Thêm thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
            }
            catch 
            {
                MessageBox.Show("Xảy ra lỗi khi thêm nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Nút Lưu để lưu lại nhân viên khi thêm mới hoặc sửa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save_Click_1(object sender, EventArgs e)
        {
            try
            {
                dataProvider.exc("exec edit_nv " + "'" + idNhanVien.Text + "', N'" + hoten.Text + "', N'" + gioitinh.Text + "', '" + format_date(ngaysinh.Text) + "', N'" + chucvu.Text + "', '" + sdt.Text + "', " + float.Parse(luong.Text) + ", N'" + kynang.Text + "'");
                MessageBox.Show("Sửa thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
            }
            catch 
            {
                MessageBox.Show("Xảy ra lỗi khi sửa nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Lấy tất cả thông tin nhân viên từ dòng được nhấn vào
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView2_RowClick(object sender, RowClickEventArgs e)
        {
            id_tab1 = gridView2.GetDataRow(e.RowHandle).ItemArray[0].ToString();
            name = gridView2.GetDataRow(e.RowHandle).ItemArray[1].ToString();
            gt = gridView2.GetDataRow(e.RowHandle).ItemArray[2].ToString();
            ns = gridView2.GetDataRow(e.RowHandle).ItemArray[3].ToString().Split(' ')[0];
            cv = gridView2.GetDataRow(e.RowHandle).ItemArray[4].ToString();
            phone = gridView2.GetDataRow(e.RowHandle).ItemArray[5].ToString();
            luog = gridView2.GetDataRow(e.RowHandle).ItemArray[6].ToString();
            kn = gridView2.GetDataRow(e.RowHandle).ItemArray[7].ToString();
        }

        /// <summary>
        /// Nhấn vào nút sửa, tất cả thông tin của nhân viên được chọn sẽ được điền vào textbox tương ứng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void edit_Click(object sender, EventArgs e)
        {
            idNhanVien.Text = id_tab1;
            hoten.Text = name;
            gioitinh.Text = gt;
            ngaysinh.DateTime = DateTime.Parse(ns);
            chucvu.Text = cv;
            sdt.Text = phone;
            luong.Text = luog;
            kynang.Text = kn;
        }

        /// <summary>
        /// Chọn nhân viên cần xoá, bấm để xoá
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void del_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Bạn có muốn xoá nhân viên " + name, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(question == DialogResult.Yes)
            {
                try
                {

                    dataProvider.exc("exec del_nv " + id_tab1);
                    MessageBox.Show("Xoá thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_data();
                }
                catch
                {
                    MessageBox.Show("Lỗi, không xoá được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Tìm nhân viên theo thông tin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            ds_nv.DataSource = null;
            try
            {
                switch (chonchucvu.Text)
                {
                    case "Mã Nhân Viên":
                        table = dataProvider.GetDataTable("exec search_nv_id " + "'" + inputSearch.Text + "'");
                        ds_nv.DataSource = table;
                        break;
                    case "Họ Tên Nhân Viên":
                        table = dataProvider.GetDataTable("exec search_nv_name " + "N'" + inputSearch.Text + "'");
                        ds_nv.DataSource = table;
                        break;
                    case "Chức Vụ":
                        table = dataProvider.GetDataTable("exec search_nv_work " + "N'" + inputSearch.Text + "'");
                        ds_nv.DataSource = table;
                        break;
                    case "Giới Tính":
                        table = dataProvider.GetDataTable("exec search_nv_gt " + "N'" + inputSearch.Text + "'");
                        ds_nv.DataSource = table;
                        break;
                    case "Ngày Sinh":
                        table = dataProvider.GetDataTable("exec search_nv_ns " + "'" + format_date(inputsearch_ns.Text) + "'");
                        ds_nv.DataSource = table;
                        break;
                    case "Lương":
                        table = dataProvider.GetDataTable("exec search_nv_luong " + inputSearch.Text);
                        ds_nv.DataSource = table;
                        break;
                    case "Số Điện Thoại":
                        table = dataProvider.GetDataTable("exec search_nv_sdt " + "'" + inputSearch.Text + "'");
                        ds_nv.DataSource = table;
                        break;
                    default:
                        ds_nv.DataSource = null;
                        break;
                }
            }
            catch { }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chonchucvu_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if(chonchucvu.Text == "Ngày Sinh")
            {
                inputSearch.Visible = false;
                inputsearch_ns.Visible = true;
            }
            else
            {
                inputSearch.Visible = true;
                inputsearch_ns.Visible = false;
            }
        }


        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            id_tab2 = gridView1.GetDataRow(e.RowHandle).ItemArray[0].ToString();
            nv_hoten.Text = gridView1.GetDataRow(e.RowHandle).ItemArray[1].ToString();
            nv_chucvu.Text = gridView1.GetDataRow(e.RowHandle).ItemArray[4].ToString();
            nv_luong.Text = gridView1.GetDataRow(e.RowHandle).ItemArray[6].ToString();
            nv_ngayvaolam.Text = gridView1.GetDataRow(e.RowHandle).ItemArray[8].ToString().Split(' ')[0];
            nv_ngaytinhcong.Text = gridView1.GetDataRow(e.RowHandle).ItemArray[10].ToString().Split(' ')[0];
            try
            {
                nv_socong.Text = dataProvider.ExcScalar("exec return_nv_day " + "'" + id_tab2 + "', '" + format_date(dateEdit1.Text) + "'").ToString();
                int l = int.Parse((float.Parse(nv_luong.Text) * float.Parse(nv_socong.Text) / 30).ToString());
                if (l >= 0)
                {
                    nv_traluong.Text = l.ToString();
                }
                else
                {
                    nv_traluong.Text = "0";
                }
            }
            catch { }
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                nv_socong.Text = dataProvider.ExcScalar("exec return_nv_day " + "'" + id_tab2 + "', '" + format_date(dateEdit1.Text) + "'").ToString();
                int l = int.Parse((float.Parse(nv_luong.Text) * float.Parse(nv_socong.Text) / 30).ToString());
                if (l >= 0)
                {
                    nv_traluong.Text = l.ToString();
                }
                else
                {
                    nv_traluong.Text = "0";
                }
            }
            catch { }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult ms = MessageBox.Show("Trả lương cho nhân viên " + nv_hoten.Text, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ms == DialogResult.Yes)
            {
                dataProvider.exc("exec add_nv_timestart " + "'" + id_tab2 + "', '" + format_date(dateEdit1.Text) + "'");
                MessageBox.Show("Đã trả lương cho nhân viên " + nv_hoten.Text + " từ " + nv_ngaytinhcong.Text + " đến " + dateEdit1.Text + " là " + nv_traluong.Text + " VNĐ", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridControl1.DataSource = dataProvider.GetDataTable("exec load_nv");
                nv_ngaytinhcong.Text = dateEdit1.Text;
                nv_socong.Text = "0";
                nv_traluong.Text = "0";
            }
        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
