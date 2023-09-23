using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp228
{
    internal class Sach
    {
        private string ma;
        private string ten, tg;
        int sl;

        public Sach(string ma, string ten, string tg, int sl)
        {
            this.ma = ma;
            this.ten = ten;
            this.tg = tg;
            this.sl = sl;
        }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Tg { get => tg; set => tg = value; }
        public int Sl { get => sl; set => sl = value; }

        public override string ToString()
        {
            return ma + " " + ten + " " + tg + " " + sl.ToString();
        }
    }
}
