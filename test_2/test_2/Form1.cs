using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            String day = textBox1.Text ;

            switch(day)
            {
                case "จันทร์": 
                    MessageBox.Show("วันนี้วัน" + textBox1.Text + " สีเหลือง");
                    this.BackColor = Color.Yellow;
                    break;

                case "อังคาร": 
                    MessageBox.Show("วันนี้วัน" + textBox1.Text + " สีชมพู");
                    this.BackColor = Color.Pink;
                    break;

                case "พุธ": 
                    MessageBox.Show("วันนี้วัน" + textBox1.Text + " สีเขียว");
                    this.BackColor = Color.Green;
                    break;

                case "พฤหัสบดี": 
                    MessageBox.Show("วันนี้วัน" + textBox1.Text + " สีส้ม");
                    this.BackColor = Color.Orange;
                    break;

                case "ศุกร์": 
                    MessageBox.Show("วันนี้วัน" + textBox1.Text + " สีฟ้า");
                    this.BackColor = Color.SkyBlue;
                    break;

                case "เสาร์": 
                    MessageBox.Show("วันนี้วัน" + textBox1.Text + " สีม่วง");
                    this.BackColor = Color.Violet;
                    break;

                case "อาทิตย์": 
                    MessageBox.Show("วันนี้วัน" + textBox1.Text + " สีแดง");
                    this.BackColor = Color.Red;
                    break;
            }
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
