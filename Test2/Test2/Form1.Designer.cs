namespace Test2
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
			this.txtNhap = new System.Windows.Forms.TextBox();
			this.lstDS = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnTim = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(89, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhập tên ngoại ngữ:";
			// 
			// txtNhap
			// 
			this.txtNhap.Location = new System.Drawing.Point(237, 45);
			this.txtNhap.Name = "txtNhap";
			this.txtNhap.Size = new System.Drawing.Size(327, 22);
			this.txtNhap.TabIndex = 1;
			this.txtNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhap_KeyPress);
			// 
			// lstDS
			// 
			this.lstDS.FormattingEnabled = true;
			this.lstDS.ItemHeight = 16;
			this.lstDS.Location = new System.Drawing.Point(92, 140);
			this.lstDS.Name = "lstDS";
			this.lstDS.Size = new System.Drawing.Size(615, 196);
			this.lstDS.TabIndex = 2;
			this.lstDS.SelectedIndexChanged += new System.EventHandler(this.lstDS_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(89, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(161, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Danh sách các ngoại ngữ:";
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(92, 374);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(133, 31);
			this.btnThem.TabIndex = 3;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(257, 374);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(133, 31);
			this.btnXoa.TabIndex = 3;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnTim
			// 
			this.btnTim.Location = new System.Drawing.Point(417, 374);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(133, 31);
			this.btnTim.TabIndex = 3;
			this.btnTim.Text = "Tìm kiếm";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(574, 374);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(133, 31);
			this.btnThoat.TabIndex = 3;
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
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.lstDS);
			this.Controls.Add(this.txtNhap);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Chương trình minh họa ListBox";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNhap;
		private System.Windows.Forms.ListBox lstDS;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.Button btnThoat;
	}
}

