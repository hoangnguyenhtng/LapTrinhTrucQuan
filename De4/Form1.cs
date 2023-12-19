using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De4
{
    public partial class Form1 : Form
    {
        Dictionary<string,string> data = new Dictionary<string,string>();
        string selectCountry = "";
        string selectCapitl = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void Emptyoption()
        {
            foreach (Control control in Capital.Controls)
            {
                if(control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ban co muon thoat khong", "Thong bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

      
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if(radioButton.Checked )
            {
                selectCountry = radioButton.Text;
                lblCountry.Text = "Ban Hay Chon Thu Do Cua "+ selectCountry;
            }
            Emptyoption();

        }
        private void radioButton_CheckedChanged2(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                selectCapitl = radioButton.Text;
            }
            if(data.ContainsKey(selectCountry) && data[selectCountry].Equals(selectCapitl))
            {
                lblCountry.Text = $" Ban Da doan dung thanh pho cua {selectCountry} la : {selectCapitl}";
            }
            else
            {
                lblCountry.Text = $"Thu do cua {selectCountry} khong phai {selectCapitl}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data.Add("Japan", "Tokyo");
            data.Add("France", "Paris");
            data.Add("Hungary", "Budapest");
            data.Add("Spain", "Marid");
            data.Add("Turkey", "Ankara");
            data.Add("The UK", "London");
            data.Add("Italy", "Rome");
            data.Add("The USA", "Buenos Aires");
            foreach (Control control in Country.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.CheckedChanged += radioButton_CheckedChanged;
                }
            }
            foreach (Control control in Capital.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.CheckedChanged += radioButton_CheckedChanged2;
                }

            }
            Emptyoption();

        }

    }
   
}
