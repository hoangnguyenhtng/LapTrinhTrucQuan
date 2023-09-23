using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp228
{
    public partial class Form1 : Form
    {
        List<Sach1> lst;

        public Form1()
        {
            lst = new List<Sach1>();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool k = false;
            //tim kiem theo QR
            foreach(Sach1 x in lst)
            {
                if(x.Qr == txtQr.Text)
                {
                    k = true;
                    MessageBox.Show("So luong ton kho " + x.Sl.ToString());
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma, ten, tg, qr;
            int sl;
            ma = txtMa.Text;
            ten = txtTen.Text;
            tg  = txtTG.Text;
            qr = txtQr.Text;
            sl = int.Parse(txtSl.Text);
            
            Sach1 x = new Sach1(ma, ten, tg, sl, qr);
            lst.Add(x);
            lstDB.Items.Add(x.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = lstDB.SelectedIndex;
            if (index == -1)
                MessageBox.Show("Hay chon pt can xoa");
            else
            if(MessageBox.Show("Ban co muon xoa pt nay?", "",
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Question)==DialogResult.OK)
            {
                lstDB.Items.Remove(index);
                lst.RemoveAt(index);
            }
        }

        private void lstDB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
