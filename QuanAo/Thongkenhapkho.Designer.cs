namespace QuanAo
{
    partial class Thongkenhapkho
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
            this.btnThongke = new System.Windows.Forms.Button();
            this.raBtnTP = new System.Windows.Forms.RadioButton();
            this.cmbtennguyenlieu = new System.Windows.Forms.ComboBox();
            this.cbmChonnam = new System.Windows.Forms.ComboBox();
            this.cmbChonthang = new System.Windows.Forms.ComboBox();
            this.dtpChonngay = new System.Windows.Forms.DateTimePicker();
            this.raBtnchonnam = new System.Windows.Forms.RadioButton();
            this.rabtnchonthang = new System.Windows.Forms.RadioButton();
            this.raBtnchonngay = new System.Windows.Forms.RadioButton();
            this.raBtnthucpham = new System.Windows.Forms.RadioButton();
            this.raBtnthoigian = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dtgvNhapkho = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhapkho)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnThongke);
            this.groupControl1.Controls.Add(this.raBtnTP);
            this.groupControl1.Controls.Add(this.cmbtennguyenlieu);
            this.groupControl1.Controls.Add(this.cbmChonnam);
            this.groupControl1.Controls.Add(this.cmbChonthang);
            this.groupControl1.Controls.Add(this.dtpChonngay);
            this.groupControl1.Controls.Add(this.raBtnchonnam);
            this.groupControl1.Controls.Add(this.rabtnchonthang);
            this.groupControl1.Controls.Add(this.raBtnchonngay);
            this.groupControl1.Controls.Add(this.raBtnthucpham);
            this.groupControl1.Controls.Add(this.raBtnthoigian);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(445, 620);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thống kê";
            // 
            // btnThongke
            // 
            this.btnThongke.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.Location = new System.Drawing.Point(135, 453);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(160, 65);
            this.btnThongke.TabIndex = 11;
            this.btnThongke.Text = "THỐNG KÊ";
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // raBtnTP
            // 
            this.raBtnTP.AutoSize = true;
            this.raBtnTP.Enabled = false;
            this.raBtnTP.Location = new System.Drawing.Point(99, 345);
            this.raBtnTP.Name = "raBtnTP";
            this.raBtnTP.Size = new System.Drawing.Size(82, 21);
            this.raBtnTP.TabIndex = 10;
            this.raBtnTP.TabStop = true;
            this.raBtnTP.Text = "Chọn NL";
            this.raBtnTP.UseVisualStyleBackColor = true;
            // 
            // cmbtennguyenlieu
            // 
            this.cmbtennguyenlieu.Enabled = false;
            this.cmbtennguyenlieu.FormattingEnabled = true;
            this.cmbtennguyenlieu.Location = new System.Drawing.Point(218, 344);
            this.cmbtennguyenlieu.Name = "cmbtennguyenlieu";
            this.cmbtennguyenlieu.Size = new System.Drawing.Size(200, 24);
            this.cmbtennguyenlieu.TabIndex = 9;
            this.cmbtennguyenlieu.SelectedIndexChanged += new System.EventHandler(this.cmbtennguyenlieu_SelectedIndexChanged);
            // 
            // cbmChonnam
            // 
            this.cbmChonnam.Enabled = false;
            this.cbmChonnam.FormattingEnabled = true;
            this.cbmChonnam.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020"});
            this.cbmChonnam.Location = new System.Drawing.Point(218, 253);
            this.cbmChonnam.Name = "cbmChonnam";
            this.cbmChonnam.Size = new System.Drawing.Size(200, 24);
            this.cbmChonnam.TabIndex = 8;
            // 
            // cmbChonthang
            // 
            this.cmbChonthang.Enabled = false;
            this.cmbChonthang.FormattingEnabled = true;
            this.cmbChonthang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbChonthang.Location = new System.Drawing.Point(218, 210);
            this.cmbChonthang.Name = "cmbChonthang";
            this.cmbChonthang.Size = new System.Drawing.Size(200, 24);
            this.cmbChonthang.TabIndex = 7;
            // 
            // dtpChonngay
            // 
            this.dtpChonngay.Enabled = false;
            this.dtpChonngay.Location = new System.Drawing.Point(218, 167);
            this.dtpChonngay.Name = "dtpChonngay";
            this.dtpChonngay.Size = new System.Drawing.Size(200, 23);
            this.dtpChonngay.TabIndex = 6;
            // 
            // raBtnchonnam
            // 
            this.raBtnchonnam.AutoSize = true;
            this.raBtnchonnam.Enabled = false;
            this.raBtnchonnam.Location = new System.Drawing.Point(99, 254);
            this.raBtnchonnam.Name = "raBtnchonnam";
            this.raBtnchonnam.Size = new System.Drawing.Size(98, 21);
            this.raBtnchonnam.TabIndex = 5;
            this.raBtnchonnam.TabStop = true;
            this.raBtnchonnam.Text = "Chọn năm:";
            this.raBtnchonnam.UseVisualStyleBackColor = true;
            this.raBtnchonnam.CheckedChanged += new System.EventHandler(this.raBtnchonnam_CheckedChanged);
            // 
            // rabtnchonthang
            // 
            this.rabtnchonthang.AutoSize = true;
            this.rabtnchonthang.Enabled = false;
            this.rabtnchonthang.Location = new System.Drawing.Point(99, 210);
            this.rabtnchonthang.Name = "rabtnchonthang";
            this.rabtnchonthang.Size = new System.Drawing.Size(107, 21);
            this.rabtnchonthang.TabIndex = 4;
            this.rabtnchonthang.TabStop = true;
            this.rabtnchonthang.Text = "Chọn tháng:";
            this.rabtnchonthang.UseVisualStyleBackColor = true;
            this.rabtnchonthang.CheckedChanged += new System.EventHandler(this.rabtnchonthang_CheckedChanged);
            // 
            // raBtnchonngay
            // 
            this.raBtnchonngay.AutoSize = true;
            this.raBtnchonngay.Enabled = false;
            this.raBtnchonngay.Location = new System.Drawing.Point(99, 170);
            this.raBtnchonngay.Name = "raBtnchonngay";
            this.raBtnchonngay.Size = new System.Drawing.Size(102, 21);
            this.raBtnchonngay.TabIndex = 3;
            this.raBtnchonngay.TabStop = true;
            this.raBtnchonngay.Text = "Chọn ngày:";
            this.raBtnchonngay.UseVisualStyleBackColor = true;
            this.raBtnchonngay.CheckedChanged += new System.EventHandler(this.raBtnchonngay_CheckedChanged);
            // 
            // raBtnthucpham
            // 
            this.raBtnthucpham.AutoSize = true;
            this.raBtnthucpham.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raBtnthucpham.Location = new System.Drawing.Point(54, 294);
            this.raBtnthucpham.Name = "raBtnthucpham";
            this.raBtnthucpham.Size = new System.Drawing.Size(201, 25);
            this.raBtnthucpham.TabIndex = 2;
            this.raBtnthucpham.TabStop = true;
            this.raBtnthucpham.Text = "THEO NGUYÊN LIỆU";
            this.raBtnthucpham.UseVisualStyleBackColor = true;
            this.raBtnthucpham.CheckedChanged += new System.EventHandler(this.raBtnthucpham_CheckedChanged);
            // 
            // raBtnthoigian
            // 
            this.raBtnthoigian.AutoSize = true;
            this.raBtnthoigian.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raBtnthoigian.Location = new System.Drawing.Point(54, 124);
            this.raBtnthoigian.Name = "raBtnthoigian";
            this.raBtnthoigian.Size = new System.Drawing.Size(178, 25);
            this.raBtnthoigian.TabIndex = 1;
            this.raBtnthoigian.TabStop = true;
            this.raBtnthoigian.Text = "THEO THỜI GIAN";
            this.raBtnthoigian.UseVisualStyleBackColor = true;
            this.raBtnthoigian.CheckedChanged += new System.EventHandler(this.raBtnthoigian_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "LỰA CHỌN THỐNG KÊ";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dtgvNhapkho);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(445, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(972, 620);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Nhập kho";
            // 
            // dtgvNhapkho
            // 
            this.dtgvNhapkho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvNhapkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhapkho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvNhapkho.Location = new System.Drawing.Point(2, 26);
            this.dtgvNhapkho.Name = "dtgvNhapkho";
            this.dtgvNhapkho.RowHeadersWidth = 51;
            this.dtgvNhapkho.RowTemplate.Height = 24;
            this.dtgvNhapkho.Size = new System.Drawing.Size(968, 592);
            this.dtgvNhapkho.TabIndex = 0;
            // 
            // Thongkenhapkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "Thongkenhapkho";
            this.Size = new System.Drawing.Size(1417, 620);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhapkho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.RadioButton raBtnTP;
        private System.Windows.Forms.ComboBox cmbtennguyenlieu;
        private System.Windows.Forms.ComboBox cbmChonnam;
        private System.Windows.Forms.ComboBox cmbChonthang;
        private System.Windows.Forms.DateTimePicker dtpChonngay;
        private System.Windows.Forms.RadioButton raBtnchonnam;
        private System.Windows.Forms.RadioButton rabtnchonthang;
        private System.Windows.Forms.RadioButton raBtnchonngay;
        private System.Windows.Forms.RadioButton raBtnthucpham;
        private System.Windows.Forms.RadioButton raBtnthoigian;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dtgvNhapkho;
    }
}
