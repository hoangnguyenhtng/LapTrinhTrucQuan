using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace EnglishTest
{
    public partial class BienDoiCau : Form
    {
        public BienDoiCau()
        {
            InitializeComponent();
        }

		private void label4_Click(object sender, EventArgs e)
		{
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Succeeded in doing\r\nHad better do something\r\nApologise to somone for doing something\r\nWould rather do something than do something else\r\nI wish I had done\r\nSuch +noun +that\r\nIn spite of + noun/ doing something\r\nAlthough + Clause\r\nTo be too + adj for somebody to do something", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}
	}
}
