using Microsoft.Extensions.DependencyInjection;
using Pollars.Forms.UserManagment;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pollars.IoC
{
	public static class FormRegistry
	{
		public static void AddFormRegistry(this IServiceCollection services)
		{
			services.AddTransient<Login>();
			services.AddTransient<Signup>();
		}
	}
}
