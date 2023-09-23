using Buoi2;

namespace Buoi2
{
    internal class Program
    {    
        static object Main(string[] args)
        {
            //Phân số
            Console.WriteLine("Bai 1: Phan so");
            PhanSo ps1 = new PhanSo();
            PhanSo ps2 = new PhanSo();
            ps1.Nhap();
            ps2.Nhap();
            ps1.In(ps1);
            ps2.In(ps2);
            PhanSo.SimplifyFraction(ps1);
            PhanSo.SimplifyFraction(ps2);
            ps1.Tong(ps2);
            ps1.Hieu(ps2);
            ps1.Tich(ps2);
            ps1.Thuong(ps2);

            //Điểm
            Console.WriteLine("Bai 2: Toa do");
            ToaDo toaDo1 = new ToaDo();
            ToaDo toaDo2 = new ToaDo();
            toaDo1.Nhap();
            toaDo2.Nhap();
            toaDo1.ToString();
            toaDo2.ToString();
            toaDo1.KhoangCach(toaDo2);

            //Mảng 1 chiều
            Console.WriteLine("Bai 3: Mang 1 chieu");
            Console.WriteLine("Nhap do dai mang: ");
            //Ma trận

            //Nhân viên

            //Sinh viên
            return 0;

        }
    }
}