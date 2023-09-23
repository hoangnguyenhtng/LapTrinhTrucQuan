using System.Numerics;

namespace Buoi2
{
    public class MaTran
    {
        private int M { get; set; }
        private int N { get; set; }
        private int[,] Arr { get; set; }
        public MaTran(int m, int n)
        {
            this.M = m;
            this.N = N;
        }

        public MaTran()
        {
            M = 0;
            N = 0;
        }

        public void Nhap()
        {
            Console.WriteLine("nhap so hang");
            M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap so cot");
            N = Convert.ToInt32(Console.ReadLine());
            //tao 2mang chua du lieu
            Arr = new int[M, N];
            Console.WriteLine("Moi Nhap vao ma tran");
            for (var i = 0; i < Arr.GetLength(1); ++i)
                for (var j = 0; j < Arr.GetLength(0); ++j)
                    Arr[i, j] = Convert.ToInt32(Console.ReadLine());

        }
        public void In()
        {
            Console.WriteLine("Ma Tran ");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(Arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public MaTran Cong(MaTran b)
        {
            if (M != b.M || N != b.N)
            {
                throw new ArgumentException("Hai Ma tran phai co cung kich thuoc");
            }
            var c = new MaTran(M, N);
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    c.Arr[i, j] = Arr[i, j] + b.Arr[i, j];
                }
            }
            return c;
        }
        public MaTran Tru(MaTran b)
        {
            if (M != b.M || N != b.N)
            {
                throw new ArgumentException("Hai Ma tran phai co cung kich thuoc");
            }
            var c = new MaTran(M, N);
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    c.Arr[i, j] = Arr[i, j] - b.Arr[i, j];
                }
            }
            return c;
        }
        public MaTran Tich(MaTran b)
        {
            if (N != b.M) throw new ArgumentException("khong the nhan hai ma tran nay");
            var res = new MaTran(M, b.N);

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    res.Arr[i, j] += Arr[i, j] * b.Arr[i, j];
                }
            }
            return res;
        }
        public MaTran ChuyenVi()
        {
            var transposeMatrix = new MaTran(N, M);

            // Lặp qua các phần tử của ma trận
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    // Lưu giá trị của phần tử vào ma trận chuyển vị
                    transposeMatrix.Arr[j, i] = Arr[i, j];
                }
            }

            // Trả về ma trận chuyển vị
            return transposeMatrix;
        }
        public void CheckMaTranVuong(){
        Console.WriteLine(  (M == N) ? "day la ma tran vuong" : "day khong phai la ma tran vuong");
    }
    }
    
}