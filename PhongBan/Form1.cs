using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhongBan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaPhong.Text;
            string ten = txtTenPhong.Text;
            if (KiemTra())
            {
                ListViewItem item = new ListViewItem();
                item.Text = ma;
                item.SubItems.Add(ten);
                listView1.Items.Add(item);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban co muon thoat!!!","Thong bao",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private bool KiemTra()
        {
            if(txtMaPhong.Text.Trim().Length > 0 && txtTenPhong.Text.Trim().Length > 0)
            {
                return true;
            }
            return false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                if (KiemTra())
                {
                    var i = listView1.SelectedItems[0].Index;
                    listView1.Items[i].SubItems[0].Text = txtMaPhong.Text;
                    listView1.Items[i].SubItems[1].Text = txtTenPhong.Text;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var i = listView1.SelectedItems[0].Index;
            if (MessageBox.Show("Ban Co muon Xoa " + listView1.Items[i].SubItems[0].Text,"Thong bao",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                listView1.Items.RemoveAt(i);
            }
        }
    }
}
