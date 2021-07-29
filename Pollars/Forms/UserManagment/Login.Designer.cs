
namespace Pollars.Forms.UserManagment
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.BtnSignUp = new System.Windows.Forms.Button();
			this.TxtUser = new System.Windows.Forms.TextBox();
			this.TxtPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.BtnLogin = new System.Windows.Forms.Button();
			this.LabelUserError = new System.Windows.Forms.Label();
			this.LabelPasswordError = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Controls.Add(this.BtnSignUp, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.TxtUser, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.TxtPassword, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.BtnLogin, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.LabelUserError, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.LabelPasswordError, 3, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 7;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// BtnSignUp
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.BtnSignUp, 2);
			this.BtnSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnSignUp.Location = new System.Drawing.Point(163, 265);
			this.BtnSignUp.Name = "BtnSignUp";
			this.BtnSignUp.Size = new System.Drawing.Size(474, 34);
			this.BtnSignUp.TabIndex = 10;
			this.BtnSignUp.Text = "Registrarse";
			this.BtnSignUp.UseVisualStyleBackColor = true;
			this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
			// 
			// TxtUser
			// 
			this.TxtUser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtUser.Location = new System.Drawing.Point(323, 150);
			this.TxtUser.Name = "TxtUser";
			this.TxtUser.Size = new System.Drawing.Size(314, 27);
			this.TxtUser.TabIndex = 0;
			// 
			// TxtPassword
			// 
			this.TxtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtPassword.Location = new System.Drawing.Point(323, 175);
			this.TxtPassword.Name = "TxtPassword";
			this.TxtPassword.Size = new System.Drawing.Size(314, 27);
			this.TxtPassword.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(163, 147);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Usuario";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(163, 172);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Contraseña";
			// 
			// BtnLogin
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.BtnLogin, 2);
			this.BtnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnLogin.Location = new System.Drawing.Point(163, 225);
			this.BtnLogin.Name = "BtnLogin";
			this.BtnLogin.Size = new System.Drawing.Size(474, 34);
			this.BtnLogin.TabIndex = 7;
			this.BtnLogin.Text = "Ingresar";
			this.BtnLogin.UseVisualStyleBackColor = true;
			this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
			// 
			// LabelUserError
			// 
			this.LabelUserError.AutoSize = true;
			this.LabelUserError.ForeColor = System.Drawing.Color.Red;
			this.LabelUserError.Location = new System.Drawing.Point(643, 147);
			this.LabelUserError.Name = "LabelUserError";
			this.LabelUserError.Size = new System.Drawing.Size(0, 20);
			this.LabelUserError.TabIndex = 8;
			// 
			// LabelPasswordError
			// 
			this.LabelPasswordError.AutoSize = true;
			this.LabelPasswordError.ForeColor = System.Drawing.Color.Red;
			this.LabelPasswordError.Location = new System.Drawing.Point(643, 172);
			this.LabelPasswordError.Name = "LabelPasswordError";
			this.LabelPasswordError.Size = new System.Drawing.Size(0, 20);
			this.LabelPasswordError.TabIndex = 9;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Login";
			this.Text = "Login";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox TxtUser;
		private System.Windows.Forms.TextBox TxtPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button BtnLogin;
		private System.Windows.Forms.Label LabelUserError;
		private System.Windows.Forms.Label LabelPasswordError;
		private System.Windows.Forms.Button BtnSignUp;
	}
}