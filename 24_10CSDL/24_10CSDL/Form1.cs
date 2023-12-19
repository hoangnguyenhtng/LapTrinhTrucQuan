using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_10CSDL
{
    public partial class Form1 : Form
    {
        ProcessDatabase pd = new ProcessDatabase();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // dgvDS.Columns[0].HeaderText = "Mã môn";
           // dgvDS.Columns[1].HeaderText = "Tên môn";
           // dgvDS.Columns[2].HeaderText = "Số tín chỉ";
           // dgvDS.Columns[3].HeaderText = "Điểm thi";

            dgvDS.DataSource = pd.DocBang("select * from Diem");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void btnThemDS_Click(object sender, EventArgs e)
        {
            // them vao bang diem
            if (KiemTraDL() == true)
            {
                string sql = "insert into Diem values ('" + int.Parse(txtMaMon.Text) + "', N'" + txtTenMon.Text + "', '" + int.Parse(txtTin.Text) + "' ,'" + float.Parse(txtDiem.Text) + "')";
                pd.CapNhat(sql);
                dgvDS.DataSource = pd.DocBang("select * from Diem");
            }

        }
        bool KiemTraDL()
        {
            bool k = true;
            if (txtMaMon.Text.Trim().Equals("") || txtTenMon.Text.Trim() == "" || txtDiem.Text.Trim() == ""
                || txtTin.Text.Trim() == "")
            { MessageBox.Show("Hay nhap du du lieu"); k = false; }
            else
            {

                if ((pd.DocBang("select * from Diem where MaMon='" + int.Parse(txtMaMon.Text) + "'")).Rows.Count > 0)
                { MessageBox.Show("Da co trung lap"); k = false; }
            }
            return k;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Xoa du lieu
            if(MessageBox.Show("Ban co muon xoa","Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                pd.CapNhat("delete Diem where MaMon='" +
                    int.Parse(txtMaMon.Text) + "'");
                dgvDS.DataSource = pd.DocBang("select * from Diem");
                
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            float tdiem = 0;
            int tongtc = 0;
            for(int i = 0; i < dgvDS.Rows.Count - 1; i++)
            {
                int tc = int.Parse(dgvDS.Rows[i].Cells[2].Value.ToString());
                float d = float.Parse(dgvDS.Rows[i].Cells[3].Value.ToString());
                tongtc += tc;
                tdiem += tc * d;
            }
            MessageBox.Show("Diem binh quan: " + (tdiem / tongtc).ToString());
        }

        private void dgvDS_Click(object sender, EventArgs e)
        {
            txtMaMon.Text = dgvDS.CurrentRow.Cells[0].Value.ToString();
            txtTenMon.Text = dgvDS.CurrentRow.Cells[1].Value.ToString();
            txtTin.Text = dgvDS.CurrentRow.Cells[2].Value.ToString();
            txtDiem.Text = dgvDS.CurrentRow.Cells[3].Value.ToString();
        }
    }
}

//Kiem tra rang buoc du lieu