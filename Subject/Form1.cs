using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonHoc
{
    public partial class Form1 : Form
    {
        List<Subject> subjects = new List<Subject>();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            switch (i)
            {
                case 0:
                    txtTin.Text = 2.ToString();
                break;
                case 1:
                    txtTin.Text = 3.ToString();
                    break;
                case 2:
                    txtTin.Text = 3.ToString();
                    break;
                case 3:
                    txtTin.Text = 2.ToString();
                    break;
                case 4:
                    txtTin.Text = 3.ToString();
                    break;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                ListViewItem item = new ListViewItem();
                item.Text = comboBox1.SelectedItem.ToString();
                item.SubItems.Add(txtTin.Text);
                item.SubItems.Add(txtDiem.Text);
                listView1.Items.Add(item);
                subjects.Add(new Subject(comboBox1.SelectedItem.ToString(), int.Parse(txtTin.Text), int.Parse(txtDiem.Text)));

            }
            else MessageBox.Show("Hay nhap day du du lieu");
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            switch (keyData)
            {
                case Keys.Alt | Keys.D:
                    ListViewItem item = new ListViewItem();
                    item.Text = comboBox1.SelectedItem.ToString();
                    item.SubItems.Add(txtTin.Text);
                    item.SubItems.Add(txtDiem.Text);
                    listView1.Items.Add(item);
                    subjects.Add(new Subject(comboBox1.SelectedItem.ToString(), int.Parse(txtTin.Text), int.Parse(txtDiem.Text)));
                    return true;
                case (Keys.Alt | Keys.H):
                    if(MessageBox.Show("Bạn Có Muốn Thoát Không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.Close();
                        return true;
                    }
                    break;
                case (Keys.Alt | Keys.T):
                    txtTongTin.Text = TinhTongTin();
                    txtTongDiem.Text = TinhTongDiem();
                    txtDTB.Text = DTB();
                    return true;


            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn Có Muốn Thoát Không?","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTongTin.Text = TinhTongTin();
            txtTongDiem.Text = TinhTongDiem();
            txtDTB.Text = DTB();
        }
        private string TinhTongTin()
        {
            string s = "";
            int tong = 0;
            foreach(var item in subjects)
            {
                tong += item.SoTin;
                
            }
            s += tong.ToString();
            return s;
        }
        private string TinhTongDiem()
        {
            string s = "";
            int tong = 0;
            foreach (var item in subjects)
            {
                tong += item.Diem;

            }
            s += tong.ToString();
            return s;
        }
        private string DTB()
        {
            string s = "";
            int tong = 0;
            foreach (var item in subjects)
            {
                tong += item.DiemTheoTin();

            }
            tong = tong / int.Parse(TinhTongTin());
            s += tong.ToString();
            return s;
        }
        private bool Validate()
        {
            if(comboBox1.SelectedIndex == -1 || txtDiem.Text.Trim().Length == 0)
            {
                return false;
            }
            return true;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
