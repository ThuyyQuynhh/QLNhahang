namespace QuanAo
{
    partial class DatBan
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
            this.DS_Ban = new DevExpress.XtraEditors.GroupControl();
            this.pn_ChucNang = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbBan = new System.Windows.Forms.ComboBox();
            this.btn_ThemBan = new DevExpress.XtraEditors.SimpleButton();
            this.pn_ThongTin = new System.Windows.Forms.Panel();
            this.btn_TimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Tao = new DevExpress.XtraEditors.SimpleButton();
            this.lbid_HD = new System.Windows.Forms.Label();
            this.lb_TenKH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_SDT = new System.Windows.Forms.TextBox();
            this.CBNhanVien = new System.Windows.Forms.ComboBox();
            this.btn_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.HoaDonBan = new System.Windows.Forms.DataGridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.DS_HD = new System.Windows.Forms.DataGridView();
            this.btn_XoaBan = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Ban)).BeginInit();
            this.DS_Ban.SuspendLayout();
            this.pn_ChucNang.SuspendLayout();
            this.pn_ThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_HD)).BeginInit();
            this.SuspendLayout();
            // 
            // DS_Ban
            // 
            this.DS_Ban.Controls.Add(this.pn_ChucNang);
            this.DS_Ban.Controls.Add(this.pn_ThongTin);
            this.DS_Ban.Controls.Add(this.btn_CapNhat);
            this.DS_Ban.Controls.Add(this.btn_ThemMoi);
            this.DS_Ban.Controls.Add(this.groupControl3);
            this.DS_Ban.Dock = System.Windows.Forms.DockStyle.Left;
            this.DS_Ban.Location = new System.Drawing.Point(0, 0);
            this.DS_Ban.Name = "DS_Ban";
            this.DS_Ban.Size = new System.Drawing.Size(668, 617);
            this.DS_Ban.TabIndex = 0;
            this.DS_Ban.Text = "Thông tin đặt bàn";
            this.DS_Ban.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // pn_ChucNang
            // 
            this.pn_ChucNang.Controls.Add(this.label7);
            this.pn_ChucNang.Controls.Add(this.cbBan);
            this.pn_ChucNang.Controls.Add(this.btn_ThemBan);
            this.pn_ChucNang.Controls.Add(this.btn_XoaBan);
            this.pn_ChucNang.Location = new System.Drawing.Point(22, 276);
            this.pn_ChucNang.Name = "pn_ChucNang";
            this.pn_ChucNang.Size = new System.Drawing.Size(571, 86);
            this.pn_ChucNang.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(27, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Danh sách bàn trống :";
            // 
            // cbBan
            // 
            this.cbBan.FormattingEnabled = true;
            this.cbBan.Location = new System.Drawing.Point(181, 7);
            this.cbBan.Name = "cbBan";
            this.cbBan.Size = new System.Drawing.Size(220, 24);
            this.cbBan.TabIndex = 10;
            // 
            // btn_ThemBan
            // 
            this.btn_ThemBan.Location = new System.Drawing.Point(30, 43);
            this.btn_ThemBan.Name = "btn_ThemBan";
            this.btn_ThemBan.Size = new System.Drawing.Size(94, 29);
            this.btn_ThemBan.TabIndex = 12;
            this.btn_ThemBan.Text = "Thêm bàn";
            this.btn_ThemBan.Click += new System.EventHandler(this.btn_ThemBan_Click);
            // 
            // pn_ThongTin
            // 
            this.pn_ThongTin.Controls.Add(this.btn_TimKiem);
            this.pn_ThongTin.Controls.Add(this.btn_Tao);
            this.pn_ThongTin.Controls.Add(this.lbid_HD);
            this.pn_ThongTin.Controls.Add(this.lb_TenKH);
            this.pn_ThongTin.Controls.Add(this.label1);
            this.pn_ThongTin.Controls.Add(this.label4);
            this.pn_ThongTin.Controls.Add(this.label5);
            this.pn_ThongTin.Controls.Add(this.label2);
            this.pn_ThongTin.Controls.Add(this.tx_SDT);
            this.pn_ThongTin.Controls.Add(this.CBNhanVien);
            this.pn_ThongTin.Location = new System.Drawing.Point(22, 51);
            this.pn_ThongTin.Name = "pn_ThongTin";
            this.pn_ThongTin.Size = new System.Drawing.Size(505, 226);
            this.pn_ThongTin.TabIndex = 0;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(409, 109);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(94, 29);
            this.btn_TimKiem.TabIndex = 17;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_Tao
            // 
            this.btn_Tao.Location = new System.Drawing.Point(24, 189);
            this.btn_Tao.Name = "btn_Tao";
            this.btn_Tao.Size = new System.Drawing.Size(94, 29);
            this.btn_Tao.TabIndex = 16;
            this.btn_Tao.Text = "Tạo";
            this.btn_Tao.Click += new System.EventHandler(this.btn_Tao_Click);
            // 
            // lbid_HD
            // 
            this.lbid_HD.Location = new System.Drawing.Point(178, 12);
            this.lbid_HD.Name = "lbid_HD";
            this.lbid_HD.Size = new System.Drawing.Size(224, 17);
            this.lbid_HD.TabIndex = 4;
            // 
            // lb_TenKH
            // 
            this.lb_TenKH.Location = new System.Drawing.Point(178, 163);
            this.lb_TenKH.Name = "lb_TenKH";
            this.lb_TenKH.Size = new System.Drawing.Size(223, 17);
            this.lb_TenKH.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã hóa đơn : ";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(27, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "SĐT khách hàng :";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(27, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Khách hàng :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhân viên";
            // 
            // tx_SDT
            // 
            this.tx_SDT.Location = new System.Drawing.Point(178, 113);
            this.tx_SDT.Name = "tx_SDT";
            this.tx_SDT.Size = new System.Drawing.Size(223, 23);
            this.tx_SDT.TabIndex = 6;
            // 
            // CBNhanVien
            // 
            this.CBNhanVien.FormattingEnabled = true;
            this.CBNhanVien.Location = new System.Drawing.Point(177, 66);
            this.CBNhanVien.Name = "CBNhanVien";
            this.CBNhanVien.Size = new System.Drawing.Size(224, 24);
            this.CBNhanVien.TabIndex = 5;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Location = new System.Drawing.Point(542, 34);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(94, 29);
            this.btn_CapNhat.TabIndex = 15;
            this.btn_CapNhat.Text = "cập nhật";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.Location = new System.Drawing.Point(533, 73);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(129, 29);
            this.btn_ThemMoi.TabIndex = 14;
            this.btn_ThemMoi.Text = "Tạo hóa đơn mới";
            this.btn_ThemMoi.Click += new System.EventHandler(this.btn_ThemMoi_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.HoaDonBan);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(2, 365);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(664, 250);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Danh sách bàn của hóa đơn";
            // 
            // HoaDonBan
            // 
            this.HoaDonBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HoaDonBan.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.HoaDonBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HoaDonBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HoaDonBan.Location = new System.Drawing.Point(2, 26);
            this.HoaDonBan.Name = "HoaDonBan";
            this.HoaDonBan.RowHeadersWidth = 51;
            this.HoaDonBan.RowTemplate.Height = 24;
            this.HoaDonBan.Size = new System.Drawing.Size(660, 222);
            this.HoaDonBan.TabIndex = 0;
            this.HoaDonBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HoaDonBan_CellClick);
            this.HoaDonBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HoaDonBan_CellContentClick);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.DS_HD);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(668, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(660, 617);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Danh sách hóa đơn";
            this.groupControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl2_Paint);
            // 
            // DS_HD
            // 
            this.DS_HD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DS_HD.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DS_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DS_HD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DS_HD.Location = new System.Drawing.Point(2, 26);
            this.DS_HD.Name = "DS_HD";
            this.DS_HD.RowHeadersWidth = 51;
            this.DS_HD.RowTemplate.Height = 24;
            this.DS_HD.Size = new System.Drawing.Size(656, 589);
            this.DS_HD.TabIndex = 1;
            this.DS_HD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DS_HD_CellClick);
            // 
            // btn_XoaBan
            // 
            this.btn_XoaBan.Location = new System.Drawing.Point(140, 43);
            this.btn_XoaBan.Name = "btn_XoaBan";
            this.btn_XoaBan.Size = new System.Drawing.Size(94, 29);
            this.btn_XoaBan.TabIndex = 13;
            this.btn_XoaBan.Text = "Xóa hóa đơn";
            this.btn_XoaBan.Click += new System.EventHandler(this.btn_XoaBan_Click);
            // 
            // DatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.DS_Ban);
            this.Name = "DatBan";
            this.Size = new System.Drawing.Size(1328, 617);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Ban)).EndInit();
            this.DS_Ban.ResumeLayout(false);
            this.pn_ChucNang.ResumeLayout(false);
            this.pn_ThongTin.ResumeLayout(false);
            this.pn_ThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DS_HD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl DS_Ban;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.DataGridView HoaDonBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_ThemBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbBan;
        private System.Windows.Forms.Label lb_TenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_SDT;
        private System.Windows.Forms.ComboBox CBNhanVien;
        private System.Windows.Forms.Label lbid_HD;
        private System.Windows.Forms.DataGridView DS_HD;
        private DevExpress.XtraEditors.SimpleButton btn_CapNhat;
        private DevExpress.XtraEditors.SimpleButton btn_ThemMoi;
        private System.Windows.Forms.Panel pn_ThongTin;
        private System.Windows.Forms.Panel pn_ChucNang;
        private DevExpress.XtraEditors.SimpleButton btn_Tao;
        private DevExpress.XtraEditors.SimpleButton btn_TimKiem;
        private DevExpress.XtraEditors.SimpleButton btn_XoaBan;
    }
}
