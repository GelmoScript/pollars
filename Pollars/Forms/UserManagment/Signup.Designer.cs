
namespace Pollars.Forms.UserManagment
{
	partial class Signup
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
			this.BtnReturn = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.TxtName = new System.Windows.Forms.TextBox();
			this.TxtLastname = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.TxtConfPassword = new System.Windows.Forms.TextBox();
			this.BtnSignUp = new System.Windows.Forms.Button();
			this.TxtUser = new System.Windows.Forms.TextBox();
			this.TxtPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
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
			this.tableLayoutPanel1.Controls.Add(this.BtnReturn, 1, 8);
			this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.TxtName, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.TxtLastname, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.TxtConfPassword, 2, 5);
			this.tableLayoutPanel1.Controls.Add(this.BtnSignUp, 1, 7);
			this.tableLayoutPanel1.Controls.Add(this.TxtUser, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.TxtPassword, 2, 4);
			this.tableLayoutPanel1.Controls.Add(this.label1, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label2, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.LabelUserError, 3, 3);
			this.tableLayoutPanel1.Controls.Add(this.LabelPasswordError, 3, 4);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 10;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// BtnReturn
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.BtnReturn, 2);
			this.BtnReturn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnReturn.Location = new System.Drawing.Point(163, 310);
			this.BtnReturn.Name = "BtnReturn";
			this.BtnReturn.Size = new System.Drawing.Size(474, 34);
			this.BtnReturn.TabIndex = 17;
			this.BtnReturn.Text = "Volver";
			this.BtnReturn.UseVisualStyleBackColor = true;
			this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(163, 127);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 20);
			this.label5.TabIndex = 16;
			this.label5.Text = "Apellido";
			// 
			// TxtName
			// 
			this.TxtName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtName.Location = new System.Drawing.Point(323, 105);
			this.TxtName.Name = "TxtName";
			this.TxtName.Size = new System.Drawing.Size(314, 27);
			this.TxtName.TabIndex = 15;
			// 
			// TxtLastname
			// 
			this.TxtLastname.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtLastname.Location = new System.Drawing.Point(323, 130);
			this.TxtLastname.Name = "TxtLastname";
			this.TxtLastname.Size = new System.Drawing.Size(314, 27);
			this.TxtLastname.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(163, 102);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 20);
			this.label4.TabIndex = 13;
			this.label4.Text = "Nombre";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(163, 202);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(151, 20);
			this.label3.TabIndex = 12;
			this.label3.Text = "Confirmar contraseña";
			// 
			// TxtConfPassword
			// 
			this.TxtConfPassword.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtConfPassword.Location = new System.Drawing.Point(323, 205);
			this.TxtConfPassword.Name = "TxtConfPassword";
			this.TxtConfPassword.Size = new System.Drawing.Size(314, 27);
			this.TxtConfPassword.TabIndex = 11;
			// 
			// BtnSignUp
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.BtnSignUp, 2);
			this.BtnSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnSignUp.Location = new System.Drawing.Point(163, 270);
			this.BtnSignUp.Name = "BtnSignUp";
			this.BtnSignUp.Size = new System.Drawing.Size(474, 34);
			this.BtnSignUp.TabIndex = 10;
			this.BtnSignUp.Text = "Registrarse";
			this.BtnSignUp.UseVisualStyleBackColor = true;
			// 
			// TxtUser
			// 
			this.TxtUser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtUser.Location = new System.Drawing.Point(323, 155);
			this.TxtUser.Name = "TxtUser";
			this.TxtUser.Size = new System.Drawing.Size(314, 27);
			this.TxtUser.TabIndex = 0;
			// 
			// TxtPassword
			// 
			this.TxtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtPassword.Location = new System.Drawing.Point(323, 180);
			this.TxtPassword.Name = "TxtPassword";
			this.TxtPassword.Size = new System.Drawing.Size(314, 27);
			this.TxtPassword.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(163, 152);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Usuario";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(163, 177);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Contraseña";
			// 
			// LabelUserError
			// 
			this.LabelUserError.AutoSize = true;
			this.LabelUserError.ForeColor = System.Drawing.Color.Red;
			this.LabelUserError.Location = new System.Drawing.Point(643, 152);
			this.LabelUserError.Name = "LabelUserError";
			this.LabelUserError.Size = new System.Drawing.Size(0, 20);
			this.LabelUserError.TabIndex = 8;
			// 
			// LabelPasswordError
			// 
			this.LabelPasswordError.AutoSize = true;
			this.LabelPasswordError.ForeColor = System.Drawing.Color.Red;
			this.LabelPasswordError.Location = new System.Drawing.Point(643, 177);
			this.LabelPasswordError.Name = "LabelPasswordError";
			this.LabelPasswordError.Size = new System.Drawing.Size(0, 20);
			this.LabelPasswordError.TabIndex = 9;
			// 
			// Signup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Signup";
			this.Text = "Signup";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button BtnSignUp;
		private System.Windows.Forms.TextBox TxtUser;
		private System.Windows.Forms.TextBox TxtPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label LabelUserError;
		private System.Windows.Forms.Label LabelPasswordError;
		private System.Windows.Forms.TextBox TxtLastname;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TxtConfPassword;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TxtName;
		private System.Windows.Forms.Button BtnReturn;
	}
}