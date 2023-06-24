namespace TopUpAD_GUI
{
	partial class Dashboard
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
			this.btn_users = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_users
			// 
			this.btn_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_users.Image = global::TopUpAD_GUI.Properties.Resources.man__1_;
			this.btn_users.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_users.Location = new System.Drawing.Point(92, 194);
			this.btn_users.Name = "btn_users";
			this.btn_users.Size = new System.Drawing.Size(214, 185);
			this.btn_users.TabIndex = 1;
			this.btn_users.Text = "User Management";
			this.btn_users.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_users.UseVisualStyleBackColor = true;
			this.btn_users.Click += new System.EventHandler(this.Btn_users_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.Image = global::TopUpAD_GUI.Properties.Resources.logout;
			this.button1.Location = new System.Drawing.Point(646, 63);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 80);
			this.button1.TabIndex = 0;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(879, 453);
			this.Controls.Add(this.btn_users);
			this.Controls.Add(this.button1);
			this.Name = "Dashboard";
			this.Text = "Dashboard";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btn_users;
	}
}