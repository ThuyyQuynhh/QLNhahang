namespace QuanAo
{
    partial class AddKhachHang
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.txmakh = new System.Windows.Forms.TextBox();
            this.txsdt = new System.Windows.Forms.TextBox();
            this.txtenkh = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại : ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên khách hàng : ";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(93, 296);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(158, 53);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Thêm khách hàng";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(335, 296);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(162, 53);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Hủy";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // txmakh
            // 
            this.txmakh.Enabled = false;
            this.txmakh.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txmakh.Location = new System.Drawing.Point(197, 119);
            this.txmakh.Name = "txmakh";
            this.txmakh.Size = new System.Drawing.Size(300, 27);
            this.txmakh.TabIndex = 0;
            // 
            // txsdt
            // 
            this.txsdt.Enabled = false;
            this.txsdt.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txsdt.Location = new System.Drawing.Point(197, 236);
            this.txsdt.Name = "txsdt";
            this.txsdt.Size = new System.Drawing.Size(300, 27);
            this.txsdt.TabIndex = 2;
            this.txsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txsdt_KeyPress);
            // 
            // txtenkh
            // 
            this.txtenkh.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtenkh.Location = new System.Drawing.Point(197, 177);
            this.txtenkh.Name = "txtenkh";
            this.txtenkh.Size = new System.Drawing.Size(300, 27);
            this.txtenkh.TabIndex = 1;
            // 
            // AddKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 409);
            this.Controls.Add(this.txtenkh);
            this.Controls.Add(this.txsdt);
            this.Controls.Add(this.txmakh);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddKhachHang";
            this.Load += new System.EventHandler(this.AddKhachHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.TextBox txmakh;
        private System.Windows.Forms.TextBox txsdt;
        private System.Windows.Forms.TextBox txtenkh;
    }
}