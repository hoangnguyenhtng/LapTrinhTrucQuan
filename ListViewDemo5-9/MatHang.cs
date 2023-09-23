using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewDemo5_9
{
    internal class MatHang
    {
        string ma, ten;
        int soluong;

        public MatHang()
        {

        }

        public MatHang(string ma="", string ten="", int soluong=0)
        {
            this.ma = ma;
            this.ten = ten;
            this.soluong = soluong;
        }

        public string Ma { get => ma; set => ma = value; }

        public int Contains(string m)
        {
            if (string.CompareOrdinal(ma, m) == 0)
                return 1;
            return 0;
        }
    }
}
