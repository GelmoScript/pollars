using Microsoft.Extensions.DependencyInjection;
using Pollar.Service.IoC;
using Pollars.Dtos;
using Pollars.Forms.UserManagment;
using Pollars.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pollars
{
	static class Program
	{
		public static IServiceProvider ServiceProvider { get; set; }
		public static UserDto CurrentUser { get; set; }

		static void ConfigureServices()
		{
			var services = new ServiceCollection();

			services.AddFormRegistry();
			services.AddModelRegistry();
			services.AddServiceRegistry();

			services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
			ServiceProvider = services.BuildServiceProvider();
		}
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			ConfigureServices();

			var initialForm = ServiceProvider.GetRequiredService<Login>();
			Application.Run(initialForm);
		}
	}
}
