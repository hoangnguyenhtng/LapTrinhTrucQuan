using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp228
{
    internal class Sach1 : Sach
    {
        private string qr;

        public Sach1(string ma = " ", string ten = " ", string tg = " ", int sl = 0 , string qr = " ") : base(ma, ten, tg, sl)
        {
            this.qr = qr;
        }

        public string Qr { get => qr; set => qr = value; }

        public override string ToString()
        {
            return base.ToString() + " " +  qr;
        }
    }
}
