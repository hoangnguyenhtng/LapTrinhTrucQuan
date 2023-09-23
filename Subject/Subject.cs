using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonHoc
{
    internal class Subject
    {
        public Subject(string tenMon="", int soTin=0, int diem=0)
        {
            TenMon = tenMon;
            SoTin = soTin;
            Diem = diem;
        }

        public string TenMon { get; set; }
        public int SoTin { get; set; }
        public int Diem { get; set; }
        public int DiemTheoTin()
        {
            return Diem * SoTin;
        }

    }
}
