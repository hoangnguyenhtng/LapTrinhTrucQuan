using System.Buffers;
using System.Globalization;

namespace BVN_Buoi1
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
        public double TimMax(int n, double[] arr)
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
        public double Tong(int n, double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }
        //Đếm tổng các số âm
        public int DemSoAm(int n, double[] arr)
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
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Student st = new Student();
            List<Student> students = st.Nhap(n);
            st.In(students);
        }
    }
}