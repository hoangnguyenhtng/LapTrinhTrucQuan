using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test2
{
	public partial class Form1 : Form
	{
		
		public Form1()
		{
			InitializeComponent();
		}



		private void btnThoat_Click(object sender, EventArgs e)
		{
			Close();
		}



		private void btnThem_Click(object sender, EventArgs e)
		{
			if (txtNhap.Text.Trim() == "") {
				MessageBox.Show("Vui lòng nhập văn bản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			foreach (var Items in lstDS.Items)
			{
				
				if (Items.ToString().ToLower().Equals(txtNhap.Text.ToLower().Trim()))
				{
					MessageBox.Show("Tên môn học đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			lstDS.Items.Add(txtNhap.Text.Trim());

		}

		private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar))
			{
				e.Handled = true; // Nếu là số, ngăn chặn ký tự được nhập vào
				MessageBox.Show("Vui lòng không nhập số.");
			}
		}

		private void lstDS_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			int selectedIndex = lstDS.SelectedIndex;
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (lstDS.Items.Count == 0)
			{
				MessageBox.Show("Không có dữ liệu để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (lstDS.SelectedIndex != -1)
			{
				lstDS.Items.RemoveAt(lstDS.SelectedIndex);
			}

		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			if (txtNhap.Text.Trim() == "")
			{
				MessageBox.Show("Vui lòng nhập tên môn học!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			for (int i = 0; i < lstDS.Items.Count; i++)
			{
				var item = lstDS.Items[i].ToString().ToLower();
				if (item.Equals(txtNhap.Text))
				{
					lstDS.SelectedIndex = i;
					lstDS.SetSelected(i, true);
					lstDS.TopIndex = i;
					break;
				}
			}

		}
	}
}
