namespace QuanAo
{
    partial class KhachHang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DS_KH = new System.Windows.Forms.DataGridView();
            this.pn_ChucNang = new System.Windows.Forms.Panel();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_HoTen = new System.Windows.Forms.TextBox();
            this.DT_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.tx_SDT = new System.Windows.Forms.TextBox();
            this.tx_DC = new System.Windows.Forms.TextBox();
            this.cb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pn_ThongTin = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_KH)).BeginInit();
            this.pn_ChucNang.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pn_ThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 667);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DS_KH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(751, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(646, 667);
            this.panel2.TabIndex = 1;
            // 
            // DS_KH
            // 
            this.DS_KH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DS_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DS_KH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DS_KH.Location = new System.Drawing.Point(0, 0);
            this.DS_KH.Name = "DS_KH";
            this.DS_KH.RowHeadersWidth = 51;
            this.DS_KH.RowTemplate.Height = 24;
            this.DS_KH.Size = new System.Drawing.Size(646, 667);
            this.DS_KH.TabIndex = 0;
            
            // 
            // pn_ChucNang
            // 
            this.pn_ChucNang.Controls.Add(this.simpleButton1);
            this.pn_ChucNang.Location = new System.Drawing.Point(486, 77);
            this.pn_ChucNang.Name = "pn_ChucNang";
            this.pn_ChucNang.Size = new System.Drawing.Size(226, 240);
            this.pn_ChucNang.TabIndex = 0;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(38, 19);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 29);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Tạo mới";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pn_ThongTin);
            this.panel4.Controls.Add(this.pn_ChucNang);
            this.panel4.Controls.Add(this.btn_Them);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(751, 367);
            this.panel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày sinh :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và tên :";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 43);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ :";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số điện thoại :";
            // 
            // tx_HoTen
            // 
            this.tx_HoTen.Location = new System.Drawing.Point(215, 19);
            this.tx_HoTen.Name = "tx_HoTen";
            this.tx_HoTen.Size = new System.Drawing.Size(200, 23);
            this.tx_HoTen.TabIndex = 6;
            // 
            // DT_NgaySinh
            // 
            this.DT_NgaySinh.Location = new System.Drawing.Point(215, 61);
            this.DT_NgaySinh.Name = "DT_NgaySinh";
            this.DT_NgaySinh.Size = new System.Drawing.Size(200, 23);
            this.DT_NgaySinh.TabIndex = 7;
            // 
            // tx_SDT
            // 
            this.tx_SDT.Location = new System.Drawing.Point(215, 112);
            this.tx_SDT.Name = "tx_SDT";
            this.tx_SDT.Size = new System.Drawing.Size(200, 23);
            this.tx_SDT.TabIndex = 8;
            // 
            // tx_DC
            // 
            this.tx_DC.Location = new System.Drawing.Point(215, 151);
            this.tx_DC.Name = "tx_DC";
            this.tx_DC.Size = new System.Drawing.Size(200, 23);
            this.tx_DC.TabIndex = 9;
            // 
            // cb_GioiTinh
            // 
            this.cb_GioiTinh.FormattingEnabled = true;
            this.cb_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_GioiTinh.Location = new System.Drawing.Point(214, 208);
            this.cb_GioiTinh.Name = "cb_GioiTinh";
            this.cb_GioiTinh.Size = new System.Drawing.Size(101, 24);
            this.cb_GioiTinh.TabIndex = 10;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(42, 36);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 29);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "Thêm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pn_ThongTin
            // 
            this.pn_ThongTin.Controls.Add(this.label3);
            this.pn_ThongTin.Controls.Add(this.cb_GioiTinh);
            this.pn_ThongTin.Controls.Add(this.label2);
            this.pn_ThongTin.Controls.Add(this.label4);
            this.pn_ThongTin.Controls.Add(this.label5);
            this.pn_ThongTin.Controls.Add(this.tx_DC);
            this.pn_ThongTin.Controls.Add(this.label6);
            this.pn_ThongTin.Controls.Add(this.tx_SDT);
            this.pn_ThongTin.Controls.Add(this.tx_HoTen);
            this.pn_ThongTin.Controls.Add(this.DT_NgaySinh);
            this.pn_ThongTin.Location = new System.Drawing.Point(38, 76);
            this.pn_ThongTin.Name = "pn_ThongTin";
            this.pn_ThongTin.Size = new System.Drawing.Size(442, 265);
            this.pn_ThongTin.TabIndex = 11;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "KhachHang";
            this.Size = new System.Drawing.Size(1397, 667);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DS_KH)).EndInit();
            this.pn_ChucNang.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pn_ThongTin.ResumeLayout(false);
            this.pn_ThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pn_ChucNang;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DS_KH;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_GioiTinh;
        private System.Windows.Forms.TextBox tx_DC;
        private System.Windows.Forms.TextBox tx_SDT;
        private System.Windows.Forms.DateTimePicker DT_NgaySinh;
        private System.Windows.Forms.TextBox tx_HoTen;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel pn_ThongTin;
    }
}
