﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vd01
{
    public partial class Form2 : Form
    {
        List<NguoiGui> listNguoiGuis = new List<NguoiGui>();
        public Form2()
        {
            InitializeComponent();
            listNguoiGuis = StaticData._NguoiGui;
        }

        private void bntTim_Click(object sender, EventArgs e)
        {
            int timthay = 0;

            foreach (NguoiGui i in listNguoiGuis)

            {

                if (i.MaKH1 == Convert.ToInt32(txtTim.Text))

                {

                    timthay = 1;

                    label2.Text = "Khách hàng " + i.TenKH1 + "phải trả"

                        + i.Tien1 + " nghìn đồng";



                }
            }



            if (timthay == 0)

            {

                label2.Text = "Khách hàng " + txtTim.Text + " không có trong danh sách";



            }
        }
    }
}
