namespace QuanAo
{
    partial class DanhSachBan
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.DS_Ban = new System.Windows.Forms.FlowLayoutPanel();
            this.ChiTietBan = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBillInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.cbBan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.lb_TongGia = new System.Windows.Forms.Label();
            this.numKM = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnThemMon = new System.Windows.Forms.Panel();
            this.SL_Mon = new System.Windows.Forms.NumericUpDown();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBMon = new System.Windows.Forms.ComboBox();
            this.CBDanhMuc = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SoBan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietBan)).BeginInit();
            this.ChiTietBan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKM)).BeginInit();
            this.pnThemMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SL_Mon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.DS_Ban);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(808, 682);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách bàn ăn";
            // 
            // DS_Ban
            // 
            this.DS_Ban.AutoScroll = true;
            this.DS_Ban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DS_Ban.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.DS_Ban.Location = new System.Drawing.Point(2, 26);
            this.DS_Ban.Name = "DS_Ban";
            this.DS_Ban.Size = new System.Drawing.Size(804, 654);
            this.DS_Ban.TabIndex = 0;
            // 
            // ChiTietBan
            // 
            this.ChiTietBan.Controls.Add(this.panel1);
            this.ChiTietBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChiTietBan.Location = new System.Drawing.Point(808, 0);
            this.ChiTietBan.Name = "ChiTietBan";
            this.ChiTietBan.Size = new System.Drawing.Size(520, 682);
            this.ChiTietBan.TabIndex = 1;
            this.ChiTietBan.Text = "Chi tiết bàn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnThemMon);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.SoBan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 654);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBillInfo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(516, 384);
            this.panel3.TabIndex = 6;
            // 
            // listBillInfo
            // 
            this.listBillInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listBillInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBillInfo.HideSelection = false;
            this.listBillInfo.Location = new System.Drawing.Point(0, 0);
            this.listBillInfo.Name = "listBillInfo";
            this.listBillInfo.Size = new System.Drawing.Size(516, 384);
            this.listBillInfo.TabIndex = 1;
            this.listBillInfo.UseCompatibleStateImageBehavior = false;
            this.listBillInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 227;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 73;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 103;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 106;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.simpleButton3);
            this.panel2.Controls.Add(this.cbBan);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.lb_TongGia);
            this.panel2.Controls.Add(this.numKM);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 489);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 165);
            this.panel2.TabIndex = 5;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(394, 13);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(103, 29);
            this.simpleButton3.TabIndex = 7;
            this.simpleButton3.Text = "Chuyển";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // cbBan
            // 
            this.cbBan.FormattingEnabled = true;
            this.cbBan.Location = new System.Drawing.Point(141, 15);
            this.cbBan.Name = "cbBan";
            this.cbBan.Size = new System.Drawing.Size(231, 24);
            this.cbBan.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Chuyển bàn :";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(403, 62);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(94, 65);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Thanh Toán";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // lb_TongGia
            // 
            this.lb_TongGia.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongGia.Location = new System.Drawing.Point(126, 94);
            this.lb_TongGia.Name = "lb_TongGia";
            this.lb_TongGia.Size = new System.Drawing.Size(246, 35);
            this.lb_TongGia.TabIndex = 3;
            // 
            // numKM
            // 
            this.numKM.Location = new System.Drawing.Point(130, 55);
            this.numKM.Name = "numKM";
            this.numKM.Size = new System.Drawing.Size(75, 23);
            this.numKM.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tổng giá :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giảm giá :";
            // 
            // pnThemMon
            // 
            this.pnThemMon.Controls.Add(this.SL_Mon);
            this.pnThemMon.Controls.Add(this.simpleButton1);
            this.pnThemMon.Controls.Add(this.label2);
            this.pnThemMon.Controls.Add(this.label1);
            this.pnThemMon.Controls.Add(this.CBMon);
            this.pnThemMon.Controls.Add(this.CBDanhMuc);
            this.pnThemMon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnThemMon.Location = new System.Drawing.Point(0, 38);
            this.pnThemMon.Name = "pnThemMon";
            this.pnThemMon.Size = new System.Drawing.Size(516, 67);
            this.pnThemMon.TabIndex = 4;
            // 
            // SL_Mon
            // 
            this.SL_Mon.Location = new System.Drawing.Point(430, 20);
            this.SL_Mon.Name = "SL_Mon";
            this.SL_Mon.Size = new System.Drawing.Size(67, 23);
            this.SL_Mon.TabIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(330, 10);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 39);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Thêm món";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên món";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh mục";
            // 
            // CBMon
            // 
            this.CBMon.FormattingEnabled = true;
            this.CBMon.Location = new System.Drawing.Point(92, 37);
            this.CBMon.Name = "CBMon";
            this.CBMon.Size = new System.Drawing.Size(216, 24);
            this.CBMon.TabIndex = 1;
            // 
            // CBDanhMuc
            // 
            this.CBDanhMuc.FormattingEnabled = true;
            this.CBDanhMuc.Location = new System.Drawing.Point(92, 10);
            this.CBDanhMuc.Name = "CBDanhMuc";
            this.CBDanhMuc.Size = new System.Drawing.Size(216, 24);
            this.CBDanhMuc.TabIndex = 0;
            this.CBDanhMuc.SelectedIndexChanged += new System.EventHandler(this.CBDanhMuc_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(103, 738);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // SoBan
            // 
            this.SoBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.SoBan.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoBan.Location = new System.Drawing.Point(0, 0);
            this.SoBan.Name = "SoBan";
            this.SoBan.Size = new System.Drawing.Size(516, 38);
            this.SoBan.TabIndex = 0;
            // 
            // DanhSachBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChiTietBan);
            this.Controls.Add(this.groupControl1);
            this.Name = "DanhSachBan";
            this.Size = new System.Drawing.Size(1328, 682);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietBan)).EndInit();
            this.ChiTietBan.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numKM)).EndInit();
            this.pnThemMon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SL_Mon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl ChiTietBan;
        private System.Windows.Forms.FlowLayoutPanel DS_Ban;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SoBan;
        private System.Windows.Forms.ListView listBillInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnThemMon;
        private System.Windows.Forms.NumericUpDown SL_Mon;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBMon;
        private System.Windows.Forms.ComboBox CBDanhMuc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numKM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_TongGia;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.ComboBox cbBan;
        private System.Windows.Forms.Label label5;
    }
}
