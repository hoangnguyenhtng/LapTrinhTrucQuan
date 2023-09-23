using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewDemo5_9
{
    public partial class Form1 : Form
    {
        List<MatHang> ds = new List<MatHang>();
        public Form1()
        {
            InitializeComponent();
            this.ds.Add(new MatHang("Ma 1", "Giầy", 100));
            this.ds.Add(new MatHang("Ma 2", "Áo", 100));
            this.ds.Add(new MatHang("Ma 3", "Quần", 212));
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {

            if (kiemtra())
            {
                MatHang x = new MatHang(txtMa.Text, txtTen.Text, int.Parse(txtSL.Text));
                    ListViewItem item = new ListViewItem();
                    item.Text = txtMa.Text;
                    item.SubItems.Add(txtTen.Text);
                    item.SubItems.Add(txtSL.Text);
                    listView1.Items.Add(item);
                    ds.Add(x);

            }
           
        }

        private bool kiemtra()
        {
            if (txtMa.Text.Trim().Length == 0 ||
                txtTen.Text.Trim().Length == 0 ||
                txtSL.Text.Trim().Length == 0)
            {
                MessageBox.Show("Nhập đủ thông tin đi");
                return false;
            }
            foreach (MatHang matHang in ds)
            {
                if (matHang.Ma == txtMa.Text)
                {
                    MessageBox.Show("Mã trùng rồi");
                    return false;
                }
            }
            return true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int i = listView1.SelectedItems[0].Index;
                listView1.Items[i].SubItems[0].Text = txtMa.Text;
                listView1.Items[i].SubItems[1].Text = txtTen.Text;
                listView1.Items[i].SubItems[2].Text = txtSL.Text;
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem ls = new ListViewItem();
            if (listView1.SelectedItems.Count > 0)
            {
                ls = listView1.SelectedItems[0];
                txtMa.Text = ls.Text;
                txtTen.Text = ls.SubItems[1].Text;
                txtSL.Text = ls.SubItems[2].Text;
            }
            else MessageBox.Show("hay chon dong");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (DialogResult.OK == MessageBox.Show("Ban co muon xoa ", "tb", MessageBoxButtons.OKCancel))
                {
                    int i = listView1.SelectedItems[0].Index;
                    listView1.Items.RemoveAt(i);
                }
            }
        }
    }
}
