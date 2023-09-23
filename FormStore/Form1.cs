using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addData()
        {
            lstDanhSachMatHang.Items.Add("Kỹ thuật lập trình C#");
            lstDanhSachMatHang.Items.Add("Tự học Visual C# trong 21 ngày");
            lstDanhSachMatHang.Items.Add("Bài tập C#");
            lstDanhSachMatHang.Items.Add(".NET toàn tập - tập 1");
            lstDanhSachMatHang.Items.Add(".NET toàn tập - tập 2");
            lstDanhSachMatHang.Items.Add(".NET toàn tập - tập 3");
            lstDanhSachMatHang.Items.Add(".NET toàn tập - tập 4");
            lstDanhSachMatHang.Items.Add("Tin học cơ bản");
            lstDanhSachMatHang.Items.Add("SQL Server");
            lstDanhSachMatHang.Items.Add("Cơ bản về XML");
            lstDanhSachMatHang.Items.Add("Phân tích thiết kế hệ thống");
            lstDanhSachMatHang.Items.Add("Sử dụng Word");
            lstDanhSachMatHang.Items.Add("Đến với Word 2003");

        }

        private void lstDanhSachMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstHangDatMua_MouseDoubleClick(object sender, EventArgs e)
        {
            int index = lstHangDatMua.SelectedIndex;
            if(MessageBox.Show("Bạn có muốn xóa không?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes
                )
               lstHangDatMua.Items.RemoveAt(index);
        }

        private String HinhThucLL()
        {
            string a = "";
            if(chbDienThoai.Checked == true)
            {
                a += "  " + chbDienThoai.Text;
            }
            if(chbEmail.Checked == true)
            {
                a += "  " + chbEmail.Text;
            }
            if (chbFax.Checked == true)
            {
                a += "  " + chbFax.Text;
            }
            return a;
        }
        private string ThanhToan()
        {
            string s = " ";
            if(rdbTienMat.Checked == true)
            {
                s += rdbTienMat.Text;
            }
            else if(rdbSec.Checked == true)
            {
                s += rdbSec.Text;
            }
            else if(rdbTheTinDung.Checked == true)
            {
                s += rdbTheTinDung.Text;
            }
            return s;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            string sb = " ";
            if (txtHoTen.Text.Equals("") || txtDienThoai.Text.Equals(""))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Thông báo");
                txtHoTen.Focus();
            }
            else
            {
                
                foreach(object item in lstHangDatMua.Items)
                {
                    list.Add(item.ToString());  
                }

            }
            lstHangDatMua.Items.Clear();
            lstHangDatMua.Items.Add("Khách hàng: " + txtHoTen.Text);
            lstHangDatMua.Items.Add("Số điện thoại: " + txtDienThoai.Text);
            lstHangDatMua.Items.Add("Hình thức liên lạc " + HinhThucLL());
            lstHangDatMua.Items.Add("Hình thức thanh toán: " + ThanhToan());
            foreach (string  item in list)
            {
                lstHangDatMua.Items.Add((string)item);
            }
        }

        private void lstDanhSachMatHang_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string curItem = lstDanhSachMatHang.SelectedItem.ToString();
            // tim kiem xem co trong hang dat mua
            int index = lstHangDatMua.FindString(curItem);
            // neu ma khong co thi in thong bao va them vao mat hang dat mua nguoc lai bao da co
            if (index == -1)
            {
                lstHangDatMua.Items.Add(curItem);
            }
            else
                MessageBox.Show("Hàng đặt mua đã có rồi!");
        }

        private void lstHangDatMua_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lstHangDatMua.SelectedIndex;
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes
                )
                lstHangDatMua.Items.RemoveAt(index);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
