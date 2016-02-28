using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            int count = int.Parse(textBox1.Text);
            textBox2.Text = "วนรอบจำนวน " + count.ToString() + " รอบ \r\n";

            for (int i = 0; i < count; i++) 
            {
                textBox2.Text += "วนรอบที่ " + (i+1) + "\r\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = int.Parse(textBox1.Text);
            textBox2.Text = "วนรอบจำนวน " + count.ToString() + " รอบ \r\n";

            for (int i = count; i > 0; i--)
            {
                textBox2.Text += "วนรอบที่ " + i + "\r\n";
            }
        }
    }
}
