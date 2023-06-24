namespace TopUpAD_GUI
{
	partial class Login
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label_uname = new System.Windows.Forms.Label();
			this.label_psw = new System.Windows.Forms.Label();
			this.tb_uname = new System.Windows.Forms.TextBox();
			this.tb_psw = new System.Windows.Forms.TextBox();
			this.btn_login = new System.Windows.Forms.Button();
			this.btn_clear = new System.Windows.Forms.Button();
			this.pictureBox_login = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_login)).BeginInit();
			this.SuspendLayout();
			// 
			// label_uname
			// 
			this.label_uname.AutoSize = true;
			this.label_uname.Location = new System.Drawing.Point(65, 244);
			this.label_uname.Name = "label_uname";
			this.label_uname.Size = new System.Drawing.Size(73, 17);
			this.label_uname.TabIndex = 0;
			this.label_uname.Text = "Username";
			// 
			// label_psw
			// 
			this.label_psw.AutoSize = true;
			this.label_psw.Location = new System.Drawing.Point(68, 292);
			this.label_psw.Name = "label_psw";
			this.label_psw.Size = new System.Drawing.Size(69, 17);
			this.label_psw.TabIndex = 1;
			this.label_psw.Text = "Password";
			// 
			// tb_uname
			// 
			this.tb_uname.Location = new System.Drawing.Point(148, 244);
			this.tb_uname.Name = "tb_uname";
			this.tb_uname.Size = new System.Drawing.Size(150, 22);
			this.tb_uname.TabIndex = 2;
			this.tb_uname.Enter += new System.EventHandler(this.Tb_uname_Enter);
			this.tb_uname.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Tb_uname_MouseDoubleClick);
			// 
			// tb_psw
			// 
			this.tb_psw.Location = new System.Drawing.Point(148, 292);
			this.tb_psw.Name = "tb_psw";
			this.tb_psw.Size = new System.Drawing.Size(150, 22);
			this.tb_psw.TabIndex = 3;
			this.tb_psw.UseSystemPasswordChar = true;
			// 
			// btn_login
			// 
			this.btn_login.Location = new System.Drawing.Point(196, 373);
			this.btn_login.Name = "btn_login";
			this.btn_login.Size = new System.Drawing.Size(86, 34);
			this.btn_login.TabIndex = 4;
			this.btn_login.Text = "Login";
			this.btn_login.UseVisualStyleBackColor = true;
			this.btn_login.Click += new System.EventHandler(this.Button1_Click);
			// 
			// btn_clear
			// 
			this.btn_clear.Location = new System.Drawing.Point(83, 373);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(86, 34);
			this.btn_clear.TabIndex = 5;
			this.btn_clear.Text = "Clear";
			this.btn_clear.UseVisualStyleBackColor = true;
			// 
			// pictureBox_login
			// 
			this.pictureBox_login.Image = global::TopUpAD_GUI.Properties.Resources.profile;
			this.pictureBox_login.Location = new System.Drawing.Point(138, 39);
			this.pictureBox_login.Name = "pictureBox_login";
			this.pictureBox_login.Size = new System.Drawing.Size(132, 137);
			this.pictureBox_login.TabIndex = 6;
			this.pictureBox_login.TabStop = false;
			this.pictureBox_login.Click += new System.EventHandler(this.PictureBox1_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(396, 459);
			this.Controls.Add(this.pictureBox_login);
			this.Controls.Add(this.btn_clear);
			this.Controls.Add(this.btn_login);
			this.Controls.Add(this.tb_psw);
			this.Controls.Add(this.tb_uname);
			this.Controls.Add(this.label_psw);
			this.Controls.Add(this.label_uname);
			this.Name = "Login";
			this.Text = "User Login";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_login)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_uname;
		private System.Windows.Forms.Label label_psw;
		private System.Windows.Forms.TextBox tb_uname;
		private System.Windows.Forms.TextBox tb_psw;
		private System.Windows.Forms.Button btn_login;
		private System.Windows.Forms.Button btn_clear;
		private System.Windows.Forms.PictureBox pictureBox_login;
	}
}

