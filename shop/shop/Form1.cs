using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = int.Parse(textBox1.Text); //ราคาสินค้าทั้งหมด
            int pay = int.Parse(textBox2.Text); //เงินที่ลูกค้าจ่ายมา

            int n = 0; //เงินทอน

            n = pay - price;

            int count1 = 0; //นับแบงค์ 500
            int count2 = 0; //นับแบงค์ 100
            int count3 = 0; //นับแบงค์ 50
            int count4 = 0; //นับแบงค์ 20
            int count5 = 0; //นับเหรียญ 10
            int count6 = 0; //นับเหรียญ 5
            int count7 = 0; //นับเหรียญ 1

            textBox3.Text = n.ToString();
            
            for (int i = 0; i <= n; i++ )
            {
                if (n > 500)
                {
                    n = n - 500;
                    count1++;
                }
                if (n >= 100) 
                {
                    n = n - 100;
                    count2++;
                }
                if (n >= 50)
                {
                    n = n - 50;
                    count3++;
                }
                if (n >= 20) 
                {
                    n = n - 20;
                    count4++;
                }
                if (n >= 10)
                {
                    n = n - 10;
                    count5++;
                }
                if (n >= 5)
                {
                    n = n - 5;
                    count6++;
                }
                if (n >= 1)
                {
                    n = n - 1;
                    count7++;
                    i--;
                }
            }
            
            textBox4.Text = "ธนบัตร 500 บาท \t จำนวน " + count1 + " ใบ \r\n";
            textBox4.Text += "ธนบัตร 100 บาท \t จำนวน " + count2 + " ใบ \r\n";
            textBox4.Text += "ธนบัตร 50 บาท \t จำนวน " + count3 + " ใบ \r\n";
            textBox4.Text += "ธนบัตร 20 บาท \t จำนวน " + count4 + " ใบ \r\n";
            textBox4.Text += "เหรียญ 10 บาท \t จำนวน " + count5 + " เหรียญ \r\n";
            textBox4.Text += "เหรียญ 5 บาท \t จำนวน " + count6 + " เหรียญ \r\n";
            textBox4.Text += "เหรียญ 1 บาท \t จำนวน " + count7 + " เหรียญ \r\n";
        }
    }
}
