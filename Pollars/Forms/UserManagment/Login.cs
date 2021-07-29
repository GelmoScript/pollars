using Microsoft.Extensions.DependencyInjection;
using Pollars.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pollars.Forms.UserManagment
{
	public partial class Login : Form
	{
		private readonly IUserService _userService;
		public Login(IUserService userService)
		{
			InitializeComponent();
			_userService = userService;
		}

		private async void BtnLogin_Click(object sender, EventArgs e)
		{
			string username = TxtUser.Text;
			string password = TxtPassword.Text;

			var user = await _userService.GetByUsername(username);
			bool userExists = user != null;

			if (!userExists)
			{
				LabelUserError.Text = "Usuario no existe";
				return;
			}

			if (user.Password != password)
			{
				LabelPasswordError.Text = "Contraseña incorrecta";
			}

			Program.CurrentUser = user;
		}

		private void BtnSignUp_Click(object sender, EventArgs e)
		{
			var formSignup = Program.ServiceProvider.GetRequiredService<Signup>();
			formSignup.Show();
			this.Hide();
		}
	}
}
