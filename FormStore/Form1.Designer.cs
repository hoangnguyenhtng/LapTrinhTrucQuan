namespace FormStore
{
    partial class Form1
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
            this.lstDanhSachMatHang = new System.Windows.Forms.ListBox();
            this.lstHangDatMua = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTheTinDung = new System.Windows.Forms.RadioButton();
            this.rdbSec = new System.Windows.Forms.RadioButton();
            this.rdbTienMat = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbEmail = new System.Windows.Forms.CheckBox();
            this.chbFax = new System.Windows.Forms.CheckBox();
            this.chbDienThoai = new System.Windows.Forms.CheckBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh sách các mặt hàng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hàng đặt mua";
            // 
            // lstDanhSachMatHang
            // 
            this.lstDanhSachMatHang.FormattingEnabled = true;
            this.lstDanhSachMatHang.ItemHeight = 16;
            this.lstDanhSachMatHang.Location = new System.Drawing.Point(52, 110);
            this.lstDanhSachMatHang.Name = "lstDanhSachMatHang";
            this.lstDanhSachMatHang.Size = new System.Drawing.Size(283, 132);
            this.lstDanhSachMatHang.TabIndex = 1;
            this.lstDanhSachMatHang.SelectedIndexChanged += new System.EventHandler(this.lstDanhSachMatHang_SelectedIndexChanged);
            this.lstDanhSachMatHang.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstDanhSachMatHang_MouseDoubleClick);
            // 
            // lstHangDatMua
            // 
            this.lstHangDatMua.FormattingEnabled = true;
            this.lstHangDatMua.ItemHeight = 16;
            this.lstHangDatMua.Location = new System.Drawing.Point(448, 110);
            this.lstHangDatMua.Name = "lstHangDatMua";
            this.lstHangDatMua.Size = new System.Drawing.Size(283, 132);
            this.lstHangDatMua.TabIndex = 1;
            this.lstHangDatMua.SelectedIndexChanged += new System.EventHandler(this.lstHangDatMua_SelectedIndexChanged);
            this.lstHangDatMua.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstHangDatMua_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTheTinDung);
            this.groupBox1.Controls.Add(this.rdbSec);
            this.groupBox1.Controls.Add(this.rdbTienMat);
            this.groupBox1.Location = new System.Drawing.Point(52, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phương thức thanh toán";
            // 
            // rdbTheTinDung
            // 
            this.rdbTheTinDung.AutoSize = true;
            this.rdbTheTinDung.Location = new System.Drawing.Point(38, 87);
            this.rdbTheTinDung.Name = "rdbTheTinDung";
            this.rdbTheTinDung.Size = new System.Drawing.Size(101, 20);
            this.rdbTheTinDung.TabIndex = 0;
            this.rdbTheTinDung.TabStop = true;
            this.rdbTheTinDung.Text = "Thẻ tín dụng";
            this.rdbTheTinDung.UseVisualStyleBackColor = true;
            this.rdbTheTinDung.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdbSec
            // 
            this.rdbSec.AutoSize = true;
            this.rdbSec.Location = new System.Drawing.Point(38, 61);
            this.rdbSec.Name = "rdbSec";
            this.rdbSec.Size = new System.Drawing.Size(52, 20);
            this.rdbSec.TabIndex = 0;
            this.rdbSec.TabStop = true;
            this.rdbSec.Text = "Séc";
            this.rdbSec.UseVisualStyleBackColor = true;
            // 
            // rdbTienMat
            // 
            this.rdbTienMat.AutoSize = true;
            this.rdbTienMat.Location = new System.Drawing.Point(38, 35);
            this.rdbTienMat.Name = "rdbTienMat";
            this.rdbTienMat.Size = new System.Drawing.Size(80, 20);
            this.rdbTienMat.TabIndex = 0;
            this.rdbTienMat.TabStop = true;
            this.rdbTienMat.Text = "Tiền mặt";
            this.rdbTienMat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbEmail);
            this.groupBox2.Controls.Add(this.chbFax);
            this.groupBox2.Controls.Add(this.chbDienThoai);
            this.groupBox2.Location = new System.Drawing.Point(448, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 138);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hình thức liên lạc";
            // 
            // chbEmail
            // 
            this.chbEmail.AutoSize = true;
            this.chbEmail.Location = new System.Drawing.Point(55, 88);
            this.chbEmail.Name = "chbEmail";
            this.chbEmail.Size = new System.Drawing.Size(63, 20);
            this.chbEmail.TabIndex = 0;
            this.chbEmail.Text = "Email";
            this.chbEmail.UseVisualStyleBackColor = true;
            this.chbEmail.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chbFax
            // 
            this.chbFax.AutoSize = true;
            this.chbFax.Location = new System.Drawing.Point(55, 62);
            this.chbFax.Name = "chbFax";
            this.chbFax.Size = new System.Drawing.Size(51, 20);
            this.chbFax.TabIndex = 0;
            this.chbFax.Text = "Fax";
            this.chbFax.UseVisualStyleBackColor = true;
            // 
            // chbDienThoai
            // 
            this.chbDienThoai.AutoSize = true;
            this.chbDienThoai.Location = new System.Drawing.Point(55, 34);
            this.chbDienThoai.Name = "chbDienThoai";
            this.chbDienThoai.Size = new System.Drawing.Size(88, 20);
            this.chbDienThoai.TabIndex = 0;
            this.chbDienThoai.Text = "Điện thoại";
            this.chbDienThoai.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(112, 27);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(223, 22);
            this.txtHoTen.TabIndex = 4;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(520, 24);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(211, 22);
            this.txtDienThoai.TabIndex = 4;
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(260, 415);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.TabIndex = 5;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(656, 408);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstHangDatMua);
            this.Controls.Add(this.lstDanhSachMatHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstDanhSachMatHang;
        private System.Windows.Forms.ListBox lstHangDatMua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTheTinDung;
        private System.Windows.Forms.RadioButton rdbSec;
        private System.Windows.Forms.RadioButton rdbTienMat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbEmail;
        private System.Windows.Forms.CheckBox chbFax;
        private System.Windows.Forms.CheckBox chbDienThoai;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnThoat;
    }
}

