using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            for (int i = num; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    textBox2.Text += j.ToString();

                }
                textBox2.Text += "\r\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            for (int i = 1; i <= num; i++)
             {
                 for (int j = 1; j <= i; j++)
                 {
                     textBox2.Text += j.ToString();

                 }
                 textBox2.Text += "\r\n";
             }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    textBox2.Text += j.ToString();

                }
                textBox2.Text += "\r\n";
            }
        }
    }
}
