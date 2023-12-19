namespace ThiGiuaKy
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
			this.txtTacGia = new System.Windows.Forms.TextBox();
			this.txtMaTacPham = new System.Windows.Forms.TextBox();
			this.txtTenTacPham = new System.Windows.Forms.TextBox();
			this.cbLoai = new System.Windows.Forms.ComboBox();
			this.dgDS = new System.Windows.Forms.DataGridView();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnXuat = new System.Windows.Forms.Button();
			this.btnLamMoi = new System.Windows.Forms.Button();
			this.btnTim = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgDS)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(69, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên tác giả:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(69, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mã tác phẩm:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(69, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 21);
			this.label3.TabIndex = 0;
			this.label3.Text = "Tên tác phẩm:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(69, 181);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 21);
			this.label4.TabIndex = 0;
			this.label4.Text = "Loại tác phẩm:";
			// 
			// txtTacGia
			// 
			this.txtTacGia.Location = new System.Drawing.Point(186, 35);
			this.txtTacGia.Name = "txtTacGia";
			this.txtTacGia.Size = new System.Drawing.Size(414, 22);
			this.txtTacGia.TabIndex = 1;
			// 
			// txtMaTacPham
			// 
			this.txtMaTacPham.Location = new System.Drawing.Point(186, 80);
			this.txtMaTacPham.Name = "txtMaTacPham";
			this.txtMaTacPham.Size = new System.Drawing.Size(414, 22);
			this.txtMaTacPham.TabIndex = 1;
			// 
			// txtTenTacPham
			// 
			this.txtTenTacPham.Location = new System.Drawing.Point(186, 128);
			this.txtTenTacPham.Name = "txtTenTacPham";
			this.txtTenTacPham.Size = new System.Drawing.Size(414, 22);
			this.txtTenTacPham.TabIndex = 1;
			// 
			// cbLoai
			// 
			this.cbLoai.FormattingEnabled = true;
			this.cbLoai.Location = new System.Drawing.Point(228, 181);
			this.cbLoai.Name = "cbLoai";
			this.cbLoai.Size = new System.Drawing.Size(372, 24);
			this.cbLoai.TabIndex = 2;
			// 
			// dgDS
			// 
			this.dgDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDS.Location = new System.Drawing.Point(73, 232);
			this.dgDS.Name = "dgDS";
			this.dgDS.RowHeadersWidth = 51;
			this.dgDS.RowTemplate.Height = 24;
			this.dgDS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgDS.Size = new System.Drawing.Size(527, 187);
			this.dgDS.TabIndex = 3;
			this.dgDS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDS_CellContentClick);
			// 
			// btnThem
			// 
			this.btnThem.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Location = new System.Drawing.Point(710, 33);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(159, 34);
			this.btnThem.TabIndex = 4;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnSua
			// 
			this.btnSua.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.Location = new System.Drawing.Point(710, 94);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(159, 34);
			this.btnSua.TabIndex = 4;
			this.btnSua.Text = "Sửa ";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Location = new System.Drawing.Point(710, 168);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(159, 34);
			this.btnXoa.TabIndex = 4;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnXuat
			// 
			this.btnXuat.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXuat.Location = new System.Drawing.Point(710, 232);
			this.btnXuat.Name = "btnXuat";
			this.btnXuat.Size = new System.Drawing.Size(159, 34);
			this.btnXuat.TabIndex = 4;
			this.btnXuat.Text = "Xuất file Excel";
			this.btnXuat.UseVisualStyleBackColor = true;
			this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLamMoi.Location = new System.Drawing.Point(710, 293);
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(159, 34);
			this.btnLamMoi.TabIndex = 4;
			this.btnLamMoi.Text = "Làm mới";
			this.btnLamMoi.UseVisualStyleBackColor = true;
			this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
			// 
			// btnTim
			// 
			this.btnTim.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTim.Location = new System.Drawing.Point(710, 362);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(159, 34);
			this.btnTim.TabIndex = 4;
			this.btnTim.Text = "Tìm tên tác phẩm";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(913, 463);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.btnLamMoi);
			this.Controls.Add(this.btnXuat);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.dgDS);
			this.Controls.Add(this.cbLoai);
			this.Controls.Add(this.txtTenTacPham);
			this.Controls.Add(this.txtMaTacPham);
			this.Controls.Add(this.txtTacGia);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Quản lý tác phẩm";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgDS)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTacGia;
		private System.Windows.Forms.TextBox txtMaTacPham;
		private System.Windows.Forms.TextBox txtTenTacPham;
		private System.Windows.Forms.ComboBox cbLoai;
		private System.Windows.Forms.DataGridView dgDS;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnXuat;
		private System.Windows.Forms.Button btnLamMoi;
		private System.Windows.Forms.Button btnTim;
	}
}

