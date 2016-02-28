/*
 * Created by SharpDevelop.
 * User: Multi12
 * Date: 1/2/2559
 * Time: 11:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace test_1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			int score = int.Parse(textBox1.Text);
			
			if(score >= 0 && score <= 59)
			{
				textBox2.Text = "Fail";
			}
			else if(score >= 60 && score <= 79)
			{
				textBox2.Text = "Pass";
			}
			else if(score >= 80 && score <= 100)
			{
				textBox2.Text = "Good";
			}
			else {textBox2.Text = "Error";}
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
