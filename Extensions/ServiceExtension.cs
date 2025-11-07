using MudBlazor.Services;
using PortfolioWebsite.Components.Layout;

namespace PortfolioWebsite.Extensions
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.AddMudServices();
            // Register repositories

            services.AddScoped<IScrollInfoService, ScrollInfoService>();

            //parametri di main layout
            services.AddScoped<MainLayoutParams>();

            return services;
        }
    }
}