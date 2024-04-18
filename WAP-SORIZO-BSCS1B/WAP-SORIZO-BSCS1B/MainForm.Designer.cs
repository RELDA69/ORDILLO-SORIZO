/*
 * Created by SharpDevelop.
 * User: g
 * Date: 15/04/2024
 * Time: 7:01 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace WAP_SORIZO_BSCS1B
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.txtFb1 = new System.Windows.Forms.Label();
			this.txtBoxUser = new System.Windows.Forms.TextBox();
			this.txtBoxPass = new System.Windows.Forms.TextBox();
			this.bttnSubmit = new System.Windows.Forms.Button();
			this.pnlLogin = new System.Windows.Forms.Panel();
			this.bttnNewAcc = new System.Windows.Forms.Button();
			this.txtFb2 = new System.Windows.Forms.Label();
			this.pnlSignup = new System.Windows.Forms.Panel();
			this.checkPass = new System.Windows.Forms.CheckBox();
			this.bttnSignup = new System.Windows.Forms.Button();
			this.txtSignConPass = new System.Windows.Forms.TextBox();
			this.txtSignPass = new System.Windows.Forms.TextBox();
			this.txtSignUser = new System.Windows.Forms.TextBox();
			this.pnlLogin.SuspendLayout();
			this.pnlSignup.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtFb1
			// 
			this.txtFb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFb1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.txtFb1.Location = new System.Drawing.Point(87, 129);
			this.txtFb1.Name = "txtFb1";
			this.txtFb1.Size = new System.Drawing.Size(393, 93);
			this.txtFb1.TabIndex = 0;
			this.txtFb1.Text = "facebook";
			// 
			// txtBoxUser
			// 
			this.txtBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBoxUser.Location = new System.Drawing.Point(16, 22);
			this.txtBoxUser.Multiline = true;
			this.txtBoxUser.Name = "txtBoxUser";
			this.txtBoxUser.Size = new System.Drawing.Size(321, 45);
			this.txtBoxUser.TabIndex = 1;
			this.txtBoxUser.Text = "Email or Username";
			// 
			// txtBoxPass
			// 
			this.txtBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBoxPass.Location = new System.Drawing.Point(16, 86);
			this.txtBoxPass.Multiline = true;
			this.txtBoxPass.Name = "txtBoxPass";
			this.txtBoxPass.Size = new System.Drawing.Size(321, 45);
			this.txtBoxPass.TabIndex = 2;
			this.txtBoxPass.Text = "Password";
			this.txtBoxPass.UseSystemPasswordChar = true;
			// 
			// bttnSubmit
			// 
			this.bttnSubmit.BackColor = System.Drawing.SystemColors.Highlight;
			this.bttnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bttnSubmit.ForeColor = System.Drawing.Color.Transparent;
			this.bttnSubmit.Location = new System.Drawing.Point(16, 150);
			this.bttnSubmit.Name = "bttnSubmit";
			this.bttnSubmit.Size = new System.Drawing.Size(321, 44);
			this.bttnSubmit.TabIndex = 3;
			this.bttnSubmit.Text = "Log In";
			this.bttnSubmit.UseVisualStyleBackColor = false;
			this.bttnSubmit.Click += new System.EventHandler(this.BttnSubmitClick);
			// 
			// pnlLogin
			// 
			this.pnlLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pnlLogin.Controls.Add(this.bttnNewAcc);
			this.pnlLogin.Controls.Add(this.bttnSubmit);
			this.pnlLogin.Controls.Add(this.txtBoxUser);
			this.pnlLogin.Controls.Add(this.txtBoxPass);
			this.pnlLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.pnlLogin.Location = new System.Drawing.Point(566, 88);
			this.pnlLogin.Name = "pnlLogin";
			this.pnlLogin.Size = new System.Drawing.Size(359, 317);
			this.pnlLogin.TabIndex = 4;
			// 
			// bttnNewAcc
			// 
			this.bttnNewAcc.BackColor = System.Drawing.Color.GreenYellow;
			this.bttnNewAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bttnNewAcc.ForeColor = System.Drawing.Color.Transparent;
			this.bttnNewAcc.Location = new System.Drawing.Point(16, 248);
			this.bttnNewAcc.Name = "bttnNewAcc";
			this.bttnNewAcc.Size = new System.Drawing.Size(321, 44);
			this.bttnNewAcc.TabIndex = 4;
			this.bttnNewAcc.Text = "Create New Account";
			this.bttnNewAcc.UseVisualStyleBackColor = false;
			this.bttnNewAcc.Click += new System.EventHandler(this.BttnNewAccClick);
			// 
			// txtFb2
			// 
			this.txtFb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFb2.Location = new System.Drawing.Point(99, 222);
			this.txtFb2.Name = "txtFb2";
			this.txtFb2.Size = new System.Drawing.Size(354, 111);
			this.txtFb2.TabIndex = 5;
			this.txtFb2.Text = "Connect with friends and the world around you on Facebook.";
			// 
			// pnlSignup
			// 
			this.pnlSignup.BackColor = System.Drawing.SystemColors.HighlightText;
			this.pnlSignup.Controls.Add(this.checkPass);
			this.pnlSignup.Controls.Add(this.bttnSignup);
			this.pnlSignup.Controls.Add(this.txtSignConPass);
			this.pnlSignup.Controls.Add(this.txtSignPass);
			this.pnlSignup.Controls.Add(this.txtSignUser);
			this.pnlSignup.Location = new System.Drawing.Point(566, 88);
			this.pnlSignup.Name = "pnlSignup";
			this.pnlSignup.Size = new System.Drawing.Size(359, 317);
			this.pnlSignup.TabIndex = 6;
			// 
			// checkPass
			// 
			this.checkPass.Location = new System.Drawing.Point(16, 206);
			this.checkPass.Name = "checkPass";
			this.checkPass.Size = new System.Drawing.Size(163, 24);
			this.checkPass.TabIndex = 7;
			this.checkPass.Text = "SHOW PASSWORD";
			this.checkPass.UseVisualStyleBackColor = true;
			this.checkPass.CheckedChanged += new System.EventHandler(this.CheckPassCheckedChanged);
			// 
			// bttnSignup
			// 
			this.bttnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bttnSignup.Location = new System.Drawing.Point(16, 236);
			this.bttnSignup.Name = "bttnSignup";
			this.bttnSignup.Size = new System.Drawing.Size(321, 56);
			this.bttnSignup.TabIndex = 3;
			this.bttnSignup.Text = "Sign Up";
			this.bttnSignup.UseVisualStyleBackColor = true;
			this.bttnSignup.Click += new System.EventHandler(this.BttnSignupClick);
			// 
			// txtSignConPass
			// 
			this.txtSignConPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSignConPass.Location = new System.Drawing.Point(16, 162);
			this.txtSignConPass.Multiline = true;
			this.txtSignConPass.Name = "txtSignConPass";
			this.txtSignConPass.Size = new System.Drawing.Size(321, 32);
			this.txtSignConPass.TabIndex = 2;
			this.txtSignConPass.Text = "Confirm Password";
			this.txtSignConPass.UseSystemPasswordChar = true;
			// 
			// txtSignPass
			// 
			this.txtSignPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSignPass.Location = new System.Drawing.Point(16, 89);
			this.txtSignPass.Multiline = true;
			this.txtSignPass.Name = "txtSignPass";
			this.txtSignPass.Size = new System.Drawing.Size(321, 34);
			this.txtSignPass.TabIndex = 1;
			this.txtSignPass.Text = "Password";
			this.txtSignPass.UseSystemPasswordChar = true;
			// 
			// txtSignUser
			// 
			this.txtSignUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSignUser.Location = new System.Drawing.Point(16, 22);
			this.txtSignUser.Multiline = true;
			this.txtSignUser.Name = "txtSignUser";
			this.txtSignUser.Size = new System.Drawing.Size(321, 34);
			this.txtSignUser.TabIndex = 0;
			this.txtSignUser.Text = "Email Or Username";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.ClientSize = new System.Drawing.Size(1043, 493);
			this.Controls.Add(this.txtFb2);
			this.Controls.Add(this.txtFb1);
			this.Controls.Add(this.pnlLogin);
			this.Controls.Add(this.pnlSignup);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "facebook";
			this.pnlLogin.ResumeLayout(false);
			this.pnlLogin.PerformLayout();
			this.pnlSignup.ResumeLayout(false);
			this.pnlSignup.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.CheckBox checkPass;
		private System.Windows.Forms.TextBox txtSignUser;
		private System.Windows.Forms.TextBox txtSignPass;
		private System.Windows.Forms.TextBox txtSignConPass;
		private System.Windows.Forms.Button bttnSignup;
		private System.Windows.Forms.Panel pnlSignup;
		private System.Windows.Forms.Button bttnNewAcc;
		private System.Windows.Forms.Label txtFb2;
		private System.Windows.Forms.Panel pnlLogin;
		private System.Windows.Forms.Button bttnSubmit;
		private System.Windows.Forms.TextBox txtBoxPass;
		private System.Windows.Forms.TextBox txtBoxUser;
		private System.Windows.Forms.Label txtFb1;
	}
}
