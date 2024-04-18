/*
 * Created by SharpDevelop.
 * User: g
 * Date: 15/04/2024
 * Time: 7:01 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WAP_SORIZO_BSCS1B
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
		
	
		

		
		void BttnSubmitClick(object sender, EventArgs e)
		{		
			string userName = txtSignUser.Text;
			string passWord = txtSignPass.Text;
				
			if (txtBoxUser.Text.Equals(userName) && txtBoxPass.Text.Equals(passWord) ) {
				frmLogin f2 = new frmLogin();
				f2.Show();
				this.Hide();
			}
			else{
				MessageBox.Show("Incorect Username or Password!"); }
		}
		
	
		
		void BttnNewAccClick(object sender, EventArgs e)
		{
			pnlLogin.SendToBack();
		}
		
		
		
		void CheckPassCheckedChanged(object sender, EventArgs e)
		{
			if (checkPass.CheckState == CheckState.Checked) {
				txtSignPass.UseSystemPasswordChar = false;
				txtSignConPass.UseSystemPasswordChar = false;
			}
			else{
				txtSignPass.UseSystemPasswordChar = true;
				txtSignConPass.UseSystemPasswordChar = true;
			}
		}
		
		void BttnSignupClick(object sender, EventArgs e)
		{
			pnlSignup.SendToBack();
		}
	}
}

			
		