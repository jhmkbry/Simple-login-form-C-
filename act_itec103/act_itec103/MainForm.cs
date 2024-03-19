/*
 * Created by SharpDevelop.
 * User: LENOVO T470
 * Date: 28/02/2024
 * Time: 8:21 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace act_itec103
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
		
		void Button1Click(object sender, EventArgs e){
			
			string x = "admin123";
			string y = "pass123";
			
			string user = Convert.ToString(richTextBox1.Text);
			string pass = Convert.ToString(richTextBox2.Text);
			
			
			if (user == x && pass==y){
				MessageBox.Show("Welcome you have logged in succesfully");
			//	Form1 f1 = new Form1();
			//	f1.Show();
			//	Visible=false;
			//	Close();

			}
			
			else  {
				MessageBox.Show("Welcome you have failed to logged in ");
			//	Form2 f2 = new Form2();
				//f2.Show();
				//Visible=false;
			//	Close();
			}
	
			
			
			
		}
		void RichTextBox1TextChanged(object sender, EventArgs e)
		{
			
	
		}
		void Label3Click(object sender, EventArgs e)
		{
			
			
		}
		
		
	}
}
