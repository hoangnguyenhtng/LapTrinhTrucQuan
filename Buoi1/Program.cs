using Buoi1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    internal class Program
    {
        //Nhập một Dãy các Số nguyên
        public static void Nhap(int n, int[] arr)
        {
            Console.Write("Nhap vao day so ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        //In dãy các số nguyên 
        public static void InDay(int n, int[] arr)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

        }
        //sắp xếp tăng dần
        public static void SapXep(int[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine("day sau sap xep la: ");
            InDay(arr.Length, arr);
        }
        //Nhập dãy số thực
        public static void NhapSoThuc(int n, double[] arr)
        {
            Console.Write("Nhap vao day so ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        //Tìm max của dãy số thực
        public static double TimMax(int n, double[] arr)
        {
            double max = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        //tinh tong cac so co trong day
        public static double Tong(int n, double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }
        //Đếm tổng các số âm
        public static int DemSoAm(int n, double[] arr)
        {
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    cnt++;
                }
            }
            return cnt;
        }
        static object Main(string[] args)
        {
            // Ung dung Student
            int n = Convert.ToInt32(Console.ReadLine());
            Student st = new Student();
            List<Student> students = st.Input(n);
            st.Output(students);

            int msv = Convert.ToInt32(Console.ReadLine());
            st.SearchStudentWithMaSv(msv, students);
            return 0;

            // Ung dung Phan so
            PhanSo phanSo1 = new PhanSo();
            PhanSo PhanSo2 = new PhanSo();
            phanSo1.Nhap();
            PhanSo2.Nhap();
            phanSo1.Tong(PhanSo2);
            phanSo1.Hieu(PhanSo2);
            phanSo1.Tich(PhanSo2);
            phanSo1.Thuong(PhanSo2);

            //Ung dung day so
            int t = Convert.ToInt32(Console.ReadLine());
            Program daySo = new Program();
            int[] arr = new int[t];
            Console.WriteLine("In day nguyen");
            Program.Nhap(t, arr);
            Program.InDay(t, arr);
            Program.SapXep(arr);
            
            //Nhap day so thuc
            int th = Convert.ToInt32(Console.ReadLine());
            Program daySoThuc = new Program(); 
            double[] arr2 = new double[t];
            Console.WriteLine("In day so thuc");
            Program.NhapSoThuc(th, arr2);
            Program.TimMax(th, arr2);
            Program.Tong(th, arr2);
            Program.DemSoAm(th, arr2);
        }
    }
}
