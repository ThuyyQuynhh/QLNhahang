namespace QuanAo
{
    partial class Thongkehoadonkhachhang
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvlistKH = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInhoadon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.dtpDenngay = new System.Windows.Forms.DateTimePicker();
            this.dtpTungay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlistKH)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panel4);
            this.groupControl1.Controls.Add(this.panel2);
            this.groupControl1.Controls.Add(this.panel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1425, 625);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Hoá Đơn - Khách hàng";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvlistKH);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(2, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1421, 443);
            this.panel4.TabIndex = 2;
            // 
            // dtgvlistKH
            // 
            this.dtgvlistKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvlistKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvlistKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvlistKH.Location = new System.Drawing.Point(0, 0);
            this.dtgvlistKH.Name = "dtgvlistKH";
            this.dtgvlistKH.RowHeadersWidth = 51;
            this.dtgvlistKH.RowTemplate.Height = 24;
            this.dtgvlistKH.Size = new System.Drawing.Size(1421, 443);
            this.dtgvlistKH.TabIndex = 0;
            this.dtgvlistKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvlistKH_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnInhoadon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(2, 546);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1421, 77);
            this.panel2.TabIndex = 1;
            // 
            // btnInhoadon
            // 
            this.btnInhoadon.Enabled = false;
            this.btnInhoadon.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhoadon.Location = new System.Drawing.Point(108, 14);
            this.btnInhoadon.Name = "btnInhoadon";
            this.btnInhoadon.Size = new System.Drawing.Size(184, 48);
            this.btnInhoadon.TabIndex = 0;
            this.btnInhoadon.Text = "IN HOÁ ĐƠN";
            this.btnInhoadon.UseVisualStyleBackColor = true;
            this.btnInhoadon.Click += new System.EventHandler(this.btnInhoadon_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btntimkiem);
            this.panel1.Controls.Add(this.dtpDenngay);
            this.panel1.Controls.Add(this.dtpTungay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1421, 77);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 2;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(837, 25);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(118, 35);
            this.btntimkiem.TabIndex = 4;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // dtpDenngay
            // 
            this.dtpDenngay.Location = new System.Drawing.Point(538, 34);
            this.dtpDenngay.Name = "dtpDenngay";
            this.dtpDenngay.Size = new System.Drawing.Size(200, 23);
            this.dtpDenngay.TabIndex = 3;
            // 
            // dtpTungay
            // 
            this.dtpTungay.Location = new System.Drawing.Point(167, 34);
            this.dtpTungay.Name = "dtpTungay";
            this.dtpTungay.Size = new System.Drawing.Size(200, 23);
            this.dtpTungay.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Thongkehoadonkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "Thongkehoadonkhachhang";
            this.Size = new System.Drawing.Size(1425, 625);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlistKH)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTungay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInhoadon;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.DateTimePicker dtpDenngay;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgvlistKH;
        private System.Windows.Forms.Panel panel3;
    }
}
