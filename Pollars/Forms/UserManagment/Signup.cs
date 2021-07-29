using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pollars.Forms.UserManagment
{
	public partial class Signup : Form
	{
		public Signup()
		{
			InitializeComponent();
		}

		private void BtnReturn_Click(object sender, EventArgs e)
		{
			var formLogin = Program.ServiceProvider.GetRequiredService<Login>();
			formLogin.Show();
			this.Hide();

		}
	}
}
