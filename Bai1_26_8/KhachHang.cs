using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_26_8
{
    internal class KhachHang

    {
        string ma, ten, dc;
        int tiengui, tgg;
        DateTime ngaygui;
        bool hinhthuc;

        public KhachHang()
        {
            hinhthuc = true; //loi gui thuong
        }
        public double tinhtien()
        {
            double s = 0;
            double tyle = 0.06F;
            switch (tgg)
            {
                case 1:
                    {
                        tyle = 0.06F;
                        break;
                    }
                case 3:
                    {
                        tyle = 0.07F;
                        break;
                    }
                case 6:
                    {
                        tyle = 0.08F;
                        break;
                    }
                case 12:
                    {
                        tyle = 0.09F;
                        break;
                    }
            }
            if (hinhthuc == false)          
                tyle += 0.01F;
            s = tiengui * (tyle / 12 * tgg + 1);   
            return s;
        }

        public override string ToString()
        {
            string s = ma + " " + ten + " " + dc + " " + ngaygui.ToString()
                + " " + tgg.ToString() + " " + tiengui + " ";
            if (hinhthuc == true) s += " thuong ";
            else s += " phat loc ";
            s += " tien lai " + tinhtien().ToString() + " "
                 + " tong tien " + (tiengui + tinhtien());
            return s;

        }

        public KhachHang(string ma, string ten, string dc, int tiengui, int tgg, DateTime ngaygui, bool hinhthuc)
        {
            this.ma = ma;
            this.ten = ten;
            this.dc = dc;
            this.tiengui = tiengui;
            this.tgg = tgg;
            this.ngaygui = ngaygui;
            this.hinhthuc = hinhthuc;
        }
    }
}
