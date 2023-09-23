using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class PhanSo
    {
        public PhanSo(int tuso, int mauso)
        {
            this.Tuso = tuso;
            this.Mauso = mauso;
        }
        public PhanSo()
        {
            Tuso = 0;
            Mauso = 1;
        }

        public int Tuso { get; set; }
        public int Mauso { get; set; }

        public void Nhap()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            Tuso = t;
            Mauso = m;
        }
        public PhanSo Tong(PhanSo a)
        {
            PhanSo c = new PhanSo();
            if(this.Mauso == a.Mauso)
            {
                c.Tuso = a.Tuso + this.Tuso;
                c.Mauso = a.Mauso;
            }
            else
            {
                c.Tuso = a.Mauso * Tuso + Mauso * a.Tuso;
                c.Mauso = a.Mauso * Mauso;
            }
            SimplifyFraction(c);
            return c;
        }
        public PhanSo Hieu(PhanSo a)
        {
            PhanSo c = new PhanSo();
            if (this.Mauso == a.Mauso)
            {
                c.Tuso = a.Tuso - this.Tuso;
                c.Mauso = a.Mauso;
            }
            else
            {
                c.Tuso = Mauso * a.Tuso - a.Mauso * Tuso;
                c.Mauso = a.Mauso * Mauso;
            }
            SimplifyFraction(c);
            return c;
        }
        public PhanSo Tich(PhanSo a)
        {
            PhanSo c = new PhanSo();
            c.Tuso = a.Tuso * Tuso;
            c.Mauso = a.Mauso * Mauso;
        
            return c;

        }
        public PhanSo Thuong(PhanSo a)
        {
            PhanSo c = new PhanSo(a.Mauso, a.Tuso);
            c.Tuso = a.Tuso * Tuso;
            c.Mauso = a.Mauso * Mauso;
            return SimplifyFraction(c);
        }

        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static PhanSo SimplifyFraction(PhanSo fraction)
        {
            int gcd = GCD(fraction.Tuso, fraction.Mauso);
            fraction.Tuso /= gcd;
            fraction.Mauso /= gcd;
            return fraction;
        }
        public override string ToString()
        {
            return $"{Tuso}/{Mauso}";
        }
    }
}
