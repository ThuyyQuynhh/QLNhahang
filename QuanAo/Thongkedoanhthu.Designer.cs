namespace QuanAo
{
    partial class Thongkedoanhthu
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbchonnam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbchonthang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpChonngay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.raBtnNam = new System.Windows.Forms.RadioButton();
            this.raBtnThang = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.raBtnNgay = new System.Windows.Forms.RadioButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dtgvdoanhthu = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdoanhthu = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdoanhthu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnThongke);
            this.groupControl1.Controls.Add(this.panel3);
            this.groupControl1.Controls.Add(this.panel2);
            this.groupControl1.Controls.Add(this.panel1);
            this.groupControl1.Controls.Add(this.raBtnNam);
            this.groupControl1.Controls.Add(this.raBtnThang);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.raBtnNgay);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(375, 731);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thống kê";
            // 
            // btnThongke
            // 
            this.btnThongke.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.Location = new System.Drawing.Point(102, 509);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(138, 53);
            this.btnThongke.TabIndex = 0;
            this.btnThongke.Text = "THỐNG KÊ";
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbchonnam);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(32, 389);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 59);
            this.panel3.TabIndex = 1;
            // 
            // cmbchonnam
            // 
            this.cmbchonnam.Enabled = false;
            this.cmbchonnam.FormattingEnabled = true;
            this.cmbchonnam.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020"});
            this.cmbchonnam.Location = new System.Drawing.Point(103, 18);
            this.cmbchonnam.Name = "cmbchonnam";
            this.cmbchonnam.Size = new System.Drawing.Size(200, 24);
            this.cmbchonnam.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chọn năm:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbchonthang);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(32, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 59);
            this.panel2.TabIndex = 3;
            // 
            // cmbchonthang
            // 
            this.cmbchonthang.Enabled = false;
            this.cmbchonthang.FormattingEnabled = true;
            this.cmbchonthang.Items.AddRange(new object[] {
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
            this.cmbchonthang.Location = new System.Drawing.Point(103, 18);
            this.cmbchonthang.Name = "cmbchonthang";
            this.cmbchonthang.Size = new System.Drawing.Size(200, 24);
            this.cmbchonthang.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chọn tháng:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpChonngay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(32, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 59);
            this.panel1.TabIndex = 0;
            // 
            // dtpChonngay
            // 
            this.dtpChonngay.CustomFormat = "";
            this.dtpChonngay.Enabled = false;
            this.dtpChonngay.Location = new System.Drawing.Point(103, 21);
            this.dtpChonngay.Name = "dtpChonngay";
            this.dtpChonngay.Size = new System.Drawing.Size(200, 23);
            this.dtpChonngay.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn ngày:";
            // 
            // raBtnNam
            // 
            this.raBtnNam.AutoSize = true;
            this.raBtnNam.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raBtnNam.Location = new System.Drawing.Point(51, 211);
            this.raBtnNam.Name = "raBtnNam";
            this.raBtnNam.Size = new System.Drawing.Size(216, 25);
            this.raBtnNam.TabIndex = 2;
            this.raBtnNam.TabStop = true;
            this.raBtnNam.Text = "THỐNG KÊ THEO NĂM";
            this.raBtnNam.UseVisualStyleBackColor = true;
            this.raBtnNam.CheckedChanged += new System.EventHandler(this.raBtnNam_CheckedChanged);
            // 
            // raBtnThang
            // 
            this.raBtnThang.AutoSize = true;
            this.raBtnThang.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raBtnThang.Location = new System.Drawing.Point(51, 165);
            this.raBtnThang.Name = "raBtnThang";
            this.raBtnThang.Size = new System.Drawing.Size(237, 25);
            this.raBtnThang.TabIndex = 1;
            this.raBtnThang.TabStop = true;
            this.raBtnThang.Text = "THỐNG KÊ THEO THÁNG";
            this.raBtnThang.UseVisualStyleBackColor = true;
            this.raBtnThang.CheckedChanged += new System.EventHandler(this.raBtnThang_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ THEO:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // raBtnNgay
            // 
            this.raBtnNgay.AutoSize = true;
            this.raBtnNgay.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raBtnNgay.Location = new System.Drawing.Point(51, 124);
            this.raBtnNgay.Name = "raBtnNgay";
            this.raBtnNgay.Size = new System.Drawing.Size(225, 25);
            this.raBtnNgay.TabIndex = 0;
            this.raBtnNgay.TabStop = true;
            this.raBtnNgay.Text = "THỐNG KÊ THEO NGÀY";
            this.raBtnNgay.UseVisualStyleBackColor = true;
            this.raBtnNgay.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dtgvdoanhthu);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(375, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1024, 597);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Doanh thu";
            // 
            // dtgvdoanhthu
            // 
            this.dtgvdoanhthu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvdoanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvdoanhthu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvdoanhthu.Location = new System.Drawing.Point(2, 26);
            this.dtgvdoanhthu.Name = "dtgvdoanhthu";
            this.dtgvdoanhthu.RowHeadersWidth = 51;
            this.dtgvdoanhthu.RowTemplate.Height = 24;
            this.dtgvdoanhthu.Size = new System.Drawing.Size(1020, 569);
            this.dtgvdoanhthu.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(436, 649);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "DOANH THU:";
            // 
            // txtdoanhthu
            // 
            this.txtdoanhthu.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdoanhthu.Location = new System.Drawing.Point(563, 631);
            this.txtdoanhthu.Name = "txtdoanhthu";
            this.txtdoanhthu.Size = new System.Drawing.Size(155, 56);
            this.txtdoanhthu.TabIndex = 3;
            this.txtdoanhthu.Text = "";
            this.txtdoanhthu.TextChanged += new System.EventHandler(this.txtdoanhthu_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(740, 649);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "(VND)";
            // 
            // Thongkedoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdoanhthu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "Thongkedoanhthu";
            this.Size = new System.Drawing.Size(1399, 731);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdoanhthu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.RadioButton raBtnThang;
        private System.Windows.Forms.RadioButton raBtnNgay;
        private System.Windows.Forms.RadioButton raBtnNam;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbchonnam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbchonthang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpChonngay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvdoanhthu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtdoanhthu;
        private System.Windows.Forms.Label label6;
    }
}
