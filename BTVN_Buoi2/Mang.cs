using System.ComponentModel.DataAnnotations.Schema;

namespace Buoi2
{
    public class Mang
    {
        private int N { get; set; }
        private int[] Arr { get; set; }
        public Mang(int n)
        {
            Arr = new int[N];
        }
        public void Nhap()
        {
            Console.Write("Nhap vao day so nguyen: ");
            for (int i = 0; i < N; i++)
            {
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void In()
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write(Arr[i] + " ");
            }
        }
        public void SapXep(int thutu)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (thutu == 0 && Arr[i] > Arr[j])
                    {
                        int temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }
                    if (thutu == 1 && Arr[i] < Arr[j])
                    {
                        int temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }
                }
            }
        }
        public int TiemKiem(int m)
        {
            
            for(int i=0;i<N;i++){
                if(Arr[i] == m){
                    return i;
                }
            }
            return -1;
        }
    }
}