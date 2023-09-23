using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_26_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ma, ten, dc;
            int tien, tgg;
            DateTime ng;
            bool htg = true;
            if (Validate())
            {
                ma = txtMa.Text;
                ten = txtTen.Text;
                dc = txtDC.Text;
                tien = int.Parse(txtTienGui.Text);
                tgg = int.Parse(cmbThang.SelectedItem.ToString());
                ng = dateGui.Value;
                if (rdbThuong.Checked == true)
                {
                    htg = true;
                }
                if (rdbVip.Checked == false)
                {
                    htg = false;
                }

                KhachHang x = new KhachHang(ma, ten, dc, tien, tgg, ng, htg);
                lstDS.Items.Add(x.ToString());
            }
        }
        private bool validate()
        {
            if(txtTen.Text.Trim() == "" 
                || txtMa.Text.Trim() == ""
                || txtDC.Text.Trim() == "" 
                || txtTienGui.Text.Trim().Length == 0
                || dateGui.Value.ToString() == ""
                || (rdbVip.Checked == false && rdbThuong.Checked == false)
                ||cmbThang.Text == "")
            {
                MessageBox.Show("Hay nhap du du lieu!");
                return false;
            }
            else return true;
        }

        private void txtTienGui_KeyPress(object sender, KeyPressEventArgs e)
        {
            // chi cho nha so va cac ki tu dieu khien
            if(!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar)) {
                e.Handled = true;

            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtTen.ResetText();
            txtMa.ResetText();
            txtDC.ResetText();
            txtTienGui.ResetText();
            cmbThang.Text = "0";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstDS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
