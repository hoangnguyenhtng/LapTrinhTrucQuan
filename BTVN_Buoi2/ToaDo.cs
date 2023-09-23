using System.Reflection.Metadata;

namespace Buoi2
{
    public class ToaDo
    {
        public ToaDo()
        {
            X = 0;
            Y = 0;
        }
        public ToaDo(double x, double y)
        {
            this.X = X;
            this.Y = Y;
        }

        private double X { get; set; }
        private double Y { get; set; }
        public void Nhap()
        {
            Console.Write("Nhap Toa Do x ");
            X = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap Toa Do y ");
            Y = Convert.ToDouble(Console.ReadLine());
        }
        public  override string ToString(){
            return $"({X},{Y})";
        }
        public double KhoangCach(ToaDo toaDo){
            return Math.Sqrt((X - toaDo.X)*(X - toaDo.X) + (Y - toaDo.Y)*(Y - toaDo.Y));
        }
    }
}