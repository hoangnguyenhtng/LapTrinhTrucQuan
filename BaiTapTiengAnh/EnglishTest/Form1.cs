using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishTest
{
    public partial class Form1 : Form
    {
		
		string ch;
		string chda;
		List<string> da;
		public Form1(String ddCH, string ddDA, string ddCHDA)
        {
			InitializeComponent();
            ch = QLFile.doccauhoi(ddCH);
            chda = QLFile.doccauhoi(ddCHDA);
            da = QLFile.docdapan(ddDA);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            QuanLyCauHoi qlch = new QuanLyCauHoi(ch,da,chda);
            
        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            bai1.Show();
        }

        private void bài1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BienDoiCau bienDoiCau = new BienDoiCau();
            bienDoiCau.Show();
            this.Hide();
        }

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

        
	}
}
