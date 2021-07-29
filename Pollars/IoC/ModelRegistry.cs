using Microsoft.Extensions.DependencyInjection;
using Pollar.Model.Contexts;
using Pollars.Models;

namespace Pollars.IoC
{
	public static class ModelRegistry
	{
		public static void AddModelRegistry(this IServiceCollection services)
		{
			services.AddTransient<PollarsContext>();
		}
	}
}
