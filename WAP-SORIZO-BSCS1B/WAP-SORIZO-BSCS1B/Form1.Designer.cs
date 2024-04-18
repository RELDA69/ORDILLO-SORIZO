/*
 * Created by SharpDevelop.
 * User: g
 * Date: 15/04/2024
 * Time: 7:45 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace WAP_SORIZO_BSCS1B
{
	partial class frmLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.picFBLOGO = new System.Windows.Forms.PictureBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.pnlLogoPFP = new System.Windows.Forms.Panel();
			this.picPFP = new System.Windows.Forms.PictureBox();
			this.picCover = new System.Windows.Forms.PictureBox();
			this.bttnStory = new System.Windows.Forms.Button();
			this.bttnEdit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picFBLOGO)).BeginInit();
			this.pnlLogoPFP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picPFP)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
			this.SuspendLayout();
			// 
			// picFBLOGO
			// 
			this.picFBLOGO.BackColor = System.Drawing.SystemColors.Window;
			this.picFBLOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.picFBLOGO.Image = ((System.Drawing.Image)(resources.GetObject("picFBLOGO.Image")));
			this.picFBLOGO.Location = new System.Drawing.Point(0, 0);
			this.picFBLOGO.Margin = new System.Windows.Forms.Padding(0);
			this.picFBLOGO.Name = "picFBLOGO";
			this.picFBLOGO.Size = new System.Drawing.Size(62, 63);
			this.picFBLOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picFBLOGO.TabIndex = 2;
			this.picFBLOGO.TabStop = false;
			// 
			// txtSearch
			// 
			this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
			this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(80, 22);
			this.txtSearch.Multiline = true;
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.ShortcutsEnabled = false;
			this.txtSearch.Size = new System.Drawing.Size(243, 36);
			this.txtSearch.TabIndex = 3;
			this.txtSearch.Text = "⌕ Search Facebook";
			this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblName
			// 
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(186, 451);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(190, 35);
			this.lblName.TabIndex = 5;
			this.lblName.Text = "Darrel Sorizo";
			// 
			// pnlLogoPFP
			// 
			this.pnlLogoPFP.BackColor = System.Drawing.SystemColors.Highlight;
			this.pnlLogoPFP.Controls.Add(this.picFBLOGO);
			this.pnlLogoPFP.Location = new System.Drawing.Point(12, 12);
			this.pnlLogoPFP.Name = "pnlLogoPFP";
			this.pnlLogoPFP.Size = new System.Drawing.Size(1019, 63);
			this.pnlLogoPFP.TabIndex = 7;
			// 
			// picPFP
			// 
			this.picPFP.Image = ((System.Drawing.Image)(resources.GetObject("picPFP.Image")));
			this.picPFP.Location = new System.Drawing.Point(57, 370);
			this.picPFP.Name = "picPFP";
			this.picPFP.Size = new System.Drawing.Size(123, 160);
			this.picPFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picPFP.TabIndex = 8;
			this.picPFP.TabStop = false;
			// 
			// picCover
			// 
			this.picCover.Image = ((System.Drawing.Image)(resources.GetObject("picCover.Image")));
			this.picCover.Location = new System.Drawing.Point(12, 81);
			this.picCover.Name = "picCover";
			this.picCover.Size = new System.Drawing.Size(1019, 362);
			this.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCover.TabIndex = 9;
			this.picCover.TabStop = false;
			// 
			// bttnStory
			// 
			this.bttnStory.BackColor = System.Drawing.SystemColors.Highlight;
			this.bttnStory.Location = new System.Drawing.Point(682, 452);
			this.bttnStory.Name = "bttnStory";
			this.bttnStory.Size = new System.Drawing.Size(151, 34);
			this.bttnStory.TabIndex = 12;
			this.bttnStory.Text = "✚ Add Story";
			this.bttnStory.UseVisualStyleBackColor = false;
			// 
			// bttnEdit
			// 
			this.bttnEdit.Location = new System.Drawing.Point(850, 452);
			this.bttnEdit.Name = "bttnEdit";
			this.bttnEdit.Size = new System.Drawing.Size(151, 35);
			this.bttnEdit.TabIndex = 13;
			this.bttnEdit.Text = "✎ Edit Profile";
			this.bttnEdit.UseVisualStyleBackColor = true;
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1043, 586);
			this.Controls.Add(this.bttnEdit);
			this.Controls.Add(this.bttnStory);
			this.Controls.Add(this.picPFP);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.pnlLogoPFP);
			this.Controls.Add(this.picCover);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "facebook";
			((System.ComponentModel.ISupportInitialize)(this.picFBLOGO)).EndInit();
			this.pnlLogoPFP.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picPFP)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button bttnEdit;
		private System.Windows.Forms.Button bttnStory;
		private System.Windows.Forms.PictureBox picCover;
		private System.Windows.Forms.PictureBox picPFP;
		private System.Windows.Forms.Panel pnlLogoPFP;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.PictureBox picFBLOGO;
	}
}
