using Microsoft.Extensions.DependencyInjection;
using Pollars.Services;

namespace Pollar.Service.IoC
{
	public static class ServiceRegistry
	{
		public static void AddServiceRegistry(this IServiceCollection services)
		{
			services.AddTransient<IUserService, UserService>();
		}
	}
}
