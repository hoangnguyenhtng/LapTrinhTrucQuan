using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HomeWork
{
    internal class Student
    {
        public Student(int maSV, string hoTen, string ngaySinh, string queQuan, double diemToan, double diemLy, double diemHoa)
        {
            MaSV = maSV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            QueQuan = queQuan;
            DiemToan = diemToan;
            DiemLy = diemLy;
            DiemHoa = diemHoa;
            DTB = (DiemToan + DiemLy + DiemHoa) / 3;
        }

        public Student()
        {
        }

        public int MaSV { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public double DiemToan { get; set; }
        public double DiemLy { get; set; }
        public double DiemHoa { get; set; }
        public double DTB { get; set; }


        public List<Student> Nhap(int n)
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap Ma Sinh Vien ");
                int msv = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhap Ho Ten Sinh Vien ");
                string name = Console.ReadLine();
                Console.WriteLine("Nhap Ngay Sinh ");
                string ngaysinh = Console.ReadLine();
                Console.WriteLine("Nhap Que Quan ");
                string quequan = Console.ReadLine();
                Console.WriteLine("Nhap Diem Toan ");
                double toan = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Nhap Diem Ly ");
                double ly = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Nhap Diem Hoa ");
                double hoa = Convert.ToDouble(Console.ReadLine());
                students.Add(new Student(msv, name, ngaysinh, quequan, toan, ly, hoa));
            }

            return students;
        }
        public void In(List<Student> arr)
        {
            Console.WriteLine("Danh sach sinh vien:");
            Console.WriteLine("MSV      Ten Sinh Vien       Ngay Sinh       Que Quan            Diem Toan   Diem Ly     Diem Hoa    DTB");
            foreach (var item in arr)
            {
                Console.Write(item.ToString());
            }
        }

        public override string? ToString()
        {
            return MaSV + "     " + HoTen + "     " + NgaySinh + "       " + QueQuan + "             " + DiemToan + "      " + DiemLy + "       " + DiemHoa + "      " + DTB;
        }
        public void SearchStudentWithMaSv(int msv, List<Student> arr)
        {
            Student temp = new Student();

            foreach (var item in arr)
            {
                if (item.MaSV == msv)
                {
                    Console.WriteLine(item.ToString());
                }
                else
                {
                    Console.WriteLine("Khong tim thay sinh vien co ma sinh vien {0}", msv);
                }
            }

        }
        public List<Student> listStudent(List<Student> arr)
        {
            List<Student> students = new List<Student>();
            foreach (var student in arr)
            {
                if (student.DTB >= 7)
                {
                    students.Add(student);
                }
            }
            return students;

        }
    }
}
