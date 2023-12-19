using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace ThiGiuaKy


{

	public partial class Form1 : Form
	{

		DatabaseProcess dtbase = new DatabaseProcess();
		public Form1()
		{
			InitializeComponent();
		}

		private void AddComboBox()
		{
			cbLoai.Items.Add("Âm nhạc");
			cbLoai.Items.Add("Truyện ngắn");
			cbLoai.Items.Add("Kí sự");
			cbLoai.Items.Add("Truyện tranh");
			cbLoai.Items.Add("Truyện dài tập");
			cbLoai.Items.Add("Phóng sự");
		}


		private void btnThem_Click(object sender, EventArgs e)
		{
			string sql = $"insert into Sach values ('{txtMaTacPham.Text}',N'{txtTenTacPham.Text}',N'{txtTacGia.Text}',N'{cbLoai.Text}')";

			dtbase.DataChange(sql);
			//Cap nhat lai DataGrid
			sql = "Select * from Sach";
			dgDS.DataSource = dtbase.DataReader(sql);
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string sql = "Update Sach SET ";
			sql += "MaSP = N'" + txtMaTacPham.Text + "',";
			sql += "TenTacPham = N'" + txtTenTacPham.Text + "',";
			sql += "TenTacGia = N'" + txtTenTacPham.Text + "',";
			sql += "Loai = N'" + cbLoai.Text + "',";

			dtbase.DataChange(sql);
			//Cap nhat lai DataGrid
			sql = "Select * from Sach";
			dgDS.DataSource = dtbase.DataReader(sql);
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			String sql = "Delete From Sach Where MaTP =N'" + txtMaTacPham.Text + "'";

			dtbase.DataChange(sql);
			//Cap nhat lai DataGrid
			sql = "Select * from Sach";
			dgDS.DataSource = dtbase.DataReader(sql);
		}

		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			txtMaTacPham.Text = "";
			txtTacGia.Text = "";
			txtTenTacPham.Text = "";
			cbLoai.Text = "";

			String sql = "Select * from Sach";
			dgDS.DataSource = dtbase.DataReader(sql);

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			AddComboBox();
			this.KeyPreview = true;

			//Load dữ liệu lên DataGridView
			dgDS.DataSource = dtbase.DataReader("Select * from Sach");
			//Ẩn nút Sửa,xóa

		}

		private void dgDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			txtMaTacPham.Text = dgDS[0, e.RowIndex].Value.ToString();
			txtTenTacPham.Text = dgDS[1, e.RowIndex].Value.ToString();
			txtTacGia.Text = dgDS[2, e.RowIndex].Value.ToString();
			cbLoai.Text = dgDS[3, e.RowIndex].Value.ToString();
		}

		private void btnXuat_Click(object sender, EventArgs e)
		{
			//DataTable dsIn = dtbase.DataReader("select * from Sach");
			//if (dsIn.Rows.Count > 0) //TH có dữ liệu để ghi
			//{
			//	//Khai báo và khởi tạo các đối tượng
			//	Excel.Application exApp = new Excel.Application();
			//	Excel.Workbook exBook =
			//   exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
			//	Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
			//	//Định dạng chung
			//	Excel.Range ten = (Excel.Range)exSheet.Cells[1, 1];
			//	ten.Font.Size = 12;
			//	ten.Font.Bold = true;
			//	ten.Font.Color = Color.Blue;
			//	ten.Value = "Danh sach ";

			//	Excel.Range header = (Excel.Range)exSheet.Cells[5, 2];
			//	exSheet.get_Range("B5:G5").Merge(true);
			//	header.Font.Size = 13;
			//	header.Font.Bold = true;
			//	header.Font.Color = Color.Red;
			//	header.Value = "DANH SÁCH CÁC Sách";
			//	//Định dạng tiêu đề bảng

			//	exSheet.get_Range("A7:G7").Font.Bold = true;
			//	exSheet.get_Range("A7:G7").HorizontalAlignment =
			//   Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
			//	exSheet.get_Range("A7").Value = "Mã Tác Phẩm";
			//	exSheet.get_Range("B7").Value = "Tên Tác phẩm";
			//	exSheet.get_Range("C7").Value = "Tên Tác Giả";
			//	exSheet.get_Range("D7").Value = "Loại";
			//	//In dữ liệu
			//	for (int i = 0; i < dsIn.Rows.Count; i++)
			//	{
			//		exSheet.get_Range("A" + (i + ToString() + ":G" + (i +
			//	   😎.ToString()).Font.Bold = false;
			//		exSheet.get_Range("A" + (i + .ToString()).Value = (i +
			//	   1).ToString();
			//		exSheet.get_Range("B" + (i + .ToString()).Value =
			//	   dsIn.Rows[i]["MaTP"].ToString();
			//		exSheet.get_Range("C" + (i + .ToString()).Value =
			//	   dsIn.Rows[i]["TenTacPham"].ToString();
			//		exSheet.get_Range("D" + (i + .ToString()).Value =
			//	   dsIn.Rows[i]["TenTacGia"].ToString();
			//		exSheet.get_Range("E" + (i + .ToString()).Value =
			//	   dsIn.Rows[i]["Loai"].ToString();
			//	}
			//	exSheet.Name = "Hang";
			//	exBook.Activate(); //Kích hoạt file Excel
			//					   //Thiết lập các thuộc tính của SaveFileDialog
			//	saveFileDialog1.Filter = "Excel Document(.xls)|.xls |Word Document(.doc) | *.doc | All files(.*) | . ";
			//	saveFileDialog1.FilterIndex = 1;
			//	saveFileDialog1.AddExtension = true;
			//	saveFileDialog1.DefaultExt = ".xls";
			//	if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			//		exBook.SaveAs(saveFileDialog1.FileName.ToString());//Lưu file Excel
			//	exApp.Quit();//Thoát khỏi ứng dụng
			//}
			//else MessageBox.Show("Không có danh sách hàng để in");
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			if (txtTenTacPham.Text.Trim().Length > 0)
			{
				string sql = $"select * from Sach where TenTacPham like N'%{txtTenTacPham.Text}%'";
				dgDS.DataSource = dtbase.DataReader(sql);

			}
			else
			{
				MessageBox.Show("Hay Nhap tac pham can tim");
			}
		}
	}
}
