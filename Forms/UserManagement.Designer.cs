namespace TopUpAD_GUI
{
	partial class UserManagement
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_uname = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tb_name = new System.Windows.Forms.TextBox();
			this.tb_uname = new System.Windows.Forms.TextBox();
			this.tb_psw = new System.Windows.Forms.TextBox();
			this.tb_contact = new System.Windows.Forms.TextBox();
			this.btn_save = new System.Windows.Forms.Button();
			this.btn_clear = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_id = new System.Windows.Forms.TextBox();
			this.btn_search = new System.Windows.Forms.Button();
			this.btn_home = new System.Windows.Forms.Button();
			this.btn_load = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(253, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(238, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "User Management";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(58, 141);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name";
			// 
			// lbl_uname
			// 
			this.lbl_uname.AutoSize = true;
			this.lbl_uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_uname.Location = new System.Drawing.Point(58, 185);
			this.lbl_uname.Name = "lbl_uname";
			this.lbl_uname.Size = new System.Drawing.Size(97, 24);
			this.lbl_uname.TabIndex = 2;
			this.lbl_uname.Text = "Username";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(58, 229);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 24);
			this.label4.TabIndex = 3;
			this.label4.Text = "Password";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(58, 280);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 24);
			this.label5.TabIndex = 4;
			this.label5.Text = "Contact";
			// 
			// tb_name
			// 
			this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_name.Location = new System.Drawing.Point(183, 141);
			this.tb_name.Name = "tb_name";
			this.tb_name.Size = new System.Drawing.Size(185, 28);
			this.tb_name.TabIndex = 5;
			// 
			// tb_uname
			// 
			this.tb_uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_uname.Location = new System.Drawing.Point(183, 185);
			this.tb_uname.Name = "tb_uname";
			this.tb_uname.Size = new System.Drawing.Size(185, 28);
			this.tb_uname.TabIndex = 6;
			// 
			// tb_psw
			// 
			this.tb_psw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_psw.Location = new System.Drawing.Point(183, 239);
			this.tb_psw.Name = "tb_psw";
			this.tb_psw.Size = new System.Drawing.Size(185, 28);
			this.tb_psw.TabIndex = 7;
			// 
			// tb_contact
			// 
			this.tb_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_contact.Location = new System.Drawing.Point(183, 280);
			this.tb_contact.Name = "tb_contact";
			this.tb_contact.Size = new System.Drawing.Size(185, 28);
			this.tb_contact.TabIndex = 8;
			// 
			// btn_save
			// 
			this.btn_save.Location = new System.Drawing.Point(249, 358);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(104, 33);
			this.btn_save.TabIndex = 9;
			this.btn_save.Text = "Save";
			this.btn_save.UseVisualStyleBackColor = true;
			this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
			// 
			// btn_clear
			// 
			this.btn_clear.Location = new System.Drawing.Point(107, 358);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(104, 33);
			this.btn_clear.TabIndex = 10;
			this.btn_clear.Text = "Clear";
			this.btn_clear.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(530, 117);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(375, 274);
			this.dataGridView1.TabIndex = 11;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(58, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 24);
			this.label3.TabIndex = 13;
			this.label3.Text = "ID";
			// 
			// tb_id
			// 
			this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_id.Location = new System.Drawing.Point(183, 91);
			this.tb_id.Name = "tb_id";
			this.tb_id.Size = new System.Drawing.Size(97, 28);
			this.tb_id.TabIndex = 14;
			// 
			// btn_search
			// 
			this.btn_search.Image = global::TopUpAD_GUI.Properties.Resources.search;
			this.btn_search.Location = new System.Drawing.Point(298, 91);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(55, 28);
			this.btn_search.TabIndex = 15;
			this.btn_search.UseVisualStyleBackColor = true;
			this.btn_search.Click += new System.EventHandler(this.Btn_search_Click);
			// 
			// btn_home
			// 
			this.btn_home.Image = global::TopUpAD_GUI.Properties.Resources.house;
			this.btn_home.Location = new System.Drawing.Point(856, 21);
			this.btn_home.Name = "btn_home";
			this.btn_home.Size = new System.Drawing.Size(49, 54);
			this.btn_home.TabIndex = 12;
			this.btn_home.UseVisualStyleBackColor = true;
			this.btn_home.Click += new System.EventHandler(this.Btn_home_Click);
			// 
			// btn_load
			// 
			this.btn_load.Location = new System.Drawing.Point(723, 69);
			this.btn_load.Name = "btn_load";
			this.btn_load.Size = new System.Drawing.Size(104, 33);
			this.btn_load.TabIndex = 16;
			this.btn_load.Text = "Load All";
			this.btn_load.UseVisualStyleBackColor = true;
			this.btn_load.Click += new System.EventHandler(this.Btn_load_Click);
			// 
			// UserManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(931, 450);
			this.Controls.Add(this.btn_load);
			this.Controls.Add(this.btn_search);
			this.Controls.Add(this.tb_id);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_home);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_clear);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.tb_contact);
			this.Controls.Add(this.tb_psw);
			this.Controls.Add(this.tb_uname);
			this.Controls.Add(this.tb_name);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lbl_uname);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "UserManagement";
			this.Text = "UserManagement";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl_uname;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tb_name;
		private System.Windows.Forms.TextBox tb_uname;
		private System.Windows.Forms.TextBox tb_psw;
		private System.Windows.Forms.TextBox tb_contact;
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.Button btn_clear;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_home;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_id;
		private System.Windows.Forms.Button btn_search;
		private System.Windows.Forms.Button btn_load;
	}
}