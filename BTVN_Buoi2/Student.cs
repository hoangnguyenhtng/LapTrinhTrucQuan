using System.ComponentModel;

namespace Buoi2
{
    public class Student
    {
        public Student()
        {
            LapTrinh = 0;
            CSDL = 0;
            TKWeb = 0;
            NgaySinh = "";
            HoTen = "";
        }
        public Student(string hoten, string ngaysinh, float laptrih, float csdl, float tkweb)
        {
            this.HoTen = hoten;
            this.NgaySinh = ngaysinh;
            this.LapTrinh = laptrih;
            this.CSDL = csdl;
            this.TKWeb = tkweb;
        }

        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public float LapTrinh { get; set; }
        public float CSDL { get; set; }
        public float TKWeb { get; set; }

        internal void nhap()
        {
            Console.WriteLine("nhap vao ho ten");
            HoTen = Console.ReadLine();
            Console.WriteLine("nhap vao ngay sinh");
            NgaySinh = Console.ReadLine();
            Console.WriteLine("nhap vao diem mon lap trinh");
            LapTrinh = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap vao diem mon CSDL");
            CSDL = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap vao diem mon Thiet ke web");
            TKWeb = float.Parse(Console.ReadLine());
        }
        public float TB()
        {
            return (LapTrinh + CSDL + TKWeb) / 3;
        }
        public void Xuat(){
            Console.WriteLine(HoTen +" " + NgaySinh +" " + LapTrinh+" " + CSDL +" " + TKWeb);
        }
    }
    public class ManageStudent
    {
        public ManageStudent()
        {
            N = 0;
        }

        public int N { get; set; }
        public Student[] ds { get; set; }

        public void Nhap()
        {
            Console.WriteLine("Nhap vao so luong sinh vien");
            N = int.Parse(Console.ReadLine());
            ds = new Student[N];
            Console.WriteLine("Nhap vao danh sach sinh vien");
            for (int i = 0; i < N; i++)
            {
                ds[i] = new Student();
                ds[i].nhap();
            }
        }

        public void SinhVienDuDieuKien()
        {
            int cnt = 0;
            int cnt2 = 0;
            for (int i = 0; i < N; i++)
            {
                if (ds[i].LapTrinh > 5 && ds[i].CSDL > 5 && ds[i].TKWeb > 5)
                {
                    cnt++;
                    if (ds[i].TB() >= 8)
                    {
                        cnt2++;
                    }
                }

            }
            Console.WriteLine("So luong sinh vien duoc lam khoa luan la {0} va so luong sinh vien du dieu kien lam chuyen de tot nghiep la {1}",cnt,cnt2);
        }
    }
}