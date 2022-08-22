using BlazorEssentials.Models;
using BlazorEssentials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Net_BlazorEssentialsMaui.Services;

namespace Net_BlazorEssentialsMaui.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddBlazorEssentialsMaui(this IServiceCollection services, string BaseURL)
        {
            services.AddScoped<IStorageManager, StorageManager>();
            services.AddScoped<ILocationService, LocationServiceMaui>();
            services.AddScoped<Interop>();
            services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(BaseURL) });
            services.AddScoped<IAuthService, AuthService>();

            return services;
        }
    }
}
