using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishTest
{
    public partial class Bai1 : Form
    {
        public List<string> result = new List<string>();
        public List<TextBox> anw;
        public Bai1()
        {
            InitializeComponent();
        }

        private void Bai1_Load(object sender, EventArgs e)
        {
            result = new List<string>
            {
                "living",
                "playing",
                "playing",
                "listening to",
                "experience",
                "continued",
                "love",
                "hope",
                "share"
            };
            anw = new List<TextBox>
            {
                textBox1,
                textBox2,
                textBox3,
                textBox4,
                textBox5,
                textBox6,
                textBox7,
                textBox8,
                textBox9,
            };

            richTextBox1.Text = "I was born in a small village in the countryside. I grew up living (1) a simple life, surrounded by nature.I loved ____(2) in the fields and ____(3) with my friends.I also loved ____(4) stories about my grandparents' childhood.\r\n\r\nWhen I was 18, I moved to the city to go to college.It was a big change for me, but I was excited to ____(5) new things.I studied hard and made new friends.After college, I got a job and ____(6) to live in the city.\r\n\r\nI still miss my hometown, but I am happy with my life in the city.I ____(7) to visit my family and friends often.I also ____(8) to go back to my hometown someday and ____(9) my children about the simple life I grew up with.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "I was born in a small village in the countryside. I grew up living (1) a simple life, surrounded by nature.I loved playing (2) in the fields and playing (3) with my friends.I also loved listening to (4) stories about my grandparents' childhood.\r\n\r\nWhen I was 18, I moved to the city to go to college.It was a big change for me, but I was excited to experience (5) new things.I studied hard and made new friends.After college, I got a job and continued (6) to live in the city.\r\n\r\nI still miss my hometown, but I am happy with my life in the city.I love (7) to visit my family and friends often.I also hope (8) to go back to my hometown someday and share (9) my children about the simple life I grew up with.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int score = 0;
            int n = anw.Count;
            for(int i = 0; i < n; i++)
            {
                if (anw[i].Text == result[i])
                {
                    anw[i].BackColor = Color.Green;
                    score++;
                }
                else
                {
                    anw[i].BackColor = Color.Pink;
                }
            }
            MessageBox.Show("diem cua ban la : " + score);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(var item in anw)
            {
                item.BackColor = Color.White;
                item.Text = "";
            }
        }

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
