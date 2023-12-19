using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlSinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con; //Đối tượng để kết nối
        DataTable tblSinhvien; //Đối tượng lưu bảng sinh viên
        public void Connect() //Kết nối
        {
            //Khởi tạo đối tượng
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\VisualStudio\\QlSinhVien\\QlSinhVien.mdf;Integrated Security=True"); 
            con.Open(); //Mở kết nối
        }
        public void Disconnect() //Ngắt kết nối
        {
            if (con.State == ConnectionState.Open) //nếu đang mở
            {
                con.Close(); //đóng
                con.Dispose(); //huỷ
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connect();
            string sql;
            sql = "select * from SinhVien";
            SqlDataAdapter MyData = new SqlDataAdapter(sql, con); //Đối tượng 
            tblSinhvien = new DataTable(); //Khởi tạo bảng
            MyData.Fill(tblSinhvien); //Đổ dữ liệu từ DataAdapter vào bảng
            DataGridView.DataSource = tblSinhvien;
            Disconnect();
        }

        private void LoadDataGridView()
        {
            Connect();
            string sql;
            sql = "select * from SinhVien";
            SqlDataAdapter MyData = new SqlDataAdapter(sql, con); //Đối tượng 
            tblSinhvien = new DataTable(); //Khởi tạo bảng
            MyData.Fill(tblSinhvien); //Đổ dữ liệu từ DataAdapter vào bảng
            DataGridView.DataSource = tblSinhvien;
            Disconnect();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void RunSQL(string sql) //Thực hiện một câu lệnh SQL
        {
            SqlCommand cmd = new SqlCommand(); //Đối tượng để thực hiện lệnh
            cmd.CommandText = sql;
            cmd.Connection = con;
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Connect();
            string sql;
            sql = "UPDATE SinhVien SET Hoten='" + txtHoTen.Text +
            "',Ngaysinh='" + txtNgaySinh.Text +
            "',Khoa='" + txtKhoa.Text + "',Lop='" + txtLop.Text +
            "',Diachi='" + txtDiaChi.Text + "' WHERE MaSV='" + txtMaSV.Text + "'";
            RunSQL(sql); //thực hiện lệnh sql
            Disconnect();
            LoadDataGridView(); //hiển thị lại thông tin lên DataGridView
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Connect();
            string sql;
            sql = "SELECT MaSV FROM SinhVien WHERE MaSV=N'" + txtMaSV.Text + "'";
            SqlDataAdapter MyData = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            MyData.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Mã sinh viên này đã tồn tại"); return;
            }
            //Thực hiện chèn thêm mới
            sql = "INSERT INTO SinhVien VALUES ('" + txtMaSV.Text + "','" + txtHoTen.Text + "','" +
            txtNgaySinh.Text + "','" + txtKhoa.Text + "','" + txtLop.Text + "','" + txtDiaChi.Text +
            "')";
            RunSQL(sql);
            Disconnect();
            LoadDataGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {   
            Connect();
            string sql;
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE SinhVien WHERE MaSV='" + txtMaSV.Text + "'";
                RunSQL(sql);
                Disconnect();
                LoadDataGridView();
            }
        }
    }
}
