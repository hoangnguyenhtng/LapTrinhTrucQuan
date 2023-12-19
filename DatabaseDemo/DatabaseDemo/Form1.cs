using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseDemo
{
    public partial class Form1 : Form
    {
        ProcessDatabase pd = new ProcessDatabase();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtTenCL_TextChanged(object sender, EventArgs e)
        {     
        }

        private void frmChatLieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtChatLieu.DataSource = pd.DocBang("SELECT * FROM TBL_ChatLieu");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
