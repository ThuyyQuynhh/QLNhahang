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
using System.Data.SqlClient;

namespace QuanAo
{
    public partial class KHO : DevExpress.XtraEditors.XtraUserControl
    {
        public KHO()
        {
            InitializeComponent(); 
            LoadNguyenLieu();
            LoadLichSu();
        }
        KetNoi kn = new KetNoi();
        // SQLDataAdapter -> select
        // SQLCommand -> insert,update,delete
        //public void XemDL()
        //{
        //    SqlConnection connection = new SqlConnection(ConnectionString.connectionString);
        //    connection.Open();
        //    string query = "";

        //    //SqlCommand command = new SqlCommand(query, connection);
        //    //SqlDataAdapter adapter = new SqlDataAdapter(command);
        //    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

        //    DataTable table = new DataTable();
        //    adapter.Fill(table);

        //    dataLSnhap.DataSource = table;

        //    //DataTable con cua DataSet 
        //    //DataSet chua nhieu bang, nhu 1 database hoan chinh
        //    connection.Close();
        //}
        //public void LoadNL()
        //{
        //    NguyenLieuBUS.Instance.GetNL(dataNL);
        //}
        //public void LoadLs()
        //{
        //    NhapKhoBUS.Instance.GetLSNhap(dataLSnhap);
        //}
        //public void TimKiem()
        //{
        //    //SqlConnection connection = new SqlConnection(ConnectionString.connectionString);
        //    //connection.Open();
        //    //string query = "select *from NguyenLieu where id like @id";

        //    //SqlCommand command = new SqlCommand(query, connection);
        //    //command.Parameters.AddWithValue("@id", 1);
        //    ////command.Parameters.AddWithValue("@id", txtTimkiem.Text());

        //    //SqlDataAdapter adapter = new SqlDataAdapter(command);

        //    //DataTable table = new DataTable();
        //    //adapter.Fill(table);

        //    //gridControl3.DataSource = table;

        //    ////DataTable con cua DataSet 
        //    ////DataSet chua nhieu bang, nhu 1 database hoan chinh
        //    //connection.Close();

        //    // su dung ham chung ExecuteQuery
        //    string query = "";
        //    object parameter = new object[] { };
        //    //gridControl3.DataSource = ExecuteQuery(query);
        //}
        //DataSet GetLichSuNhapKho()
        //{
        //    DataSet data = new DataSet();

        //    string query = "LSNhapKho";
        //    using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
        //    {
        //        connection.Open();

        //        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
        //        adapter.Fill(data);

        //        connection.Close();
        //    }

        //    return data;
        //}

        //DataSet GetNL()
        //{
        //    DataSet data = new DataSet();

        //    string query = "select_NL";
        //    using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
        //    {
        //        connection.Open();

        //        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
        //        adapter.Fill(data);

        //        connection.Close();
        //    }

        //    return data;
        //}

        public void LoadNguyenLieu()
        {
            dataNL.DataSource = kn.truyvanTSql("select_NL");
            
            DataTable data = kn.truyvanTSql("select_NL");
            data.Columns[0].ColumnName = "Mã Nguyên Liệu";
            data.Columns[1].ColumnName = "Tên Nguyên Liệu";
            data.Columns[2].ColumnName = "Số Lượng";
            searchLookUpEdit2.Properties.DataSource = data;
        }
        public void LoadLichSu()
        {
            dataLSnhap.DataSource = kn.truyvanTSql("LSNhapKho");

            DataTable data = kn.truyvanTSql("LSNhapKho");
            data.Columns[0].ColumnName = "Mã Phiếu Nhập Kho";
            data.Columns[1].ColumnName = "Mã Nhân Viên";
            data.Columns[2].ColumnName = "Họ Tên";
            data.Columns[3].ColumnName = "Ngày Nhập";
            data.Columns[4].ColumnName = "Giá";
            searchLookUpEdit3.Properties.DataSource = data;
        }

        private void sbtnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaNL.Text == "")
            {
                XtraMessageBox.Show("Bạn không được để trống thông tin");
            }    
            else
            {
                kn.Xoa_NL(Convert.ToInt32(txtMaNL.Text));
                XtraMessageBox.Show("Xóa thành công");
                LoadNguyenLieu();
                lam_tuoi();
            }    
        }
        private void lam_tuoi()
        {
            sbtnThem.Enabled = true;
            sbtnSua.Enabled = true;
            sbtnXoa.Enabled = true;
            txtMaNL.ResetText();
            txtTenNL.ResetText();
            numSLNL.ResetText();
            numSLNL.Enabled = true;
        }
        private void lam_tuoiPNK()
        {
            cbMaNV.Text = "";
            dateEdit1.ResetText();
            cbMaNL.Text = "";  
            numSL_PNK.ResetText();
            txtGia_PNK.ResetText();
        }
        private void sbtnSua_Click(object sender, EventArgs e)
        {
            if (txtTenNL.Text == "")
            {
                XtraMessageBox.Show("Tên Nguyên Liệu không được để trống");
                txtTenNL.Focus();
            }
            else
            {
                kn.Sua_NL(Convert.ToInt32(txtMaNL.Text) ,txtTenNL.Text, Convert.ToInt32(numSLNL.Value.ToString()));
                XtraMessageBox.Show("Sửa thông tin thành công");
                LoadNguyenLieu();
                lam_tuoi();
            }
        }

        private void dataNL_Click(object sender, EventArgs e)
        {
            int row = dataNL.CurrentCell.RowIndex;
            sbtnThem.Enabled = false;
            txtMaNL.Text = dataNL.Rows[row].Cells["MaNL"].Value.ToString();
            txtTenNL.Text = dataNL.Rows[row].Cells["TenNL"].Value.ToString();
            numSLNL.Text = dataNL.Rows[row].Cells["SL"].Value.ToString();
        }

        private void sbtnThem_Click(object sender, EventArgs e)
        {
            if(txtTenNL.Text == "")
            {
                XtraMessageBox.Show("Tên Nguyên Liệu không được để trống");
                txtTenNL.Focus();
            }
            else
            {
                DataTable data = new DataTable();
                data = kn.truyvanSQL("Select *from NguyenLieu where TenNL = N'" + txtTenNL.Text + "'");
                if(data.Rows.Count > 0)
                {
                    XtraMessageBox.Show("Nguyên Liệu bạn nhập đã có trong kho");
                }    
                else
                {
                    kn.Them_NL(txtTenNL.Text, Convert.ToInt32(numSLNL.Value.ToString()));
                    LoadNguyenLieu();
                    lam_tuoi();
                }    
            }
        }

        private void txtTenNL_KeyDown(object sender, KeyEventArgs e)
        {
            if(txtTenNL.Text == "")
            {
                sbtnSua.Enabled = false;
                sbtnXoa.Enabled = false;
                numSLNL.Value = 0;
            }     
        }

        private void sbtnNhap_Click(object sender, EventArgs e)
        {
            if (cbMaNL.Text == "" || numSL_PNK.Value == 0 || txtGia_PNK.Text == "" )
            {
                XtraMessageBox.Show("Bạn phải điền đầy đủ vào các thông tin");
            }
            else
            {
                sbtnThemMoi.Enabled = false;
                kn.Them_CTNK(kn.GetMaPNK(), Convert.ToInt32(cbMaNL.Text), Convert.ToInt32(numSL_PNK.Value.ToString()), Convert.ToInt32(txtGia_PNK.Text));
                dataPNK.DataSource = kn.Xem_PNK(Convert.ToInt32(kn.GetMaPNK()));
                cbMaNL.Text = "";
                numSL_PNK.Value = 0;
                txtGia_PNK.ResetText();
                LoadNguyenLieu();
                LoadLichSu();
                sbtnKhoiTao.Enabled = true;
            }    
        }
        private void sbtnThemMoi_Click(object sender, EventArgs e)
        {
            if(cbMaNV.Text == "")
            {
                XtraMessageBox.Show("Bạn phải nhập mã nhân viên");
            }
            else if (dateEdit1.Text == "")
            {
                XtraMessageBox.Show("Bạn phải nhập ngày nhập phiếu");
            }
            else
            {
                dateEdit1.Enabled = false;
                sbtnKhoiTao.Enabled = false;
                cbMaNV.Enabled = false;
                cbMaNL.Enabled = true;
                numSL_PNK.Enabled = true;
                txtGia_PNK.Enabled = true;
                sbtnNhap.Enabled = true;
                kn.Them_PNK(cbMaNV.Text, Convert.ToDateTime(dateEdit1.Text));
                kn.loadCombobox(cbMaNL, "NguyenLieu", "id_NguyenLieu");
                for(int i=0 ; i < dataPNK.Rows.Count-1 ; i++)   // clear hang trong bang
                {
                    dataPNK.Rows.RemoveAt(i);
                    i--;
                    while (dataPNK.Rows.Count == 0)
                        continue;
                }
                LoadLichSu();
            }    
        }

        private void sbtnKhoiTao_Click(object sender, EventArgs e)
        {
            sbtnThemMoi.Enabled = true;
            lam_tuoiPNK();
            cbMaNV.Enabled = true;
            dateEdit1.Enabled = true;
            cbMaNL.Enabled = false;
            numSL_PNK.Enabled = false;
            txtGia_PNK.Enabled = false;
            kn.loadCombobox(cbMaNV, "NhanVien", "id_NhanVien");
        }

        private void txtGia_PNK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void searchLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            var view = searchLookUpEdit2.Properties.View;
            int rowHandle = view.FocusedRowHandle;
            string fieldName1 = "Mã Nguyên Liệu";
            string fieldName2 = "Tên Nguyên Liệu";
            string fieldName3 = "Số Lượng";
            object value1 = view.GetRowCellValue(rowHandle, fieldName1);
            object value2 = view.GetRowCellValue(rowHandle, fieldName2);
            object value3 = view.GetRowCellValue(rowHandle, fieldName3);
            txtMaNL.Text = value1.ToString();
            txtTenNL.Text = value2.ToString();
            numSLNL.Text = value3.ToString();
        }

        private void searchLookUpEdit3_EditValueChanged(object sender, EventArgs e)
        {
            var view = searchLookUpEdit3.Properties.View;
            int rowHandle = view.FocusedRowHandle;
            string fieldName1 = "Mã Phiếu Nhập Kho";
            string fieldName2 = "Mã Nhân Viên";
            string fieldName3 = "Họ Tên";
            string fieldName4 = "Ngày Nhập";
            object value1 = view.GetRowCellValue(rowHandle, fieldName1);
            object value2 = view.GetRowCellValue(rowHandle, fieldName2);
            object value3 = view.GetRowCellValue(rowHandle, fieldName3);
            object value4 = view.GetRowCellValue(rowHandle, fieldName4);
            txtTTmaPNK.Text = value1.ToString();
            txtTTmaNV.Text = value2.ToString();
            txtTTHoTen.Text = value3.ToString();
            txtTTngayNhap.Text = value4.ToString().Substring(0,11);
            DataTable data = kn.Xem_PNK(Convert.ToInt32(txtTTmaPNK.Text));
            dataTTPNK.DataSource = data;
        }

        private void dataLSnhap_Click(object sender, EventArgs e)
        {
            int row = dataLSnhap.CurrentCell.RowIndex;
            txtTTmaPNK.Text = dataLSnhap.Rows[row].Cells["MaPNK"].Value.ToString();
            txtTTmaNV.Text = dataLSnhap.Rows[row].Cells["MaNV"].Value.ToString();
            txtTTHoTen.Text = dataLSnhap.Rows[row].Cells["HT"].Value.ToString();
            if (txtTTmaPNK.Text != "")
                txtTTngayNhap.Text = dataLSnhap.Rows[row].Cells["NgayNhap"].Value.ToString().Substring(0, 11);
            else
            {
                txtTTngayNhap.Text = "";
                for (int i = 0; i < dataTTPNK.Rows.Count - 1; i++)   // clear hang trong bang
                {
                    dataTTPNK.Rows.RemoveAt(i);
                    i--;
                    while (dataTTPNK.Rows.Count == 0)
                        continue;
                }
            }    
                
            try
            {
                DataTable data = kn.Xem_PNK(Convert.ToInt32(txtTTmaPNK.Text));
                dataTTPNK.DataSource = data;
            }
            catch
            {

            }   
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            lam_tuoi();
        }

        private void labelControl14_Click(object sender, EventArgs e)
        {

        }
    }
}
